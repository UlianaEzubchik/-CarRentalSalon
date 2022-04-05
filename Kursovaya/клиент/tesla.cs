using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class tesla : Form
    {
        public tesla()
        {
            InitializeComponent();
        }

        public void selectTab(int index)
        {
            tabControl1.SelectTab(index);
            TabPage tabPage = new TabPage();
            tabPage.Show(); 
        }

        private void tesla_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            ВыборМашины выборМашины = new ВыборМашины();
            выборМашины.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        int ind4 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (ind4 > 0)
            {
                ind4--;
                pictureBox3.Image = imageList4.Images[ind4];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ind4 < imageList4.Images.Count - 1)
            {
                ind4++;
                pictureBox3.Image = imageList4.Images[ind4];
            }
        }

        int ind = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            if (ind > 0)
            {
                ind--;
                pictureBox5.Image = imageList1.Images[ind];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ind < imageList1.Images.Count - 1)
            {
                ind++;
                pictureBox5.Image = imageList1.Images[ind];
            }
        }



        int ind2 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (ind2 > 0)
            {
                ind2--;
                pictureBox1.Image = imageList2.Images[ind2];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ind2 < imageList2.Images.Count - 1)
            {
                ind2++;
                pictureBox1.Image = imageList2.Images[ind2];
            }
        }


        int ind3 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (ind3 > 0)
            {
                ind3--;
                pictureBox2.Image = imageList3.Images[ind3];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ind3 < imageList3.Images.Count - 1)
            {
                ind3++;
                pictureBox2.Image = imageList3.Images[ind3];
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ВыборМашины выборМашины = new ВыборМашины();
            выборМашины.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ВыборМашины выборМашины = new ВыборМашины();
            выборМашины.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ВыборМашины выборМашины = new ВыборМашины();
            выборМашины.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            ВыборМашины выборМашины = new ВыборМашины();
            выборМашины.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }
    }
}
