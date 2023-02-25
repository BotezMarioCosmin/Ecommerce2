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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ecommerce2
{
    public partial class Form1 : Form
    {
        Cart c = new Cart("cart_01");
        DateTime today = DateTime.Now;
        string[] productTypes = new string[] { "Electronic", "Food", "Sheet", "Pen"};
        public Form1()
        {
            InitializeComponent();
            comboBoxProductTypes.Items.Add(productTypes[0]);
            comboBoxProductTypes.Items.Add(productTypes[1]);
            comboBoxProductTypes.Items.Add(productTypes[2]);
            comboBoxProductTypes.Items.Add(productTypes[3]);
            panelCreateProduct.Location = new Point(12, 6);
            panelAdditional.Location = new Point(12, 6);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelCreateProduct.Hide();
            panelAdditional.Hide();
            textBoxAdditional2.Hide();
            Electronic el = new Electronic("id0","telefono","samsung","bello",959,"s23");
            Food f = new Food("id1", "mela", "melinda", "mela rossa", 4, new DateTime(2023, 2, 14));
            Sheets s = new Sheets("sheet1","foglio","fogli","foglio",1,1);
            Cart cart = new Cart("Cart-01");
            labelToday.Text = "Today: " + today.ToString("dd/MM/yyyy");
            cart.Add(el);
            cart.Add(f);
            cart.Add(s);
            AddToListView(el);
        }

        public void AddToListView(Product p)
        {
            //listView1.Columns.Add(p.ToString());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            comboBoxProductTypes.Text = null;
            textBoxCreateId.Text = null;
            textBoxCreateManufacturer.Text = null;
            textBoxCreateName.Text = null;
            textBoxCreatePrice.Text = null;
            richTextBox1.Text = null;
            panelCreateProduct.Show();
        }

        private void buttonCreateBack_Click(object sender, EventArgs e)
        {
            panelCreateProduct.Hide();
        }

        private void buttonCreateNext_Click(object sender, EventArgs e)
        {
            if (comboBoxProductTypes.SelectedIndex >= 0 && comboBoxProductTypes.SelectedIndex <= 3
                && textBoxCreateId.Text != null && textBoxCreateManufacturer.Text != null &&
                textBoxCreateName.Text != null && textBoxCreatePrice.Text != null)
            {
                panelCreateProduct.Hide();
                if (comboBoxProductTypes.SelectedIndex == 0) //electronic
                {
                    this.textBoxAdditional.GotFocus += new EventHandler(textBox1_Focus);
                    this.textBoxAdditional.Text = "Model";
                }
                else if (comboBoxProductTypes.SelectedIndex == 1) // food
                {
                    this.textBoxAdditional.GotFocus += new EventHandler(textBox1_Focus);
                    this.textBoxAdditional.Text = "Ingredients";
                    textBoxAdditional2.Show();
                    this.textBoxAdditional2.GotFocus += new EventHandler(textBox1_Focus);
                    this.textBoxAdditional2.Text = "Expiration date";
                }
                else if (comboBoxProductTypes.SelectedIndex == 2) // sheets
                {
                    this.textBoxAdditional.GotFocus += new EventHandler(textBox1_Focus);
                    this.textBoxAdditional.Text = "Weight";
                }
                else if (comboBoxProductTypes.SelectedIndex == 3) // pens
                {
                    this.textBoxAdditional.GotFocus += new EventHandler(textBox1_Focus);
                    this.textBoxAdditional.Text = "Type";
                }
                textBoxAdditional2.Hide();
                panelAdditional.Show();
            }
            else
                MessageBox.Show("Fill all the fields!");
        }

        protected void textBox1_Focus(Object sender, EventArgs e)
        {
            textBoxAdditional.Text = "";
            textBoxAdditional2.Text = "";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxProductTypes.SelectedIndex == 0) //electronic
            {
                Electronic el = new Electronic(textBoxCreateId.Text, textBoxCreateName.Text, textBoxCreateManufacturer.Text, richTextBox1.Text, int.Parse(textBoxCreatePrice.Text), textBoxAdditional.Text);            
            }
            else if (comboBoxProductTypes.SelectedIndex == 1) // food
            {
                string[] arraytmp = new string[1];
                arraytmp[0] = textBoxAdditional.Text;
                Food fo = new Food(textBoxCreateId.Text, textBoxCreateName.Text, textBoxCreateManufacturer.Text, richTextBox1.Text, int.Parse(textBoxCreatePrice.Text), arraytmp, Convert.ToDateTime(textBoxAdditional2.Text));
            }
            else if (comboBoxProductTypes.SelectedIndex == 2) // sheets
            {
                Sheets se = new Sheets(textBoxCreateId.Text, textBoxCreateName.Text, textBoxCreateManufacturer.Text, richTextBox1.Text, int.Parse(textBoxCreatePrice.Text), float.Parse(textBoxAdditional.Text));
            }
            else if (comboBoxProductTypes.SelectedIndex == 3) // pens
            {
                Pens pe = new Pens(textBoxCreateId.Text, textBoxCreateName.Text, textBoxCreateManufacturer.Text, richTextBox1.Text, int.Parse(textBoxCreatePrice.Text), textBoxAdditional.Text);
            }
            panelAdditional.Hide();
        }
    }
}
