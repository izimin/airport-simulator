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
    public partial class Leasing : Form
    {
        public string tenancy = "";

        public Leasing(double priceL, double priceAll, DateTime dt)
        {
            InitializeComponent();
            tenancy = "";
            lbPriceLeasing.Text = priceL.ToString();
            lbDate.Text = Math.Ceiling(priceAll / priceL).ToString() + " месяцев";
            tenancy = dt.AddMonths((int) Math.Ceiling(priceAll / priceL)).ToShortDateString();
        }
    }
}
