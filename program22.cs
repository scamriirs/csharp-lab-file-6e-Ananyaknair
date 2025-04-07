create the usage of listbox

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string result = string.Join(",", listBox1.SelectedItems.Cast<string>());
                MessageBox.Show("Selected: " + result);
            }
            else
            {
                MessageBox.Show("No item selected");
            }


        }
    }
}
