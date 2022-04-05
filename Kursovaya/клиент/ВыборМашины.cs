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
    public partial class ВыборМашины : Form
    {
        public ВыборМашины()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tesla tesla = new tesla();
            tesla.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tesla tesla = new tesla();
            tesla.Show();
            tesla.selectTab(3);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tesla tesla = new tesla();
            tesla.Show();
            tesla.selectTab(2);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tesla tesla = new tesla();
            tesla.Show();
            tesla.selectTab(1);
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            форма _1Форма = new форма();
            _1Форма.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mercedes mercedes = new mercedes();
            mercedes.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mercedes mercedes = new mercedes();
            mercedes.Show();
            mercedes.selectTab(1);
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mercedes mercedes = new mercedes();
            mercedes.Show();
            mercedes.selectTab(2);
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mercedes mercedes = new mercedes();
            mercedes.Show();
            mercedes.selectTab(3);
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mercedes mercedes = new mercedes();
            mercedes.Show();
            mercedes.selectTab(4);
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }

        private void ВыборМашины_Load(object sender, EventArgs e)
        {

        }
    }
}
