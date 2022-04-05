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
    public partial class ВходикАдмина : Form
    {
        public ВходикАдмина()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.входАдминаTableAdapter.Fill(this.prokatDataSet.ВходАдмина, loginTextBox.Text, passwordTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            if (this.входАдминаTableAdapter.Fill(this.prokatDataSet.ВходАдмина, loginTextBox.Text, passwordTextBox.Text) > 0)
            {
                MessageBox.Show("Авторизация выполнена успешно!!!");
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Авторизация не выполнена!!!");
                loginTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            форма форма = new форма();
            форма.Show();
            this.Hide();
        }
    }
}
