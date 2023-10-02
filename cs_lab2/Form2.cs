using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cs_lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "1.2 Задание";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] c = new double[6];
            if (double.TryParse(textBoxx1.Text, out c[0]) && double.TryParse(textBoxy1.Text, out c[1]) &&
                double.TryParse(textBoxx2.Text, out c[2]) && double.TryParse(textBoxy2.Text, out c[3]) &&
                double.TryParse(textBoxx3.Text, out c[4]) && double.TryParse(textBoxy3.Text, out c[5]))
            {
                double[] tri = new double[3];
                tri[0] = Math.Sqrt(Math.Pow((c[3] - c[0]), 2) + Math.Pow((c[3] - c[1]), 2));
                tri[1] = Math.Sqrt(Math.Pow((c[4] - c[2]), 2) + Math.Pow((c[5] - c[3]), 2));
                tri[2] = Math.Sqrt(Math.Pow((c[0] - c[4]), 2) + Math.Pow((c[1] - c[5]), 2));
                double P = tri[0] + tri[1] + tri[2];
                double p = P / 2;
                double S = Math.Sqrt(p * (p - tri[0]) * (p - tri[1]) * (p - tri[2]));
                label_res.Visible = true;
                label_res.Text = "P = " + Convert.ToString(P) + "\nS = " + Convert.ToString(S);
            }
            else
                label_res.Visible = false;
        }

        private void textBoxx1_TextChanged(object sender, EventArgs e)
        {
            label_res.Visible = false;
            double v;
            if (double.TryParse(textBoxx1.Text, out v))
                label_err.Visible = false;
            else
                label_err.Visible = true;
        }

        private void textBoxy1_TextChanged(object sender, EventArgs e)
        {
            label_res.Visible = false;
            double v;
            if (double.TryParse(textBoxy1.Text, out v))
                label_err.Visible = false;
            else
                label_err.Visible = true;
        }

        private void textBoxx2_TextChanged(object sender, EventArgs e)
        {
            label_res.Visible = false;
            double v;
            if (double.TryParse(textBoxx2.Text, out v))
                label_err.Visible = false;
            else
                label_err.Visible = true;
        }

        private void textBoxy2_TextChanged(object sender, EventArgs e)
        {
            label_res.Visible = false;
            double v;
            if (double.TryParse(textBoxy2.Text, out v))
                label_err.Visible = false;
            else
                label_err.Visible = true;
        }

        private void textBoxx3_TextChanged(object sender, EventArgs e)
        {
            label_res.Visible = false;
            double v;
            if (double.TryParse(textBoxx3.Text, out v))
                label_err.Visible = false;
            else
                label_err.Visible = true;
        }

        private void textBoxy3_TextChanged(object sender, EventArgs e)
        {
            label_res.Visible = false;
            double v;
            if (double.TryParse(textBoxy3.Text, out v))
                label_err.Visible = false;
            else
                label_err.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }
    }
}
