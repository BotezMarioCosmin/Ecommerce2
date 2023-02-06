using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Electronic el = new Electronic("id0","telefono","samsung","bello",959,"s23");
            textBox1.Text = el.DayOfTheWeek + " " + el.Price + " " + el.DiscountedPrice;
            Food f = new Food("id1", "mela", "melinda", "mela rossa", 1, new DateTime(2023, 2, 1));
            textBox2.Text = f.ToString();
        }
    }
}
