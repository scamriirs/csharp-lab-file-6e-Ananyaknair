create a BMI calculator


namespace WinFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Weight = Convert.ToDouble(textBox1.Text);
            double Height = Convert.ToDouble(textBox2.Text);
            double bmi = Weight / (Height * Height);

            textBox3.Text = bmi.ToString();
            if (bmi > 1.5)
            {
                textBox3.Text = "Underweight";
            }
            else if (bmi < 1.5)
            {
                textBox3.Text = "normalWeight";
            }
            else if (bmi < 30)
            {
                textBox3.Text = "overweight";
            }
            else
            {
                textBox3.Text = "obese";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
