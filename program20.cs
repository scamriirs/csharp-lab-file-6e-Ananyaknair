creat a application form using windowforms

namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string phone = textBox2.Text;
            string Course = textBox3.Text;
            string gender = radioButton1.Checked ? "Male" : radioButton2.Checked ? "Female" : "Not Selected";

            MessageBox.Show($"Name: {name}\nPhone: {phone}\nCourse: {Course}\nGender : {gender}", "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
