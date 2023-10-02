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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBoxnum_TextChanged(object sender, EventArgs e)
        {
            label_res.Visible = false;
            double v;
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
    }
}
