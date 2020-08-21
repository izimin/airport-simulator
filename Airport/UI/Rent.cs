using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport.UI
{
    public partial class Rent : Form
    {
        public string tenancy = "";

        public Rent(int lbPrice)
        {
            InitializeComponent();
            tenancy = "";
            lbPriceRent.Text = lbPrice.ToString();
            
        }
        
        private void mtCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

            tenancy = e.Start.ToShortDateString();
        }
        
    }
}
