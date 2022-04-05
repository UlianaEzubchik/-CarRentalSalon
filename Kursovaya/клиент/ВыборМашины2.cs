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
    public partial class ВыборМашины2 : Form
    {
        public ВыборМашины2()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ВыборМашины выборМашины = new ВыборМашины();
            выборМашины.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.Show();
            lamborghini.selectTab2(1);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.Show();
            lamborghini.selectTab2(2);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.Show();
            lamborghini.selectTab2(3);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.Show();
            lamborghini.selectTab2(4);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.Show();
            lamborghini.selectTab2(5);
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.Show();
            lamborghini.selectTab2(6);
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.Show();
            lamborghini.selectTab2(7);
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.Show();
            lamborghini.selectTab2(8);
            this.Hide();
        }
    }
}
