using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bai_thuc_hanh_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cboTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cboTruong.Items.Add("truong DH KTQD");
            cboTruong.Items.Add("truong DH Ngoai Thuong");
            cboTruong.Items.Add("truong DH Bach Khoa");
            cboTruong.Items.Add("truong DH Xay dung");
            cboTruong.Items.Add("truong DH Quoc Gia");

            for (int i = 0; i < 31; i++)
            {
                comboBox1.Items.Add(i + 1);
                comboBox1.SelectedIndex = 0;
            }
            for (int i = 0; i < 12; i++)
            {
                comboBox2.Items.Add(i + 1);
                comboBox2.SelectedIndex = 0;
            }
            for (int i = 2013; i < 2017; i++)
            {
                comboBox3.Items.Add(i);
                comboBox3.SelectedIndex = 0;
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(lst1.SelectedItems.Count > 0)
            {
                lst2.Items.Add(lst1.SelectedItem);
                lst1.Items.Remove(lst1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lst1.Items.Count; i++)
            {
                lst2.Items.Add(lst2.Items[i]);
            }
            for (int i = 0; i < lst1.Items.Count; i++)
            {
                lst1.Items.Remove(lst1.Items[i]);
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lst2.SelectedItems.Count > 0)
            {
                lst1.Items.Add(lst2.SelectedItem);
                lst2.Items.Remove(lst2.SelectedItem);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst2.Items.Count; i++)
            {
                lst1.Items.Add(lst2.Items[i]);
            }
            for (int i = 0; i < lst2.Items.Count; i++)
            {
                lst2.Items.Remove(lst2.Items[i]);
            }
        }
    }
}
