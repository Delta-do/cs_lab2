using static System.Net.Mime.MediaTypeNames;

namespace cs_lab2
{
    public partial class Form1 : Form
    { 


        public Form1()
        {
            InitializeComponent();
            this.Text = "1.1 задание";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0, y = 0, z = 0;
            x = Convert.ToDouble(textBoxX.Text);
            y = Convert.ToDouble(textBoxY.Text);
            z = Convert.ToDouble(textBoxZ.Text);
            double a = (2 * Math.Pow(Math.Cos(x - Math.PI / 6), 4)) / (0.5 + Math.Pow(Math.Sin(y), 2));
            double b = 1 + Math.Pow(z, 2) / (3 + Math.Pow(z, 2) / 5);
            label5.Text = "a = " + Convert.ToString(a) + "\nb = " + Convert.ToString(b);
            label5.Visible = true;
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            double v;
            if (double.TryParse(textBoxX.Text, out v))
            {
                label4.Visible = false;
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            double v;
            if (double.TryParse(textBoxY.Text, out v))
            {
                label4.Visible = false;
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void textBoxZ_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            double v;
            if (double.TryParse(textBoxZ.Text, out v))
            {
                label4.Visible = false;
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}