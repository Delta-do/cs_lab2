using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cs_lab2
{
    struct Car
    {
        public int num;
        public string model;
        public string owner;
    }
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.Text = "2 Задание";
        }

        private void textBoxnum_TextChanged(object sender, EventArgs e)
        {
            int v;
            if (int.TryParse(textBoxnum.Text, out v))
                label_err.Visible = false;
            else
                label_err.Visible = true;
        }

        private void textBoxmodel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxowner_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Car car = new Car();
            if (int.TryParse(textBoxnum.Text, out car.num))
                label_err.Visible = false;
            else
            {
                car.num = 0;
                label_err.Visible = true;
            }
            car.model = textBoxmodel.Text;
            car.owner = textBoxowner.Text;
            MessageBox.Show($"Номер машины: {car.num}\nМодель машины: {car.model}\nВладелец машины: {car.owner}");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
