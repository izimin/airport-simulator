using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport.src.Entity;

namespace Airport.UI
{
    public partial class ChoiceAirplaneForm : Form
    {
        public ChoiceAirplaneForm(List<Airplane> airplanes)
        {
            InitializeComponent();
            dgvAirplanes.Rows.Clear();
            foreach (var airplane in airplanes)
            {
                dgvAirplanes.Rows.Add();
                var row = dgvAirplanes.Rows[dgvAirplanes.Rows.Count - 1];
                row.Cells[0].Value = airplane.Model;
                row.Cells[1].Value = airplane.Carrying;
                row.Cells[2].Value = airplane.PassengerСapacity;
                row.Cells[3].Value = airplane.FuelConsumption;
                row.Cells[4].Value = airplane.Speed;
                row.Cells[5].Value = airplane.RangeFlight;
            }
        }

        private void btAssign_Click(object sender, EventArgs e)
        {
            MainForm.AirplaneForShedule = dgvAirplanes.SelectedRows[0].Index;
        }

        private void dgvAirplanes_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void dgvAirplanes_SelectionChanged(object sender, EventArgs e)
        {
            btAssign.Enabled = dgvAirplanes.SelectedRows.Count != 0;
        }
    }
}
