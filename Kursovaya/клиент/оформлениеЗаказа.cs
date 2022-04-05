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
    public partial class оформлениеЗаказа : Form
    {
        public оформлениеЗаказа()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prokatDataSet);

        }

        private void оформлениеЗаказа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Vehicle". При необходимости она может быть перемещена или удалена.
            this.vehicleTableAdapter.Fill(this.prokatDataSet.Vehicle);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Vidachi". При необходимости она может быть перемещена или удалена.
            this.vidachiTableAdapter.Fill(this.prokatDataSet.Vidachi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.prokatDataSet.Clients);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.vidachiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prokatDataSet);

             MessageBox.Show("Ваш заказ успешно оформлен, приходиите в ближайший салон и забирайте машину! Свяжитесь с нашим колл-центром, если у вас остались вопросы!");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            procat procat = new procat();
            procat.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.vidachiBindingSource.AddNew();
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
