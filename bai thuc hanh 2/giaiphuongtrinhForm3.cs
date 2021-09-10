using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bai_thuc_hanh_2
{
    public partial class giaiphuongtrinhForm3 : Form
    {
        public giaiphuongtrinhForm3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void giaiphuongtrinhForm3_Load(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string so1 = txb1.Text;
            string so2 = txb2.Text;
            string so3 = txb3.Text;
            double sohang1 = double.Parse(so1);
            double sohang2 = double.Parse(so2);
            double sohang3 = double.Parse(so3);
            double x1;
            double x2;

            

                   if (sohang1 == 0 )
                     {
                         x1 = -sohang3 / sohang2;
                         label5.Text = "co 1 nghiem duy nhat" + x1.ToString();

                     }else
                         {
                         double delta = sohang2 * sohang2 - 4 * sohang1 * sohang3;
                         if (delta < 0) label5.Text = "phuong trinh vo nghiem";
                         else if (delta == 0)
                         {
                             x1 = -sohang2 / (2 * sohang1);
                             label5.Text = "co nghiem kep x1= x2= " + x1.ToString();
                         }
                         else {
                             delta = Math.Sqrt(delta);
                             x1 = (-sohang2 + delta) / (2 * sohang1);
                             x2 = (-sohang2 - delta) / (2 * sohang1);
                             label5.Text = "co 2 nghiem  x1= " + x1.ToString();
                             label5.Text = "  x2= " + x1.ToString();
                         }
                         } 
        }
    }
}
