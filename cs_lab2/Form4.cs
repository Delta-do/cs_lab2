using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_lab2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Text = "1.4 Задание";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            string d = "", v = "";
            switch (x)
            {
                case 1:
                    d = "Понедельник";
                    v = "Рабочий";
                    break;
                case 2:
                    d = "Вторник";
                    v = "Рабочий";
                    break;
                case 3:
                    d = "Среда";
                    v = "Рабочий";
                    break;
                case 4:
                    d = "Четверг";
                    v = "Рабочий";
                    break;
                case 5:
                    d = "Пятница";
                    v = "Рабочий";
                    break;
                case 6:
                    d = "Суббота";
                    v = "Выходной";
                    break;
                case 7:
                    d = "Воскресенье";
                    v = "Выходной";
                    break;
            }
            label_d.Text = d;
            label_v.Text = v;
            label_d.Visible = true;
            label_v.Visible = true;
        }
    }
}
