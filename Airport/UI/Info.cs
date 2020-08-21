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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            lblMessage.Text = "Данный самолет находится в другом городе!\n Перегнать?";
        }
    }
}
