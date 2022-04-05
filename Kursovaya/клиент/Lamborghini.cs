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
    public partial class Lamborghini : Form
    {
        public Lamborghini()
        {
            InitializeComponent();
        }

        public void selectTab2(int index)
        {
            tabControl1.SelectTab(index);
            TabPage tabPage = new TabPage();
            tabPage.Show();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
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

        private void label35_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void label43_Click(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }

        int ind = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ind > 0)
            {
                ind--;
                pictureBox1.Image = imageList1.Images[ind];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ind < imageList1.Images.Count - 1)
            {
                ind++;
                pictureBox1.Image = imageList1.Images[ind];
            }
        }

        int ind2 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (ind2 > 0)
            {
                ind2--;
                pictureBox2.Image = imageList2.Images[ind2];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ind2 < imageList2.Images.Count - 1)
            {
                ind2++;
                pictureBox2.Image = imageList2.Images[ind2];
            }
        }

        int ind3 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (ind3 > 0)
            {
                ind3--;
                pictureBox3.Image = imageList3.Images[ind3];
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (ind3 < imageList3.Images.Count - 1)
            {
                ind3++;
                pictureBox3.Image = imageList3.Images[ind3];
            }
        }

        int ind4 = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            if (ind4 > 0)
            {
                ind4--;
                pictureBox4.Image = imageList4.Images[ind4];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ind4 < imageList4.Images.Count - 1)
            {
                ind4++;
                pictureBox4.Image = imageList4.Images[ind4];
            }
        }

        int ind5 = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            if (ind5 > 0)
            {
                ind5--;
                pictureBox5.Image = imageList5.Images[ind5];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ind5 < imageList5.Images.Count - 1)
            {
                ind5++;
                pictureBox5.Image = imageList5.Images[ind5];
            }
        }


        int ind6 = 0;
        private void button12_Click(object sender, EventArgs e)
        {
            if (ind6 > 0)
            {
                ind6--;
                pictureBox6.Image = imageList6.Images[ind6];
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ind6 < imageList6.Images.Count - 1)
            {
                ind6++;
                pictureBox6.Image = imageList6.Images[ind6];
            }
        }


        int ind7 = 0;
        private void button14_Click(object sender, EventArgs e)
        {
            if (ind7 > 0)
            {
                ind7--;
                pictureBox7.Image = imageList7.Images[ind7];
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ind7 < imageList7.Images.Count - 1)
            {
                ind7++;
                pictureBox7.Image = imageList7.Images[ind7];
            }
        }

        int ind8 = 0;
        private void button16_Click(object sender, EventArgs e)
        {
            if (ind8 > 0)
            {
                ind8--;
                pictureBox8.Image = imageList8.Images[ind8];
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ind8 < imageList8.Images.Count - 1)
            {
                ind8++;
                pictureBox8.Image = imageList8.Images[ind8];
            }
        }

        int ind9 = 0;
        private void button18_Click(object sender, EventArgs e)
        {
            if (ind9 > 0)
            {
                ind9--;
                pictureBox9.Image = imageList9.Images[ind9];
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (ind9 < imageList9.Images.Count - 1)
            {
                ind9++;
                pictureBox9.Image = imageList9.Images[ind9];
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
