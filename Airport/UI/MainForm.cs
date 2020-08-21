using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using Airport.Entity;
using Airport.src.Entity;
using Airport.UI;

namespace Airport
{
    public partial class MainForm : Form
    {
        public static int AirplaneForShedule;
        private Dictionary<Tuple<string, string>, int> dictToFromDistance;
        private Airport airport;
        private DateTime dt;
        private List<DistanceFromTo> distList = new List<DistanceFromTo>();

        public MainForm()
        {
            InitializeComponent();

            // Добавляем иконки на вкладки 
            AddIconOnTabControl();
 
            airport = new Airport();
            airport.Balance = 10000;

            // Подписываемся на событие изменения баланса, чтобы не пришлось каждый раз обновлять соответствующий tbBalance
            airport.BalanceChanged += param =>
            {
                tbBalance.Text = airport.Balance.ToString();
            };

            airport.FuelChanged += param =>
            {
                tbFuel.Text = airport.Fuel.ToString();
            };

            airport.FuelPriceChanged += param =>
            {
                tbFuelPrice.Text = airport.FuelPrice.ToString();
            };

            airport.Balance = 10000000;
            airport.Fuel = 300000.0;
            airport.FuelPrice = 30.0;
            
            LoadDistances();

            LoadListAirplanesToBuy();
            LoadAirplanesOfTheAirport();
            FillListFlights();

            dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            timer.Interval = 1000;
            timer.Enabled = true;

            now = DateTime.Now;
            timer.Tick += timer_Tick;
            timer.Start();
            GenerateFlights();
        }

        private DateTime now;
        private int lastDay = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timer.Interval == 1)
            {
                 dt = dt.AddMinutes(3);
                 dt = dt.AddSeconds(1);
                 dt = dt.AddSeconds(10);
            }
            else if (timer.Interval < 32)
                dt = dt.AddSeconds(50);
            else if (timer.Interval < 32)
                dt = dt.AddSeconds(40);
            else if (timer.Interval < 63)
                dt = dt.AddSeconds(30);
            else if (timer.Interval < 126)
                dt = dt.AddSeconds(20);
            else if (timer.Interval < 251)
                dt = dt.AddSeconds(10);
            else dt = dt.AddSeconds(1);

            lblTime.Text = dt.ToString();
            if (dt.Hour == 0 && dt.Day != lastDay)
            {
                new Thread(() => { Invoke(new Action(() => GenerateFlights())); }).Start();
                CheckRent();
                lastDay = dt.Day;
            }

            OutInFlight();
        }

        private void CheckRent()
        {
            for (int i = 0; i < airport.ListAirplanes.Count; i++)
                if (airport.ListAirplanes[i].Status == Airplane.StatusAirplane.INRENT &&
                    dt.ToShortDateString().Equals(airport.ListAirplanes[i].Tenancy))
                {
                    airport.Balance -= airport.ListAirplanes[i].PriceToRent;
                    foreach (DataGridViewRow row in dgvAirplanesOfTheAirport.Rows)
                    {
                        if (row.Cells[0].Value.Equals(airport.ListAirplanes[i].Model))
                            dgvAirplanesOfTheAirport.Rows.Remove(row);
                    }
                    airport.ListAirplanes.RemoveAt(i);
                }
                else if (airport.ListAirplanes[i].Status == Airplane.StatusAirplane.INRENT)
                    airport.Balance -= airport.ListAirplanes[i].PriceToRent;
                else if (airport.ListAirplanes[i].Status == Airplane.StatusAirplane.INLEASING &&
                    dt.ToShortDateString().Equals(airport.ListAirplanes[i].Tenancy))
                {
                    airport.Balance -= airport.ListAirplanes[i].PriceToRent;
                    airport.ListAirplanes[i].Status = Airplane.StatusAirplane.BOUGHT;
                }
                else if (airport.ListAirplanes[i].Status == Airplane.StatusAirplane.INLEASING)
                    airport.Balance -= airport.ListAirplanes[i].PriceToRent;
        }

        private void OutInFlight()
        {
            if (double.Parse(tbFuel.Text) <= 10000)
                tbFuel.BackColor = Color.Red;
            else tbFuel.BackColor = Color.White;

            if (double.Parse(tbBalance.Text) <= 0)
            {
                tbBalance.BackColor = Color.Red;
                timer.Stop();
                MessageBox.Show("Вы проиграли :(");
                Close();
            }
            else tbBalance.BackColor = Color.White;

            foreach (DataGridViewRow row in dgvFlights.Rows)
            {
                if (DateTime.Parse(row.Cells[1].Value.ToString()) < dt)
                    dgvFlights.Rows.Remove(row);
            }

            foreach (DataGridViewRow row in dgvShedule.Rows)
            {
                if (DateTime.Parse(row.Cells[2].Value.ToString()) > dt && DateTime.Parse(row.Cells[1].Value.ToString()) < dt && !(row.Cells[6] is DataGridViewButtonCell))
                    row.DefaultCellStyle.BackColor = Color.Blue;
                else if (DateTime.Parse(row.Cells[1].Value.ToString()) < dt && row.Cells[6] is DataGridViewButtonCell || DateTime.Parse(row.Cells[1].Value.ToString()) < dt && airport.Fuel < 0.1 * double.Parse(row.Cells[5].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    airport.ListShedule.RemoveAt(
                        airport.ListShedule.FindIndex(x => x.Number == (int) row.Cells[0].Value));
                    dgvShedule.Rows.Remove(row);
                    airport.Balance -= rnd.Next(10000, 50000);
                }
                else if (dt > DateTime.Parse(row.Cells[2].Value.ToString()) && row.Cells[6] is DataGridViewTextBoxCell)
                {
                    int dist = airport.ListShedule[airport.ListShedule.FindIndex(x => x.Number == (int)row.Cells[0].Value)].Distance;
                    int indPlane = airport.ListAirplanes.FindIndex(x => x.Model.Equals(row.Cells[6].Value));
                    airport.Balance += airport
                        .ListShedule[airport.ListShedule.FindIndex(x => x.Number == (int) row.Cells[0].Value)].Profit;
                    airport.Fuel -= airport.ListAirplanes[indPlane].FuelConsumption * dist;
                    airport.ListAirplanes[airport.ListAirplanes.FindIndex(x => x.Model.Equals(row.Cells[6].Value))]
                        .Location = row.Cells[4].Value.ToString();
                    airport.ListShedule.RemoveAt(
                        airport.ListShedule.FindIndex(x => x.Number == (int)row.Cells[0].Value));
                    dgvShedule.Rows.Remove(row);
                    //airport.ListAirplanes[airport.ListAirplanes.FindIndex(x => x.Model.Equals(row.Cells[6].Value))]
                    //    .inShedule = false;
                    airport.ListAirplanes[indPlane]
                        .Wear += rnd.Next(1,5);
                    airport.ListAirplanes[airport.ListAirplanes.FindIndex(x => x.Model.Equals(row.Cells[6].Value))]
                        .PriceToSell -= dist;
                    if (airport.ListAirplanes[indPlane].Wear > 10)
                    {
                        airport.ListAirplanes[indPlane].dtFinichFix = dt.AddHours(5);
                        airport.ListAirplanes[indPlane].Wear = rnd.Next(0, 2);
                        airport.Balance -= airport.ListAirplanes[indPlane].Wear * 5500;
                    }
                    else
                    {
                        airport.ListAirplanes[indPlane].dtFinichFix = dt.AddHours(2);
                        airport.Balance -= 5000;
                    }
                }
            }

            foreach (var plane in airport.ListAirplanes)
            {
                if (plane.dtFinichFix != null && dt > plane.dtFinichFix)
                    plane.inShedule = false;
            }
        }


        public List<string> GetListCities()
        {
            List<string> citiesList = new List<string>();
            foreach (var dist in distList)
            {
                citiesList.Add(dist.From);
            }
            return citiesList;
        }

        Random rnd = new Random();

        private DateTime GenerateDate(int plusDaysBegin, int plusDaysEnd)
        {
            DateTime dt = this.dt.AddDays(rnd.Next(plusDaysBegin, plusDaysEnd));
            dt = dt.AddHours(-dt.Hour + rnd.Next(0, 24));
            dt = dt.AddMinutes(-dt.Minute + rnd.Next(0, 60));
            return dt;
        }

        private bool f = false;
        private void GenerateFlights()
        {
            int countFlight = rnd.Next(1, 10);
            for (int i = 0; i < countFlight; i++)
            {
                DistanceFromTo d = distList[rnd.Next(1, distList.Count - 1)];
                DateTime dt = GenerateDate(i+1, i+2);
                airport.ListFlights.Add(new Flight(airport.NumberFlight, d.From, d.To,
                    dt,
                    dt.AddHours(d.Distance / 600.0),
                    (Flight.TypeFlieght)rnd.Next(0, 2),
                    (Flight.RegularityFlieght)rnd.Next(0, 3),
                    d.Distance,
                    rnd.Next(10000, 100000),
                    0,
                    rnd.Next(10, 300),
                    rnd.Next(10, 100)));

                airport.NumberFlight += 1;
            }
            FillListFlights();
            if (!f)
            {
                f = true;
                return;
            }
             

            double oldFuelPrice = airport.FuelPrice;
            airport.FuelPrice *= rnd.Next(5, 15) / 10.0;
            string s = airport.FuelPrice.ToString();
            double percent = Math.Abs(100-airport.FuelPrice / oldFuelPrice * 100);
            if (airport.FuelPrice > oldFuelPrice)
            {
                s += " (↑" + percent + "%)";
                tbFuelPrice.Text = s;
                tbFuelPrice.BackColor = Color.Chartreuse;
                new Thread (() =>
                    {
                        Thread.Sleep(1000);
                        tbFuelPrice.Invoke(new Action(() => tbFuelPrice.BackColor = Color.White));
                        Thread.Sleep(1000);
                        tbFuelPrice.Invoke(new Action(() => tbFuelPrice.BackColor = Color.Chartreuse));
                        Thread.Sleep(1000);
                        tbFuelPrice.Invoke(new Action(() => tbFuelPrice.BackColor = Color.White));
                        tbFuelPrice.Invoke(new Action(() => tbFuelPrice.Text = airport.FuelPrice.ToString()));
                    }
                ).Start();
            }
            else
            {
                s += " (↓" + percent + "%)";
                tbFuelPrice.Text = s;
                tbFuelPrice.BackColor = Color.Red;
                new Thread(() =>
                    {
                        Thread.Sleep(1000);
                        tbFuelPrice.Invoke(new Action(() => tbFuelPrice.BackColor = Color.White));
                        Thread.Sleep(1000);
                        tbFuelPrice.Invoke(new Action(() => tbFuelPrice.BackColor = Color.Red));
                        Thread.Sleep(1000);
                        tbFuelPrice.Invoke(new Action(() => tbFuelPrice.BackColor = Color.White));
                        tbFuelPrice.Invoke(new Action(() => tbFuelPrice.Text = airport.FuelPrice.ToString()));
                    }
                ).Start();
            }
        }

        private void LoadDistances()
        {
            distList.Clear();
            using (StreamReader sr = new StreamReader("Resources\\Distances.txt", System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var str = line.Split(' ');
                    distList.Add(new DistanceFromTo(str[0], str[1], int.Parse(str[2])));
                    distList.Add(new DistanceFromTo(str[1], str[0], int.Parse(str[2])));
                }
            }
        }

        private void FillListShedule()
        {
            foreach (var sheduleItem in airport.ListShedule)
            {
                dgvShedule.Rows.Add();
                DataGridViewRow row = dgvShedule.Rows[dgvShedule.Rows.Count - 1];
                row.Cells[0].Value = sheduleItem.Number;
                row.Cells[1].Value = sheduleItem.DateAndTimeDeparture.ToString();
                row.Cells[2].Value = sheduleItem.DateAndTimeArrival.ToString();
                row.Cells[3].Value = sheduleItem.From;
                row.Cells[4].Value = sheduleItem.To;
                row.Cells[5].Value = sheduleItem.Distance;
                row.Cells[6].Value = sheduleItem.AirplaneFlight.Model;
            }
        }

        static void Save(Airport airport)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("airport.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, airport);
            }
        }

        static Airport Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Airport airport = null;
            using (FileStream fs = new FileStream("airport.dat", FileMode.OpenOrCreate))
            {
                airport = (Airport)formatter.Deserialize(fs);
            }
            return airport;
        }

        private void FillListFlights()
        {
            dgvFlights.Rows.Clear();
            foreach (var flight in airport.ListFlights)
            {
                dgvFlights.Rows.Add();

                DataGridViewRow row = dgvFlights.Rows[dgvFlights.Rows.Count-1];
                row.Cells[0].Value = flight.Number;
                row.Cells[1].Value = flight.DateAndTimeDeparture.ToString();
                row.Cells[2].Value = flight.DateAndTimeArrival.ToString();
                row.Cells[3].Value = flight.From;
                row.Cells[4].Value = flight.To;
                row.Cells[5].Value = flight.Type == Flight.TypeFlieght.PASSENGER ? "Passenger" :
                    flight.Type == Flight.TypeFlieght.CARGO ? "Cargo" : "Empty";
                row.Cells[6].Value = flight.Regularity == Flight.RegularityFlieght.SINGLETO ? "Single one-way" :
                    flight.Regularity == Flight.RegularityFlieght.SINGLETOFROM ? "Single with a return" :
                    flight.Regularity == Flight.RegularityFlieght.REGULARITYTO ? "Regularity one-way" : "Regularity with a return";
                row.Cells[7].Value = flight.Distance;
                row.Cells[8].Value = flight.Profit;
                row.Cells[10].Value = flight.Carrying;
                row.Cells[11].Value = flight.PassengerСapacity;
            }
        }


        // Добавление иконок на вкладки
        private void AddIconOnTabControl()
        {
            ImageList imL = new ImageList();
            imL.Images.Add(new Icon("Resources\\schedule.ico"));
            imL.Images.Add(new Icon("Resources\\airplane.ico"));
            imL.Images.Add(new Icon("Resources\\map.ico"));
            imL.Images.Add(new Icon("Resources\\fuel.ico"));

            tabControl.ImageList = imL;
            for (int i = 0; i < 4; i++)
                tabControl.TabPages[i].ImageIndex = i;
        }

        //  Загрузка имеющихся самолетов
        private void LoadAirplanesOfTheAirport()
        {
            dgvAirplanesOfTheAirport.Rows.Clear();
            foreach (var plane in airport.ListAirplanes)
                dgvAirplanesOfTheAirport.Rows.Add(plane.Model);
        }

        // Загрузка самолетов, которые доступны для покупки
        private void LoadListAirplanesToBuy()
        {
            airport.ListAirplanesToBuy.Clear();
            using (StreamReader sr = new StreamReader("Resources\\Airplanes\\AirplanesList.txt", System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var str = line.Split(',');
                    airport.ListAirplanesToBuy.Add(new Airplane(
                            str[0].Trim(),
                            int.Parse(str[1].Trim()),
                            int.Parse(str[2].Trim()),
                            int.Parse(str[3].Trim()),
                            int.Parse(str[4].Trim()),
                            int.Parse(str[5].Trim()),
                            int.Parse(str[6].Trim()),
                            int.Parse(str[7].Trim()),
                            int.Parse(str[8].Trim()),
                            int.Parse(str[9].Trim()),
                            int.Parse(str[10].Trim()),
                            new Bitmap($"Resources\\Airplanes\\{str[0].Split(' ')[1].Trim().ToUpper()}.jpg"),
                            Airplane.StatusAirplane.INMARKET,
                            "0"
                        )
                    );
                    dgvAirplanesToBuy.Rows.Add(str[0].Trim());
                }
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            FormBorderStyle = WindowState == FormWindowState.Maximized ? FormBorderStyle.None : FormBorderStyle.Sizable;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape) return;
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private Airplane CopyAirplane(Airplane from)
        {
            return new Airplane(from.Model, from.PriceToBuy, from.PriceToSell, from.PriceToRent, from.PriceToLeasing, from.Carrying, from.PassengerСapacity,
                from.Wear, from.FuelConsumption, from.Speed, from.RangeFlight, from.AirplaneImage, from.Status, from.Tenancy);
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            if (dgvAirplanesToBuy.SelectedRows.Count == 0 || dgvAirplaneData.Rows.Count == 0) return;
            int idx = dgvAirplanesToBuy.SelectedRows[0].Index;                                                 
            airport.ListAirplanes.Add(CopyAirplane(airport.ListAirplanesToBuy[idx]));
            dgvAirplanesOfTheAirport.Rows.Add(airport.ListAirplanes[airport.ListAirplanes.Count - 1].Model);
            airport.Balance -= (int)dgvAirplaneData.Rows[1].Cells[1].Value;
            airport.ListAirplanes[airport.ListAirplanes.Count - 1].Status = Airplane.StatusAirplane.BOUGHT;   //изменяем статус на куплен
        }

        private void dgvFlights_MouseDown(object sender, MouseEventArgs e)
        {
            dgvFlights.DoDragDrop(dgvFlights.SelectedRows, DragDropEffects.Move);
        }

        private void dgvShedule_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvShedule_DragDrop(object sender, DragEventArgs e)
        {
            if (dgvFlights.SelectedRows.Count == 0) return;
            
            DataGridViewRow selectedRow = dgvFlights.SelectedRows[0];

            dgvShedule.Rows.Add();
            DataGridViewRow row = dgvShedule.Rows[dgvShedule.Rows.Count - 1];

            int i = 0;
            foreach (DataGridViewCell cell in selectedRow.Cells)
            {
                row.Cells[i++].Value = cell.Value;
                if (i == 5) break; 
            }

            row.Cells[5].Value = selectedRow.Cells[7].Value;
           // row.Cells[6].Value = airport.ListAirplanes[AirplaneForShedule].Model;
            var bt =  new DataGridViewButtonCell();
            bt.Value = "Assign";
            row.Cells[6] = bt;
            airport.ListShedule.Add(airport.ListFlights.Where(x=>x.Number == (int) row.Cells[0].Value).ToList()[0]);
            dgvFlights.Rows.Remove(selectedRow);
            airport.ListFlights.RemoveAll(x => x.Number == (int) row.Cells[0].Value);
            //airport.ListShedule[airport.ListShedule.Count - 1].AirplaneFlight =
            //    airport.ListAirplanes[AirplaneForShedule];
        }

        private void dgvShedule_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var rowa = dgvShedule.SelectedRows[0];
            int dist = airport.ListShedule[airport.ListShedule.FindIndex(x => x.Number == (int)rowa.Cells[0].Value)].Distance;

            if (dist * 30 > double.Parse(tbFuel.Text))
            {
                MessageBox.Show("Слишком мало топлива!!!");
                return;
            }

            if (e.ColumnIndex == 6 && dgvShedule.Rows[e.RowIndex].Cells[6] is DataGridViewButtonCell)
            {
                DataGridViewRow row = dgvShedule.Rows[e.RowIndex];
                List<Airplane> goodAirplanes = new List<Airplane>();
                Flight flight = airport.ListShedule[airport.ListShedule.FindIndex(x => x.Number == (int)row.Cells[0].Value)];
                foreach (var airplane in airport.ListAirplanes)
                {
                    if (airplane.RangeFlight > flight.Distance &&
                        (airplane.PassengerСapacity > flight.PassengerСapacity &&
                         flight.Type == Flight.TypeFlieght.PASSENGER ||
                         airplane.Carrying > flight.Carrying && flight.Type == Flight.TypeFlieght.CARGO) &&
                        !airplane.inShedule)
                        goodAirplanes.Add(airplane);
                }
                ChoiceAirplaneForm frm = new ChoiceAirplaneForm(goodAirplanes);
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
                row.Cells[6] = new DataGridViewTextBoxCell();
                row.Cells[6].Value = airport.ListAirplanes[AirplaneForShedule].Model;
                    var el = airport.ListShedule[airport.ListShedule.FindIndex(x => x.Number == (int)row.Cells[0].Value)];
                el.AirplaneFlight =
                    airport.ListAirplanes[AirplaneForShedule];
                airport.ListAirplanes[AirplaneForShedule].inShedule = true;
                //if (!el.From.Equals(airport.ListAirplanes[AirplaneForShedule].Location))
                //{
                //    Info frmInfo = new Info();
                //    if (frmInfo.ShowDialog() == DialogResult.OK)
                //    {
                //        airport.Balance -= 20;
                //        airp
                //    }

                //}

                // ПОЛОЖЕНИЕ САМОЛЕТА!!!!
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save(airport);
            timer.Stop();
        }

        private void FillAirplaneData(Airplane selecredAirplane)
        {
            dgvAirplaneData.Rows.Clear();

            dgvAirplaneData.Rows.Add("Model", selecredAirplane.Model.Split('(')[0]);
            if (selecredAirplane.Status == Airplane.StatusAirplane.INMARKET)
            {
                dgvAirplaneData.Rows.Add("Price to buy (rub)", selecredAirplane.PriceToBuy);
                dgvAirplaneData.Rows.Add("Price to rent (rub)", selecredAirplane.PriceToRent);
                dgvAirplaneData.Rows.Add("Price to leasing (rub)", selecredAirplane.PriceToLeasing);
            }
            else if (selecredAirplane.Status == Airplane.StatusAirplane.BOUGHT)
                dgvAirplaneData.Rows.Add("Price to sell", selecredAirplane.PriceToSell);
            else if (selecredAirplane.Status == Airplane.StatusAirplane.INLEASING)
                dgvAirplaneData.Rows.Add("Price to leasing (rub)", selecredAirplane.PriceToLeasing);
            else dgvAirplaneData.Rows.Add("Price to rent (rub)", selecredAirplane.PriceToRent);
            dgvAirplaneData.Rows.Add("Carrying (t)", selecredAirplane.Carrying);
            dgvAirplaneData.Rows.Add("Passenger capacity", selecredAirplane.PassengerСapacity);
            dgvAirplaneData.Rows.Add("Wear (%)", selecredAirplane.Wear);
            dgvAirplaneData.Rows.Add("Fuel consumption (l/km)", selecredAirplane.FuelConsumption);
            dgvAirplaneData.Rows.Add("Speed", selecredAirplane.Speed);
            dgvAirplaneData.Rows.Add("Range of flight (km)", selecredAirplane.RangeFlight);
            dgvAirplaneData.Rows.Add("Location", selecredAirplane.Location);
            dgvAirplaneData.Rows.Add("Status", selecredAirplane.Status == Airplane.StatusAirplane.INLEASING ? "In leasing" :
                selecredAirplane.Status == Airplane.StatusAirplane.BOUGHT ? "Bought" : selecredAirplane.Status == Airplane.StatusAirplane.INRENT ? "In rent" : "In market");

            pbAirplaneData.Image = selecredAirplane.AirplaneImage;
        }

        private void btSell_Click(object sender, EventArgs e)
        {
            if (dgvAirplanesOfTheAirport.SelectedRows.Count > 0)
            {
                string model = (string)dgvAirplanesOfTheAirport.SelectedRows[0].Cells[0].Value;
                int idx = dgvAirplanesOfTheAirport.SelectedRows[0].Index;
                if (airport.ListAirplanes.Where(x => x.Model == model).LastOrDefault().Status != Airplane.StatusAirplane.BOUGHT) return;
                airport.Balance += (int)dgvAirplaneData.Rows[1].Cells[1].Value * 1000;
                airport.ListAirplanes.Remove(airport.ListAirplanes.Where(x => x.Model == model).LastOrDefault());
                dgvAirplanesOfTheAirport.Rows.RemoveAt(idx);
            }
        }

        private void btSpeedDown_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            btSpeedDown.Enabled = false;
            btSpeedUp.Enabled = true;
        }

        private void btSpeedUp_Click(object sender, EventArgs e)
        {
            int interval = timer.Interval;
            if (interval > 1)
            {
                timer.Interval = interval / 2;
                btSpeedUp.Enabled = true;
                btSpeedDown.Enabled = true;
            }
            else btSpeedUp.Enabled = false;
        }

        private void btRent_Click(object sender, EventArgs e)
        {
            if (dgvAirplanesToBuy.SelectedRows.Count == 0 || dgvAirplaneData.Rows.Count == 0) return;
            int price = (int)dgvAirplaneData.Rows[3].Cells[1].Value;                                     //цена за аренду
            Rent rent = new Rent(price);
            rent.Activate();
            if (rent.ShowDialog() != DialogResult.OK)
                return;
            int idx = dgvAirplanesToBuy.SelectedRows[0].Index;                                                  //самолет, которые хотят взять в аренду
            airport.ListAirplanes.Add(CopyAirplane(airport.ListAirplanesToBuy[idx]));                           //добавляем самолет в аэропорт
            dgvAirplanesOfTheAirport.Rows.Add(airport.ListAirplanes[airport.ListAirplanes.Count - 1].Model);
            airport.ListAirplanes[airport.ListAirplanes.Count - 1].Status = Airplane.StatusAirplane.INRENT;     //указываем, что самолет в аренде 
            airport.ListAirplanes[airport.ListAirplanes.Count - 1].Tenancy = rent.tenancy;                      //устанавливаем дату окончания аренды

        }

        private void btLeasing_Click(object sender, EventArgs e)
        {
            if (dgvAirplanesToBuy.SelectedRows.Count == 0 || dgvAirplaneData.Rows.Count == 0) return;
            double priceL = (int)dgvAirplaneData.Rows[3].Cells[1].Value;                                     //цена за лизинг в месяц
            double priceAll = (int)dgvAirplaneData.Rows[1].Cells[1].Value;
            Leasing leasing = new Leasing(priceL, priceAll, dt);
            leasing.Activate();
            if (leasing.ShowDialog() != DialogResult.OK)
                return;
            int idx = dgvAirplanesToBuy.SelectedRows[0].Index;                                                  //самолет, которые хотят взять в лизинг
            airport.ListAirplanes.Add(CopyAirplane(airport.ListAirplanesToBuy[idx]));                           //добавляем самолет в аэропорт
            dgvAirplanesOfTheAirport.Rows.Add(airport.ListAirplanes[airport.ListAirplanes.Count - 1].Model);
            airport.ListAirplanes[airport.ListAirplanes.Count - 1].Status = Airplane.StatusAirplane.INLEASING;     //указываем, что самолет в лизинге 
            airport.ListAirplanes[airport.ListAirplanes.Count - 1].Tenancy = leasing.tenancy;                      //устанавливаем дату, когда самолет перейдет в собственность 

        }

        private void dgvAirplanesOfTheAirport_MouseDown(object sender, MouseEventArgs e)
        {
            dgvAirplaneData.ClearSelection();
            dgvAirplanesToBuy.ClearSelection();
            btRent.Enabled = false;
            btLeasing.Enabled = false;
        }

        private void dgvAirplanesToBuy_MouseDown(object sender, MouseEventArgs e)
        {
            dgvAirplaneData.ClearSelection();
            dgvAirplanesOfTheAirport.ClearSelection();
            btRent.Enabled = true;
            btLeasing.Enabled = true;
        }

        private void btFuelBuy_Click(object sender, EventArgs e)
        {
            try
            {
                double fuelToBuyCount = double.Parse(tbFuelBuyCount.Text);
                double currentFuelPrice = double.Parse(tbFuelPrice.Text);

                airport.Balance -= fuelToBuyCount * currentFuelPrice;
                airport.Fuel += fuelToBuyCount;
                tbFuelBuyCount.Text = "";
            }
            catch
            {
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvAirplanesOfTheAirport.SelectedRows.Count != 0)
                FillAirplaneData(airport.ListAirplanes[dgvAirplanesOfTheAirport.SelectedRows[0].Index]);
            else if (dgvAirplanesToBuy.SelectedRows.Count != 0)
                FillAirplaneData(airport.ListAirplanesToBuy[dgvAirplanesToBuy.SelectedRows[0].Index]);
        }

        private void dgvAirplanesOfTheAirport_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAirplanesOfTheAirport.SelectedRows.Count <= 0) return;
            FillAirplaneData(airport.ListAirplanes[dgvAirplanesOfTheAirport.SelectedRows[0].Index]);
        }

        private void dgvAirplanesToBuy_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAirplanesToBuy.SelectedRows.Count <= 0) return;
            FillAirplaneData(airport.ListAirplanesToBuy[dgvAirplanesToBuy.SelectedRows[0].Index]);
        }
    }
}
