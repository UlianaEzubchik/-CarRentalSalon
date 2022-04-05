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
    public partial class procat : Form
    {
        public procat()
        {
            InitializeComponent();


        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.clientsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.prokatDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.prokatDataSet.Clients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            // try
            //{
            //this.clientsBindingSource.AddNew();

                this.Validate();
                this.clientsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.prokatDataSet);


            оформлениеЗаказа оформлениеЗаказа = new оформлениеЗаказа();
            оформлениеЗаказа.Show();
            this.Hide();

            //}
            //catch
            //{
            // MessageBox.Show("Введите правильно все данные!!!!");
            //}

        }

        private void label2_Click(object sender, EventArgs e)
        {
            оформлениеЗаказа оформлениеЗаказа = new оформлениеЗаказа();
           оформлениеЗаказа.Show();
            this.Hide();

            //заказ заказ = new заказ();
            //заказ.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.AddNew();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ВыборМашины2 выборМашины2 = new ВыборМашины2();
            выборМашины2.Show();
            this.Hide();
        }
    }
}
