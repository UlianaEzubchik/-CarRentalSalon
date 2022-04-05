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
    public partial class форма : Form
    {
        public форма()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void _1форма_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ВходикАдмина входикАдмина = new ВходикАдмина();
            входикАдмина.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            ВыборМашины userAvtoriz = new ВыборМашины();
            userAvtoriz.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
