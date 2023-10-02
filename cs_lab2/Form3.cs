using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cs_lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "1.3 Задание";
        }

        private void textBoxz1_TextChanged(object sender, EventArgs e)
        {
            label_res.Visible = false;
            double v;
            if (double.TryParse(textBoxz1.Text, out v))
                label_err.Visible = false;
            else
                label_err.Visible = true;
        }

       

        private void textBoxz2_TextChanged(object sender, EventArgs e)
        {
            label_res.Visible = false;
            double v;
            if (double.TryParse(textBoxz2.Text, out v))
                label_err.Visible = false;
            else
                label_err.Visible = true;
        }

        private void textBoxz3_TextChanged(object sender, EventArgs e)
        {
            label_res.Visible = false;
            double v;
            if (double.TryParse(textBoxz3.Text, out v))
                label_err.Visible = false;
            else
                label_err.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double z1, z2, z3;
            if (double.TryParse(textBoxz1.Text, out z1) && double.TryParse(textBoxz2.Text, out z2) && double.TryParse(textBoxz3.Text, out z3))
            {
                double[] arr = new double[3];
                arr[0] = Math.Max(Math.Max(z1, z2), z3);
                arr[2] = Math.Min(Math.Min(z1, z2), z3);
                arr[1] = z1 + z2 + z3 - arr[0] - arr[2];
                label_res.Visible = true;
                label_res.Text = (String.Join(" ", arr));
            }
            else
                label_err.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
