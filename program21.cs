create a bill calculator using windowsform


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Order
{
    public partial class Form1 : Form
    {
        public String select = "You have Selected";
        public int total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                select = select + "\n Pizza";
                total = total + 100;
            }
            if (checkBox2.Checked == true)
            {
                select = select + "\n Buurger";
                total = total + 50;
            }
            if (checkBox3.Checked == true)
            {
                select = select + "\n Coffee";
                total = total + 25;
            }
            if (checkBox4.Checked == true)
            {
                select = select + "\n Coke";
                total = total + 30;
            }

            if (select == "You have Selected")
            {
                MessageBox.Show("You have Selected Nothing");
            }
            else
            {
                MessageBox.Show(select + "\nTotal: " + total);
            }
        }

        
    }
