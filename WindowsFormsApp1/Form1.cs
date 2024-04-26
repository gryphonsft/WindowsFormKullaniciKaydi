using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "" && guna2TextBox2.Text == "" && guna2TextBox3.Text == "")
            {
                guna2MessageDialog2.Show("Lütfen boş değer girmeyiniz");

            }else if (guna2TextBox1.Text == "" && guna2TextBox2.Text != "" && guna2TextBox3.Text != "")
            {
                guna2MessageDialog2.Show("Lütfen ad alanını boş bırakmayınız");
                
            }
            else if (guna2TextBox1.Text != "" && guna2TextBox2.Text == "" && guna2TextBox3.Text != "")
            {
                guna2MessageDialog2.Show("Lütfen yaş alanını boş bırakmayınız");
                
            }
            else if (guna2TextBox1.Text != "" && guna2TextBox2.Text != "" && guna2TextBox3.Text == "")
            {
                guna2MessageDialog2.Show("Lütfen şehir alanını boş bırakmayınız");
                
            }
            else
            {

                listBox1.Items.Add(guna2TextBox1.Text + " " + guna2TextBox2.Text + " " + guna2TextBox3.Text);
            }

            
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
            else
            {
                guna2MessageDialog1.Show("Lütfen bir öğeyi seçiniz");

            }
        }
    }
}
