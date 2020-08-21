using System.Windows.Forms;

namespace Airport
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btSpeedUp = new System.Windows.Forms.Button();
            this.btSpeedDown = new System.Windows.Forms.Button();
            this.lblAirport = new System.Windows.Forms.Label();
            this.lblSimulator = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpSheduleAndFlights = new System.Windows.Forms.TabPage();
            this.tableSheduleAndFlights = new System.Windows.Forms.TableLayoutPanel();
            this.gbFlights = new System.Windows.Forms.GroupBox();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.ClmnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDateDepartureFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDateArrivalFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnRegularity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnForfeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCarrying = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPeopleCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbShedule = new System.Windows.Forms.GroupBox();
            this.dgvShedule = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDateDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDateArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnAirplane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpAirplanes = new System.Windows.Forms.TabPage();
            this.tableAirplanes = new System.Windows.Forms.TableLayoutPanel();
            this.tablePlanesData = new System.Windows.Forms.TableLayoutPanel();
            this.gbAirplaneData = new System.Windows.Forms.GroupBox();
            this.dgvAirplaneData = new System.Windows.Forms.DataGridView();
            this.ClmnParametr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePlanesButton = new System.Windows.Forms.TableLayoutPanel();
            this.btRent = new System.Windows.Forms.Button();
            this.btLeasing = new System.Windows.Forms.Button();
            this.btBuy = new System.Windows.Forms.Button();
            this.btSell = new System.Windows.Forms.Button();
            this.tablePlanesOurAndToBuy = new System.Windows.Forms.TableLayoutPanel();
            this.gbAirportPlanes = new System.Windows.Forms.GroupBox();
            this.dgvAirplanesOfTheAirport = new System.Windows.Forms.DataGridView();
            this.ClmnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPlanesToBuy = new System.Windows.Forms.GroupBox();
            this.dgvAirplanesToBuy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbAirplaneData = new System.Windows.Forms.PictureBox();
            this.tpMap = new System.Windows.Forms.TabPage();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbFuelPrice = new System.Windows.Forms.TextBox();
            this.lblFuelPrice = new System.Windows.Forms.Label();
            this.gbDateAndTime = new System.Windows.Forms.GroupBox();
            this.tableDateAndTime = new System.Windows.Forms.TableLayoutPanel();
            this.lblTime = new System.Windows.Forms.Label();
            this.gbBalance = new System.Windows.Forms.GroupBox();
            this.gbFuel = new System.Windows.Forms.GroupBox();
            this.tableFuel = new System.Windows.Forms.TableLayoutPanel();
            this.tbFuel = new System.Windows.Forms.TextBox();
            this.lblL = new System.Windows.Forms.Label();
            this.tableAllPane = new System.Windows.Forms.TableLayoutPanel();
            this.tableHead = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btFuelBuy = new System.Windows.Forms.Button();
            this.tbFuelBuyCount = new System.Windows.Forms.TextBox();
            this.pbAirplane = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tpSheduleAndFlights.SuspendLayout();
            this.tableSheduleAndFlights.SuspendLayout();
            this.gbFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.gbShedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShedule)).BeginInit();
            this.tpAirplanes.SuspendLayout();
            this.tableAirplanes.SuspendLayout();
            this.tablePlanesData.SuspendLayout();
            this.gbAirplaneData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirplaneData)).BeginInit();
            this.tablePlanesButton.SuspendLayout();
            this.tablePlanesOurAndToBuy.SuspendLayout();
            this.gbAirportPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirplanesOfTheAirport)).BeginInit();
            this.gbPlanesToBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirplanesToBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAirplaneData)).BeginInit();
            this.tpMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.gbDateAndTime.SuspendLayout();
            this.tableDateAndTime.SuspendLayout();
            this.gbBalance.SuspendLayout();
            this.gbFuel.SuspendLayout();
            this.tableFuel.SuspendLayout();
            this.tableAllPane.SuspendLayout();
            this.tableHead.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAirplane)).BeginInit();
            this.SuspendLayout();
            // 
            // btSpeedUp
            // 
            this.btSpeedUp.BackColor = System.Drawing.Color.White;
            this.btSpeedUp.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSpeedUp.ForeColor = System.Drawing.Color.Black;
            this.btSpeedUp.Location = new System.Drawing.Point(371, 4);
            this.btSpeedUp.Margin = new System.Windows.Forms.Padding(4);
            this.btSpeedUp.Name = "btSpeedUp";
            this.btSpeedUp.Size = new System.Drawing.Size(42, 27);
            this.btSpeedUp.TabIndex = 10;
            this.btSpeedUp.Text = ">>";
            this.btSpeedUp.UseVisualStyleBackColor = false;
            this.btSpeedUp.Click += new System.EventHandler(this.btSpeedUp_Click);
            // 
            // btSpeedDown
            // 
            this.btSpeedDown.BackColor = System.Drawing.Color.White;
            this.btSpeedDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpeedDown.ForeColor = System.Drawing.Color.Black;
            this.btSpeedDown.Location = new System.Drawing.Point(300, 4);
            this.btSpeedDown.Margin = new System.Windows.Forms.Padding(4);
            this.btSpeedDown.Name = "btSpeedDown";
            this.btSpeedDown.Size = new System.Drawing.Size(44, 27);
            this.btSpeedDown.TabIndex = 11;
            this.btSpeedDown.Text = "▬";
            this.btSpeedDown.UseVisualStyleBackColor = false;
            this.btSpeedDown.Click += new System.EventHandler(this.btSpeedDown_Click);
            // 
            // lblAirport
            // 
            this.lblAirport.AutoSize = true;
            this.lblAirport.BackColor = System.Drawing.Color.Transparent;
            this.lblAirport.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAirport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAirport.Location = new System.Drawing.Point(248, 2);
            this.lblAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirport.Name = "lblAirport";
            this.lblAirport.Size = new System.Drawing.Size(383, 147);
            this.lblAirport.TabIndex = 16;
            this.lblAirport.Text = "Airport";
            // 
            // lblSimulator
            // 
            this.lblSimulator.AutoSize = true;
            this.lblSimulator.BackColor = System.Drawing.Color.Transparent;
            this.lblSimulator.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSimulator.Location = new System.Drawing.Point(449, 104);
            this.lblSimulator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimulator.Name = "lblSimulator";
            this.lblSimulator.Size = new System.Drawing.Size(196, 54);
            this.lblSimulator.TabIndex = 17;
            this.lblSimulator.Text = "simulator";
            // 
            // tbBalance
            // 
            this.tbBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBalance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBalance.Location = new System.Drawing.Point(4, 29);
            this.tbBalance.Margin = new System.Windows.Forms.Padding(4);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(204, 44);
            this.tbBalance.TabIndex = 19;
            this.tbBalance.Text = "10000";
            // 
            // tabControl
            // 
            this.tabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabControl.Controls.Add(this.tpSheduleAndFlights);
            this.tabControl.Controls.Add(this.tpAirplanes);
            this.tabControl.Controls.Add(this.tpMap);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.ItemSize = new System.Drawing.Size(50, 50);
            this.tabControl.Location = new System.Drawing.Point(4, 175);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1487, 616);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 24;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpSheduleAndFlights
            // 
            this.tpSheduleAndFlights.AccessibleName = "";
            this.tpSheduleAndFlights.BackColor = System.Drawing.Color.Black;
            this.tpSheduleAndFlights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpSheduleAndFlights.Controls.Add(this.tableSheduleAndFlights);
            this.tpSheduleAndFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpSheduleAndFlights.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpSheduleAndFlights.Location = new System.Drawing.Point(4, 54);
            this.tpSheduleAndFlights.Margin = new System.Windows.Forms.Padding(4);
            this.tpSheduleAndFlights.Name = "tpSheduleAndFlights";
            this.tpSheduleAndFlights.Padding = new System.Windows.Forms.Padding(4);
            this.tpSheduleAndFlights.Size = new System.Drawing.Size(1479, 558);
            this.tpSheduleAndFlights.TabIndex = 0;
            // 
            // tableSheduleAndFlights
            // 
            this.tableSheduleAndFlights.BackColor = System.Drawing.Color.Transparent;
            this.tableSheduleAndFlights.ColumnCount = 1;
            this.tableSheduleAndFlights.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSheduleAndFlights.Controls.Add(this.gbFlights, 0, 1);
            this.tableSheduleAndFlights.Controls.Add(this.gbShedule, 0, 0);
            this.tableSheduleAndFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSheduleAndFlights.Location = new System.Drawing.Point(4, 4);
            this.tableSheduleAndFlights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableSheduleAndFlights.Name = "tableSheduleAndFlights";
            this.tableSheduleAndFlights.RowCount = 2;
            this.tableSheduleAndFlights.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSheduleAndFlights.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSheduleAndFlights.Size = new System.Drawing.Size(1471, 550);
            this.tableSheduleAndFlights.TabIndex = 0;
            // 
            // gbFlights
            // 
            this.gbFlights.BackColor = System.Drawing.Color.Transparent;
            this.gbFlights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbFlights.Controls.Add(this.dgvFlights);
            this.gbFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFlights.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFlights.ForeColor = System.Drawing.Color.White;
            this.gbFlights.Location = new System.Drawing.Point(4, 279);
            this.gbFlights.Margin = new System.Windows.Forms.Padding(4);
            this.gbFlights.Name = "gbFlights";
            this.gbFlights.Padding = new System.Windows.Forms.Padding(4);
            this.gbFlights.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbFlights.Size = new System.Drawing.Size(1463, 267);
            this.gbFlights.TabIndex = 33;
            this.gbFlights.TabStop = false;
            this.gbFlights.Text = "Flights";
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowDrop = true;
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            this.dgvFlights.AllowUserToOrderColumns = true;
            this.dgvFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlights.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFlights.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnNumber,
            this.ClmnDateDepartureFlight,
            this.ClmnDateArrivalFlight,
            this.ClmnFrom,
            this.ClmnTo,
            this.ClmnType,
            this.ClmnRegularity,
            this.ClmnDistance,
            this.ClmnProfit,
            this.ClmnForfeit,
            this.ClmnCarrying,
            this.ClmnPeopleCapacity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlights.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFlights.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvFlights.EnableHeadersVisualStyles = false;
            this.dgvFlights.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFlights.Location = new System.Drawing.Point(4, 29);
            this.dgvFlights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlights.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFlights.RowHeadersVisible = false;
            this.dgvFlights.RowTemplate.Height = 24;
            this.dgvFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlights.Size = new System.Drawing.Size(1455, 234);
            this.dgvFlights.TabIndex = 0;
            this.dgvFlights.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvFlights_MouseDown);
            // 
            // ClmnNumber
            // 
            this.ClmnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmnNumber.HeaderText = "Num";
            this.ClmnNumber.Name = "ClmnNumber";
            this.ClmnNumber.ReadOnly = true;
            this.ClmnNumber.Width = 79;
            // 
            // ClmnDateDepartureFlight
            // 
            this.ClmnDateDepartureFlight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmnDateDepartureFlight.HeaderText = "Date departure";
            this.ClmnDateDepartureFlight.Name = "ClmnDateDepartureFlight";
            this.ClmnDateDepartureFlight.ReadOnly = true;
            this.ClmnDateDepartureFlight.Width = 170;
            // 
            // ClmnDateArrivalFlight
            // 
            this.ClmnDateArrivalFlight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmnDateArrivalFlight.HeaderText = "Date arrival";
            this.ClmnDateArrivalFlight.Name = "ClmnDateArrivalFlight";
            this.ClmnDateArrivalFlight.ReadOnly = true;
            this.ClmnDateArrivalFlight.Width = 140;
            // 
            // ClmnFrom
            // 
            this.ClmnFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmnFrom.HeaderText = "From";
            this.ClmnFrom.Name = "ClmnFrom";
            this.ClmnFrom.ReadOnly = true;
            this.ClmnFrom.Width = 82;
            // 
            // ClmnTo
            // 
            this.ClmnTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmnTo.HeaderText = "To";
            this.ClmnTo.Name = "ClmnTo";
            this.ClmnTo.ReadOnly = true;
            this.ClmnTo.Width = 59;
            // 
            // ClmnType
            // 
            this.ClmnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmnType.HeaderText = "Type";
            this.ClmnType.Name = "ClmnType";
            this.ClmnType.ReadOnly = true;
            this.ClmnType.Width = 78;
            // 
            // ClmnRegularity
            // 
            this.ClmnRegularity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmnRegularity.HeaderText = "Regularity";
            this.ClmnRegularity.Name = "ClmnRegularity";
            this.ClmnRegularity.ReadOnly = true;
            this.ClmnRegularity.Width = 126;
            // 
            // ClmnDistance
            // 
            this.ClmnDistance.HeaderText = "Distance";
            this.ClmnDistance.Name = "ClmnDistance";
            this.ClmnDistance.ReadOnly = true;
            // 
            // ClmnProfit
            // 
            this.ClmnProfit.HeaderText = "Profit";
            this.ClmnProfit.Name = "ClmnProfit";
            this.ClmnProfit.ReadOnly = true;
            // 
            // ClmnForfeit
            // 
            this.ClmnForfeit.HeaderText = "Forfeit";
            this.ClmnForfeit.Name = "ClmnForfeit";
            this.ClmnForfeit.ReadOnly = true;
            this.ClmnForfeit.Visible = false;
            // 
            // ClmnCarrying
            // 
            this.ClmnCarrying.HeaderText = "Carrying";
            this.ClmnCarrying.Name = "ClmnCarrying";
            this.ClmnCarrying.ReadOnly = true;
            // 
            // ClmnPeopleCapacity
            // 
            this.ClmnPeopleCapacity.HeaderText = "People capacity";
            this.ClmnPeopleCapacity.Name = "ClmnPeopleCapacity";
            this.ClmnPeopleCapacity.ReadOnly = true;
            // 
            // gbShedule
            // 
            this.gbShedule.BackColor = System.Drawing.Color.Transparent;
            this.gbShedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbShedule.Controls.Add(this.dgvShedule);
            this.gbShedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbShedule.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbShedule.ForeColor = System.Drawing.Color.White;
            this.gbShedule.Location = new System.Drawing.Point(4, 4);
            this.gbShedule.Margin = new System.Windows.Forms.Padding(4);
            this.gbShedule.Name = "gbShedule";
            this.gbShedule.Padding = new System.Windows.Forms.Padding(4);
            this.gbShedule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbShedule.Size = new System.Drawing.Size(1463, 267);
            this.gbShedule.TabIndex = 32;
            this.gbShedule.TabStop = false;
            this.gbShedule.Text = "Shedule";
            // 
            // dgvShedule
            // 
            this.dgvShedule.AllowDrop = true;
            this.dgvShedule.AllowUserToAddRows = false;
            this.dgvShedule.AllowUserToDeleteRows = false;
            this.dgvShedule.AllowUserToOrderColumns = true;
            this.dgvShedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShedule.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ClmnDateDeparture,
            this.ClmnDateArrival,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.ClmnAirplane});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShedule.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvShedule.EnableHeadersVisualStyles = false;
            this.dgvShedule.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvShedule.Location = new System.Drawing.Point(4, 29);
            this.dgvShedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShedule.Name = "dgvShedule";
            this.dgvShedule.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShedule.RowHeadersVisible = false;
            this.dgvShedule.RowTemplate.Height = 24;
            this.dgvShedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShedule.Size = new System.Drawing.Size(1455, 234);
            this.dgvShedule.TabIndex = 1;
            this.dgvShedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShedule_CellContentClick_1);
            this.dgvShedule.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvShedule_DragDrop);
            this.dgvShedule.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvShedule_DragEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Flight";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 87;
            // 
            // ClmnDateDeparture
            // 
            this.ClmnDateDeparture.HeaderText = "Date departure";
            this.ClmnDateDeparture.Name = "ClmnDateDeparture";
            this.ClmnDateDeparture.ReadOnly = true;
            // 
            // ClmnDateArrival
            // 
            this.ClmnDateArrival.HeaderText = "Date arrival";
            this.ClmnDateArrival.Name = "ClmnDateArrival";
            this.ClmnDateArrival.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "From";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "To";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "Distance";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 112;
            // 
            // ClmnAirplane
            // 
            this.ClmnAirplane.HeaderText = "Airplane";
            this.ClmnAirplane.Name = "ClmnAirplane";
            this.ClmnAirplane.ReadOnly = true;
            // 
            // tpAirplanes
            // 
            this.tpAirplanes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpAirplanes.Controls.Add(this.tableAirplanes);
            this.tpAirplanes.Location = new System.Drawing.Point(4, 54);
            this.tpAirplanes.Margin = new System.Windows.Forms.Padding(4);
            this.tpAirplanes.Name = "tpAirplanes";
            this.tpAirplanes.Padding = new System.Windows.Forms.Padding(4);
            this.tpAirplanes.Size = new System.Drawing.Size(1479, 558);
            this.tpAirplanes.TabIndex = 3;
            // 
            // tableAirplanes
            // 
            this.tableAirplanes.ColumnCount = 3;
            this.tableAirplanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAirplanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 508F));
            this.tableAirplanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.tableAirplanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableAirplanes.Controls.Add(this.tablePlanesData, 1, 0);
            this.tableAirplanes.Controls.Add(this.tablePlanesOurAndToBuy, 2, 0);
            this.tableAirplanes.Controls.Add(this.pbAirplaneData, 0, 0);
            this.tableAirplanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAirplanes.Location = new System.Drawing.Point(4, 4);
            this.tableAirplanes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableAirplanes.Name = "tableAirplanes";
            this.tableAirplanes.RowCount = 1;
            this.tableAirplanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAirplanes.Size = new System.Drawing.Size(1471, 550);
            this.tableAirplanes.TabIndex = 0;
            // 
            // tablePlanesData
            // 
            this.tablePlanesData.ColumnCount = 1;
            this.tablePlanesData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePlanesData.Controls.Add(this.gbAirplaneData, 0, 0);
            this.tablePlanesData.Controls.Add(this.tablePlanesButton, 0, 1);
            this.tablePlanesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePlanesData.Location = new System.Drawing.Point(324, 2);
            this.tablePlanesData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePlanesData.Name = "tablePlanesData";
            this.tablePlanesData.RowCount = 2;
            this.tablePlanesData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.23849F));
            this.tablePlanesData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tablePlanesData.Size = new System.Drawing.Size(502, 546);
            this.tablePlanesData.TabIndex = 0;
            // 
            // gbAirplaneData
            // 
            this.gbAirplaneData.BackColor = System.Drawing.Color.Transparent;
            this.gbAirplaneData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbAirplaneData.Controls.Add(this.dgvAirplaneData);
            this.gbAirplaneData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAirplaneData.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAirplaneData.ForeColor = System.Drawing.Color.White;
            this.gbAirplaneData.Location = new System.Drawing.Point(4, 4);
            this.gbAirplaneData.Margin = new System.Windows.Forms.Padding(4);
            this.gbAirplaneData.Name = "gbAirplaneData";
            this.gbAirplaneData.Padding = new System.Windows.Forms.Padding(4);
            this.gbAirplaneData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbAirplaneData.Size = new System.Drawing.Size(494, 416);
            this.gbAirplaneData.TabIndex = 35;
            this.gbAirplaneData.TabStop = false;
            this.gbAirplaneData.Text = "Airplane data";
            // 
            // dgvAirplaneData
            // 
            this.dgvAirplaneData.AllowUserToAddRows = false;
            this.dgvAirplaneData.AllowUserToDeleteRows = false;
            this.dgvAirplaneData.AllowUserToResizeRows = false;
            this.dgvAirplaneData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAirplaneData.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAirplaneData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAirplaneData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirplaneData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnParametr,
            this.ClmnValue});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAirplaneData.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAirplaneData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAirplaneData.EnableHeadersVisualStyles = false;
            this.dgvAirplaneData.Location = new System.Drawing.Point(4, 29);
            this.dgvAirplaneData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAirplaneData.MultiSelect = false;
            this.dgvAirplaneData.Name = "dgvAirplaneData";
            this.dgvAirplaneData.ReadOnly = true;
            this.dgvAirplaneData.RowHeadersVisible = false;
            this.dgvAirplaneData.RowTemplate.Height = 24;
            this.dgvAirplaneData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAirplaneData.Size = new System.Drawing.Size(486, 383);
            this.dgvAirplaneData.TabIndex = 0;
            // 
            // ClmnParametr
            // 
            this.ClmnParametr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmnParametr.HeaderText = "Parametr";
            this.ClmnParametr.Name = "ClmnParametr";
            this.ClmnParametr.ReadOnly = true;
            this.ClmnParametr.Width = 150;
            // 
            // ClmnValue
            // 
            this.ClmnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmnValue.HeaderText = "Value";
            this.ClmnValue.Name = "ClmnValue";
            this.ClmnValue.ReadOnly = true;
            // 
            // tablePlanesButton
            // 
            this.tablePlanesButton.ColumnCount = 2;
            this.tablePlanesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePlanesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePlanesButton.Controls.Add(this.btRent, 0, 0);
            this.tablePlanesButton.Controls.Add(this.btLeasing, 0, 1);
            this.tablePlanesButton.Controls.Add(this.btBuy, 1, 0);
            this.tablePlanesButton.Controls.Add(this.btSell, 1, 1);
            this.tablePlanesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePlanesButton.Location = new System.Drawing.Point(3, 426);
            this.tablePlanesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePlanesButton.Name = "tablePlanesButton";
            this.tablePlanesButton.RowCount = 2;
            this.tablePlanesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePlanesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePlanesButton.Size = new System.Drawing.Size(496, 118);
            this.tablePlanesButton.TabIndex = 36;
            // 
            // btRent
            // 
            this.btRent.BackColor = System.Drawing.Color.White;
            this.btRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRent.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRent.ForeColor = System.Drawing.Color.Black;
            this.btRent.Location = new System.Drawing.Point(252, 4);
            this.btRent.Margin = new System.Windows.Forms.Padding(4);
            this.btRent.Name = "btRent";
            this.btRent.Size = new System.Drawing.Size(240, 51);
            this.btRent.TabIndex = 3;
            this.btRent.Text = "Rent";
            this.btRent.UseVisualStyleBackColor = false;
            this.btRent.Click += new System.EventHandler(this.btRent_Click);
            // 
            // btLeasing
            // 
            this.btLeasing.BackColor = System.Drawing.Color.White;
            this.btLeasing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLeasing.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeasing.ForeColor = System.Drawing.Color.Black;
            this.btLeasing.Location = new System.Drawing.Point(252, 63);
            this.btLeasing.Margin = new System.Windows.Forms.Padding(4);
            this.btLeasing.Name = "btLeasing";
            this.btLeasing.Size = new System.Drawing.Size(240, 51);
            this.btLeasing.TabIndex = 2;
            this.btLeasing.Text = "Leasing";
            this.btLeasing.UseVisualStyleBackColor = false;
            this.btLeasing.Click += new System.EventHandler(this.btLeasing_Click);
            // 
            // btBuy
            // 
            this.btBuy.BackColor = System.Drawing.Color.White;
            this.btBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBuy.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuy.ForeColor = System.Drawing.Color.Black;
            this.btBuy.Location = new System.Drawing.Point(4, 4);
            this.btBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(240, 51);
            this.btBuy.TabIndex = 1;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = false;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // btSell
            // 
            this.btSell.BackColor = System.Drawing.Color.White;
            this.btSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSell.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSell.ForeColor = System.Drawing.Color.Black;
            this.btSell.Location = new System.Drawing.Point(4, 63);
            this.btSell.Margin = new System.Windows.Forms.Padding(4);
            this.btSell.Name = "btSell";
            this.btSell.Size = new System.Drawing.Size(240, 51);
            this.btSell.TabIndex = 4;
            this.btSell.Text = "Sell";
            this.btSell.UseVisualStyleBackColor = false;
            this.btSell.Click += new System.EventHandler(this.btSell_Click);
            // 
            // tablePlanesOurAndToBuy
            // 
            this.tablePlanesOurAndToBuy.ColumnCount = 1;
            this.tablePlanesOurAndToBuy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePlanesOurAndToBuy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tablePlanesOurAndToBuy.Controls.Add(this.gbAirportPlanes, 0, 0);
            this.tablePlanesOurAndToBuy.Controls.Add(this.gbPlanesToBuy, 0, 1);
            this.tablePlanesOurAndToBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePlanesOurAndToBuy.Location = new System.Drawing.Point(3, 2);
            this.tablePlanesOurAndToBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePlanesOurAndToBuy.Name = "tablePlanesOurAndToBuy";
            this.tablePlanesOurAndToBuy.RowCount = 2;
            this.tablePlanesOurAndToBuy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePlanesOurAndToBuy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePlanesOurAndToBuy.Size = new System.Drawing.Size(315, 546);
            this.tablePlanesOurAndToBuy.TabIndex = 0;
            // 
            // gbAirportPlanes
            // 
            this.gbAirportPlanes.BackColor = System.Drawing.Color.Transparent;
            this.gbAirportPlanes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbAirportPlanes.Controls.Add(this.dgvAirplanesOfTheAirport);
            this.gbAirportPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAirportPlanes.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAirportPlanes.ForeColor = System.Drawing.Color.White;
            this.gbAirportPlanes.Location = new System.Drawing.Point(4, 4);
            this.gbAirportPlanes.Margin = new System.Windows.Forms.Padding(4);
            this.gbAirportPlanes.Name = "gbAirportPlanes";
            this.gbAirportPlanes.Padding = new System.Windows.Forms.Padding(4);
            this.gbAirportPlanes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbAirportPlanes.Size = new System.Drawing.Size(307, 265);
            this.gbAirportPlanes.TabIndex = 33;
            this.gbAirportPlanes.TabStop = false;
            this.gbAirportPlanes.Text = "Airplanes of the airport";
            // 
            // dgvAirplanesOfTheAirport
            // 
            this.dgvAirplanesOfTheAirport.AllowUserToAddRows = false;
            this.dgvAirplanesOfTheAirport.AllowUserToDeleteRows = false;
            this.dgvAirplanesOfTheAirport.AllowUserToResizeColumns = false;
            this.dgvAirplanesOfTheAirport.AllowUserToResizeRows = false;
            this.dgvAirplanesOfTheAirport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAirplanesOfTheAirport.ColumnHeadersVisible = false;
            this.dgvAirplanesOfTheAirport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnModel});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAirplanesOfTheAirport.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAirplanesOfTheAirport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAirplanesOfTheAirport.Location = new System.Drawing.Point(4, 29);
            this.dgvAirplanesOfTheAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAirplanesOfTheAirport.MultiSelect = false;
            this.dgvAirplanesOfTheAirport.Name = "dgvAirplanesOfTheAirport";
            this.dgvAirplanesOfTheAirport.ReadOnly = true;
            this.dgvAirplanesOfTheAirport.RowHeadersVisible = false;
            this.dgvAirplanesOfTheAirport.RowTemplate.Height = 24;
            this.dgvAirplanesOfTheAirport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAirplanesOfTheAirport.Size = new System.Drawing.Size(299, 232);
            this.dgvAirplanesOfTheAirport.TabIndex = 0;
            this.dgvAirplanesOfTheAirport.SelectionChanged += new System.EventHandler(this.dgvAirplanesOfTheAirport_SelectionChanged);
            this.dgvAirplanesOfTheAirport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvAirplanesOfTheAirport_MouseDown);
            // 
            // ClmnModel
            // 
            this.ClmnModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmnModel.HeaderText = "Model";
            this.ClmnModel.Name = "ClmnModel";
            this.ClmnModel.ReadOnly = true;
            // 
            // gbPlanesToBuy
            // 
            this.gbPlanesToBuy.BackColor = System.Drawing.Color.Transparent;
            this.gbPlanesToBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbPlanesToBuy.Controls.Add(this.dgvAirplanesToBuy);
            this.gbPlanesToBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPlanesToBuy.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPlanesToBuy.ForeColor = System.Drawing.Color.White;
            this.gbPlanesToBuy.Location = new System.Drawing.Point(4, 277);
            this.gbPlanesToBuy.Margin = new System.Windows.Forms.Padding(4);
            this.gbPlanesToBuy.Name = "gbPlanesToBuy";
            this.gbPlanesToBuy.Padding = new System.Windows.Forms.Padding(4);
            this.gbPlanesToBuy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbPlanesToBuy.Size = new System.Drawing.Size(307, 265);
            this.gbPlanesToBuy.TabIndex = 34;
            this.gbPlanesToBuy.TabStop = false;
            this.gbPlanesToBuy.Text = "Airplanes to buy";
            // 
            // dgvAirplanesToBuy
            // 
            this.dgvAirplanesToBuy.AllowUserToAddRows = false;
            this.dgvAirplanesToBuy.AllowUserToDeleteRows = false;
            this.dgvAirplanesToBuy.AllowUserToResizeColumns = false;
            this.dgvAirplanesToBuy.AllowUserToResizeRows = false;
            this.dgvAirplanesToBuy.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAirplanesToBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirplanesToBuy.ColumnHeadersVisible = false;
            this.dgvAirplanesToBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAirplanesToBuy.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAirplanesToBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAirplanesToBuy.Location = new System.Drawing.Point(4, 29);
            this.dgvAirplanesToBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAirplanesToBuy.MultiSelect = false;
            this.dgvAirplanesToBuy.Name = "dgvAirplanesToBuy";
            this.dgvAirplanesToBuy.ReadOnly = true;
            this.dgvAirplanesToBuy.RowHeadersVisible = false;
            this.dgvAirplanesToBuy.RowTemplate.Height = 24;
            this.dgvAirplanesToBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAirplanesToBuy.Size = new System.Drawing.Size(299, 232);
            this.dgvAirplanesToBuy.TabIndex = 34;
            this.dgvAirplanesToBuy.SelectionChanged += new System.EventHandler(this.dgvAirplanesToBuy_SelectionChanged);
            this.dgvAirplanesToBuy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvAirplanesToBuy_MouseDown);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Model";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // pbAirplaneData
            // 
            this.pbAirplaneData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAirplaneData.Location = new System.Drawing.Point(832, 2);
            this.pbAirplaneData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAirplaneData.Name = "pbAirplaneData";
            this.pbAirplaneData.Size = new System.Drawing.Size(636, 546);
            this.pbAirplaneData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAirplaneData.TabIndex = 0;
            this.pbAirplaneData.TabStop = false;
            // 
            // tpMap
            // 
            this.tpMap.BackColor = System.Drawing.Color.Transparent;
            this.tpMap.Controls.Add(this.pbMap);
            this.tpMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpMap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tpMap.Location = new System.Drawing.Point(4, 54);
            this.tpMap.Margin = new System.Windows.Forms.Padding(4);
            this.tpMap.Name = "tpMap";
            this.tpMap.Padding = new System.Windows.Forms.Padding(4);
            this.tpMap.Size = new System.Drawing.Size(1479, 558);
            this.tpMap.TabIndex = 1;
            // 
            // pbMap
            // 
            this.pbMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMap.Image = ((System.Drawing.Image)(resources.GetObject("pbMap.Image")));
            this.pbMap.Location = new System.Drawing.Point(4, 4);
            this.pbMap.Margin = new System.Windows.Forms.Padding(4);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(1471, 550);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1479, 558);
            this.tabPage3.TabIndex = 2;
            // 
            // tbFuelPrice
            // 
            this.tbFuelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFuelPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFuelPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbFuelPrice.Location = new System.Drawing.Point(344, 4);
            this.tbFuelPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbFuelPrice.Name = "tbFuelPrice";
            this.tbFuelPrice.ReadOnly = true;
            this.tbFuelPrice.Size = new System.Drawing.Size(108, 32);
            this.tbFuelPrice.TabIndex = 28;
            // 
            // lblFuelPrice
            // 
            this.lblFuelPrice.AutoSize = true;
            this.lblFuelPrice.BackColor = System.Drawing.Color.White;
            this.lblFuelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFuelPrice.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFuelPrice.ForeColor = System.Drawing.Color.Black;
            this.lblFuelPrice.Location = new System.Drawing.Point(213, 6);
            this.lblFuelPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.lblFuelPrice.Name = "lblFuelPrice";
            this.lblFuelPrice.Size = new System.Drawing.Size(123, 31);
            this.lblFuelPrice.TabIndex = 27;
            this.lblFuelPrice.Text = "Fuel price:";
            // 
            // gbDateAndTime
            // 
            this.gbDateAndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDateAndTime.BackColor = System.Drawing.Color.Transparent;
            this.gbDateAndTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDateAndTime.Controls.Add(this.tableDateAndTime);
            this.gbDateAndTime.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbDateAndTime.ForeColor = System.Drawing.Color.White;
            this.gbDateAndTime.Location = new System.Drawing.Point(792, 4);
            this.gbDateAndTime.Margin = new System.Windows.Forms.Padding(4);
            this.gbDateAndTime.Name = "gbDateAndTime";
            this.gbDateAndTime.Padding = new System.Windows.Forms.Padding(4);
            this.gbDateAndTime.Size = new System.Drawing.Size(464, 76);
            this.gbDateAndTime.TabIndex = 29;
            this.gbDateAndTime.TabStop = false;
            this.gbDateAndTime.Text = "Date and Time";
            // 
            // tableDateAndTime
            // 
            this.tableDateAndTime.ColumnCount = 4;
            this.tableDateAndTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDateAndTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableDateAndTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableDateAndTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableDateAndTime.Controls.Add(this.btSpeedUp, 2, 0);
            this.tableDateAndTime.Controls.Add(this.btSpeedDown, 1, 0);
            this.tableDateAndTime.Controls.Add(this.lblTime, 0, 0);
            this.tableDateAndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDateAndTime.Location = new System.Drawing.Point(4, 29);
            this.tableDateAndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableDateAndTime.Name = "tableDateAndTime";
            this.tableDateAndTime.RowCount = 1;
            this.tableDateAndTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDateAndTime.Size = new System.Drawing.Size(456, 43);
            this.tableDateAndTime.TabIndex = 23;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(4, 0);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 32);
            this.lblTime.TabIndex = 12;
            // 
            // gbBalance
            // 
            this.gbBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBalance.BackColor = System.Drawing.Color.Transparent;
            this.gbBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbBalance.Controls.Add(this.tbBalance);
            this.gbBalance.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbBalance.ForeColor = System.Drawing.Color.White;
            this.gbBalance.Location = new System.Drawing.Point(1264, 4);
            this.gbBalance.Margin = new System.Windows.Forms.Padding(4);
            this.gbBalance.Name = "gbBalance";
            this.gbBalance.Padding = new System.Windows.Forms.Padding(4);
            this.gbBalance.Size = new System.Drawing.Size(212, 76);
            this.gbBalance.TabIndex = 30;
            this.gbBalance.TabStop = false;
            this.gbBalance.Text = "Balance";
            // 
            // gbFuel
            // 
            this.gbFuel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFuel.BackColor = System.Drawing.Color.Transparent;
            this.gbFuel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbFuel.Controls.Add(this.tableFuel);
            this.gbFuel.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFuel.ForeColor = System.Drawing.Color.White;
            this.gbFuel.Location = new System.Drawing.Point(792, 88);
            this.gbFuel.Margin = new System.Windows.Forms.Padding(4);
            this.gbFuel.Name = "gbFuel";
            this.gbFuel.Padding = new System.Windows.Forms.Padding(4);
            this.gbFuel.Size = new System.Drawing.Size(464, 75);
            this.gbFuel.TabIndex = 31;
            this.gbFuel.TabStop = false;
            this.gbFuel.Text = "Fuel";
            // 
            // tableFuel
            // 
            this.tableFuel.ColumnCount = 4;
            this.tableFuel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.45038F));
            this.tableFuel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.541985F));
            this.tableFuel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.62595F));
            this.tableFuel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFuel.Controls.Add(this.tbFuel, 0, 0);
            this.tableFuel.Controls.Add(this.tbFuelPrice, 3, 0);
            this.tableFuel.Controls.Add(this.lblL, 1, 0);
            this.tableFuel.Controls.Add(this.lblFuelPrice, 2, 0);
            this.tableFuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFuel.Location = new System.Drawing.Point(4, 29);
            this.tableFuel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableFuel.Name = "tableFuel";
            this.tableFuel.RowCount = 1;
            this.tableFuel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFuel.Size = new System.Drawing.Size(456, 42);
            this.tableFuel.TabIndex = 33;
            // 
            // tbFuel
            // 
            this.tbFuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFuel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFuel.Location = new System.Drawing.Point(4, 4);
            this.tbFuel.Margin = new System.Windows.Forms.Padding(4);
            this.tbFuel.Name = "tbFuel";
            this.tbFuel.ReadOnly = true;
            this.tbFuel.Size = new System.Drawing.Size(158, 32);
            this.tbFuel.TabIndex = 19;
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.BackColor = System.Drawing.Color.White;
            this.lblL.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblL.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblL.ForeColor = System.Drawing.Color.Black;
            this.lblL.Location = new System.Drawing.Point(170, 6);
            this.lblL.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(35, 31);
            this.lblL.TabIndex = 32;
            this.lblL.Text = "L.";
            this.lblL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableAllPane
            // 
            this.tableAllPane.BackColor = System.Drawing.Color.Transparent;
            this.tableAllPane.ColumnCount = 1;
            this.tableAllPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllPane.Controls.Add(this.tabControl, 0, 1);
            this.tableAllPane.Controls.Add(this.tableHead, 0, 0);
            this.tableAllPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAllPane.Location = new System.Drawing.Point(0, 0);
            this.tableAllPane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableAllPane.Name = "tableAllPane";
            this.tableAllPane.RowCount = 2;
            this.tableAllPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAllPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllPane.Size = new System.Drawing.Size(1495, 795);
            this.tableAllPane.TabIndex = 33;
            // 
            // tableHead
            // 
            this.tableHead.ColumnCount = 5;
            this.tableHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 472F));
            this.tableHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableHead.Controls.Add(this.gbBalance, 3, 0);
            this.tableHead.Controls.Add(this.gbDateAndTime, 2, 0);
            this.tableHead.Controls.Add(this.gbFuel, 2, 1);
            this.tableHead.Controls.Add(this.groupBox1, 3, 1);
            this.tableHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableHead.Location = new System.Drawing.Point(3, 2);
            this.tableHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableHead.Name = "tableHead";
            this.tableHead.RowCount = 2;
            this.tableHead.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableHead.Size = new System.Drawing.Size(1489, 167);
            this.tableHead.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(1263, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buy fuel";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel2.Controls.Add(this.btFuelBuy, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbFuelBuyCount, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(208, 46);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btFuelBuy
            // 
            this.btFuelBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFuelBuy.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFuelBuy.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btFuelBuy.Location = new System.Drawing.Point(123, 4);
            this.btFuelBuy.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.btFuelBuy.Name = "btFuelBuy";
            this.btFuelBuy.Size = new System.Drawing.Size(83, 28);
            this.btFuelBuy.TabIndex = 0;
            this.btFuelBuy.Text = "Buy fuel";
            this.btFuelBuy.UseVisualStyleBackColor = true;
            this.btFuelBuy.Click += new System.EventHandler(this.btFuelBuy_Click);
            // 
            // tbFuelBuyCount
            // 
            this.tbFuelBuyCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFuelBuyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFuelBuyCount.Location = new System.Drawing.Point(2, 4);
            this.tbFuelBuyCount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.tbFuelBuyCount.Name = "tbFuelBuyCount";
            this.tbFuelBuyCount.Size = new System.Drawing.Size(117, 36);
            this.tbFuelBuyCount.TabIndex = 1;
            // 
            // pbAirplane
            // 
            this.pbAirplane.BackColor = System.Drawing.Color.Transparent;
            this.pbAirplane.Image = ((System.Drawing.Image)(resources.GetObject("pbAirplane.Image")));
            this.pbAirplane.Location = new System.Drawing.Point(1, 0);
            this.pbAirplane.Margin = new System.Windows.Forms.Padding(4);
            this.pbAirplane.Name = "pbAirplane";
            this.pbAirplane.Size = new System.Drawing.Size(224, 133);
            this.pbAirplane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAirplane.TabIndex = 23;
            this.pbAirplane.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1495, 795);
            this.Controls.Add(this.lblSimulator);
            this.Controls.Add(this.pbAirplane);
            this.Controls.Add(this.lblAirport);
            this.Controls.Add(this.tableAllPane);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.tabControl.ResumeLayout(false);
            this.tpSheduleAndFlights.ResumeLayout(false);
            this.tableSheduleAndFlights.ResumeLayout(false);
            this.gbFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.gbShedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShedule)).EndInit();
            this.tpAirplanes.ResumeLayout(false);
            this.tableAirplanes.ResumeLayout(false);
            this.tablePlanesData.ResumeLayout(false);
            this.gbAirplaneData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirplaneData)).EndInit();
            this.tablePlanesButton.ResumeLayout(false);
            this.tablePlanesOurAndToBuy.ResumeLayout(false);
            this.gbAirportPlanes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirplanesOfTheAirport)).EndInit();
            this.gbPlanesToBuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirplanesToBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAirplaneData)).EndInit();
            this.tpMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.gbDateAndTime.ResumeLayout(false);
            this.tableDateAndTime.ResumeLayout(false);
            this.tableDateAndTime.PerformLayout();
            this.gbBalance.ResumeLayout(false);
            this.gbBalance.PerformLayout();
            this.gbFuel.ResumeLayout(false);
            this.tableFuel.ResumeLayout(false);
            this.tableFuel.PerformLayout();
            this.tableAllPane.ResumeLayout(false);
            this.tableHead.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAirplane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btSpeedUp;
        private System.Windows.Forms.Button btSpeedDown;
        private System.Windows.Forms.Label lblAirport;
        private System.Windows.Forms.Label lblSimulator;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.PictureBox pbAirplane;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpSheduleAndFlights;
        private System.Windows.Forms.TabPage tpMap;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbFuelPrice;
        private System.Windows.Forms.Label lblFuelPrice;
        private System.Windows.Forms.GroupBox gbDateAndTime;
        private System.Windows.Forms.GroupBox gbBalance;
        private System.Windows.Forms.GroupBox gbFuel;
        private System.Windows.Forms.TextBox tbFuel;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.GroupBox gbShedule;
        private System.Windows.Forms.TabPage tpAirplanes;
        private System.Windows.Forms.GroupBox gbFlights;
        private System.Windows.Forms.GroupBox gbAirplaneData;
        private System.Windows.Forms.Button btSell;
        private System.Windows.Forms.Button btRent;
        private System.Windows.Forms.Button btLeasing;
        private System.Windows.Forms.Button btBuy;
        private TableLayoutPanel tableSheduleAndFlights;
        private TableLayoutPanel tableAllPane;
        private TableLayoutPanel tableHead;
        private TableLayoutPanel tableAirplanes;
        private TableLayoutPanel tablePlanesButton;
        private TableLayoutPanel tablePlanesData;
        private PictureBox pbAirplaneData;
        private TableLayoutPanel tableDateAndTime;
        private TableLayoutPanel tableFuel;
        private TableLayoutPanel tablePlanesOurAndToBuy;
        private GroupBox gbAirportPlanes;
        private GroupBox gbPlanesToBuy;
        private DataGridView dgvFlights;
        private DataGridView dgvShedule;
        private DataGridView dgvAirplaneData;
        private DataGridViewTextBoxColumn ClmnParametr;
        private DataGridViewTextBoxColumn ClmnValue;
        private DataGridView dgvAirplanesOfTheAirport;
        private DataGridViewTextBoxColumn ClmnModel;
        private DataGridView dgvAirplanesToBuy;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label lblTime;
        private Button btFuelBuy;
        private TextBox tbFuelBuyCount;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn ClmnNumber;
        private DataGridViewTextBoxColumn ClmnDateDepartureFlight;
        private DataGridViewTextBoxColumn ClmnDateArrivalFlight;
        private DataGridViewTextBoxColumn ClmnFrom;
        private DataGridViewTextBoxColumn ClmnTo;
        private DataGridViewTextBoxColumn ClmnType;
        private DataGridViewTextBoxColumn ClmnRegularity;
        private DataGridViewTextBoxColumn ClmnDistance;
        private DataGridViewTextBoxColumn ClmnProfit;
        private DataGridViewTextBoxColumn ClmnForfeit;
        private DataGridViewTextBoxColumn ClmnCarrying;
        private DataGridViewTextBoxColumn ClmnPeopleCapacity;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ClmnDateDeparture;
        private DataGridViewTextBoxColumn ClmnDateArrival;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn ClmnAirplane;
    }
}

