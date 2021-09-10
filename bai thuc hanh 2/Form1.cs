using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_thuc_hanh_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strTG = "";
            if (radioButton1.Checked == true)
                strTG += radioButton1.Text;
            if (radioButton2.Checked == true)
                strTG += radioButton2.Text;
            label1.Text = "gioi tinh la: " + strTG;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = "ban chon khoi: ";
            if (checkBox1.Checked == true) str += checkBox1.Text + "; ";
            if (checkBox2.Checked == true) str += checkBox2.Text + "; ";
            if (checkBox3.Checked == true) str += checkBox3.Text + "; ";
            if (checkBox4.Checked == true) str += checkBox4.Text + "; ";
            if (checkBox5.Checked == true) str += checkBox5.Text + ".";
            if (str == "ban chon khoi: ") str = "chua chon khoi";
            else label2.Text = str;
        }
    }
}
