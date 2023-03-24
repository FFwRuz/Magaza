using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magaza
{
    public partial class Magaza : Form
    {
        public Magaza()
        {
            InitializeComponent();
        }
        public  int fiyat = 0;
        private void Magaza_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            button5.Visible = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            this.CenterToScreen();
            this.BackColor = Color.Gray;
            DialogResult cevap = MessageBox.Show(" Mağazaya Giriş Yapmak İstiyor Musunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
                                                           
            label1.Text = Convert.ToString(fiyat);
            groupBox1.Visible = true;
            button5.Visible = true;
            button3.Visible = false;
            button1.Visible = false;
            button4.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (radioButton6.Checked == true)
            {
                fiyat += 3000;
            }
            if (radioButton7.Checked == true)
            {
                fiyat += 5000;
            }
            if (radioButton8.Checked == true)
            {
                fiyat += 10000;
            }
            if (radioButton9.Checked == true)
            {
                fiyat += 25000;
            }
            if (radioButton10.Checked == true)
            {
                fiyat += 4000;
            }
            if (radioButton11.Checked == true)
            {
                fiyat += 6000;
            }
            if (radioButton12.Checked == true)
            {
                fiyat += 8000;
            }
            if (radioButton13.Checked == true)
            {
                fiyat += 10000;
            }
            if (radioButton14.Checked == true)
            {
                fiyat += 5000;
            }
            if (radioButton1.Checked == true)
            {
                fiyat += 500;
            }
            if (radioButton2.Checked == true)
            {
                fiyat += 700;
            }
            if (radioButton3.Checked == true)
            {
                fiyat += 200;
            }
            if (radioButton4.Checked == true)
            {
                fiyat += 1000;
            }
            if (radioButton5.Checked == true)
            {
                fiyat += 2000;
            }
           
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            button5.Visible = false;
            button3.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(fiyat);
            groupBox2.Visible = true;
            button2.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            button1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            label1.Text = Convert.ToString(fiyat);
            groupBox3.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button5.Visible = true;
        }
    }
}
