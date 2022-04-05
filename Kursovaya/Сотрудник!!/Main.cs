using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Kursovaya
{
    public partial class Main : Form
    {
        private readonly string TemplateFileName = @"D:\шарага\2сем\Kursovaya\чек1.docx";
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.prokatDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.SystemShtraf". При необходимости она может быть перемещена или удалена.
            this.systemShtrafTableAdapter.Fill(this.prokatDataSet.SystemShtraf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Shtrafi". При необходимости она может быть перемещена или удалена.
            this.shtrafiTableAdapter.Fill(this.prokatDataSet.Shtrafi);;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.prokatDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Vidachi". При необходимости она может быть перемещена или удалена.
            this.vidachiTableAdapter.Fill(this.prokatDataSet.Vidachi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Vehicle". При необходимости она может быть перемещена или удалена.
            this.vehicleTableAdapter.Fill(this.prokatDataSet.Vehicle);
            this.Text = "Прокат автомобилей";
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //panel6.BringToFront();
            panel2.SendToBack();
            panel1.SendToBack();
            panel4.SendToBack();
            panel5.SendToBack();
            panel3.SendToBack();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
            panel2.SendToBack();
            panel1.SendToBack();
            panel4.SendToBack();
            panel5.SendToBack();
            panel6.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel2.SendToBack();
            panel4.SendToBack();
            panel3.SendToBack();
            panel5.SendToBack();
            panel6.SendToBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel1.SendToBack();
            panel4.SendToBack();
            panel3.SendToBack();
            panel5.SendToBack();
            panel6.SendToBack();


            //Выдача выдача = new Выдача();
            // выдача.Text = "Выдача на прокат";
            //выдача.Show();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void просмотрШтрафовToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void просмотрВыдачToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)

        {

;        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void чекToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
            panel1.SendToBack();
            panel2.SendToBack();
            panel3.SendToBack();
            panel4.SendToBack();
            panel6.SendToBack();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel6.BringToFront();
            panel1.SendToBack();
            panel2.SendToBack();
            panel3.SendToBack();
            panel4.SendToBack();
            panel5.SendToBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
            panel1.SendToBack();
            panel2.SendToBack();
            panel3.SendToBack();
            panel5.SendToBack();
            panel6.SendToBack();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prokatDataSet);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.AddNew();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prokatDataSet);

             MessageBox.Show("Новый администратор добавлен!!!!!");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.AddNew();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prokatDataSet);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.vidachiBindingSource.AddNew();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vidachiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prokatDataSet);
            MessageBox.Show("Заказ успешно оформлен!");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                this.автомобилиTableAdapter.Fill(this.prokatDataSet.Автомобили, textBox1.Text, textBox2.Text, textBox3.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.RemoveCurrent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            форма форма = new форма();
            форма.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                this.автомобилиTableAdapter.Fill(this.prokatDataSet.Автомобили, textBox4.Text, textBox5.Text, textBox6.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
       
        private void button22_Click(object sender, EventArgs e)
        {
            this.vidachiBindingSource.RemoveCurrent();
        }


        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                this.выдачиTableAdapter.Fill(this.prokatDataSet.Выдачи, textBox7.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                this.клиентыTableAdapter.Fill(this.prokatDataSet.Клиенты, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                this.клиентыTableAdapter.Fill(this.prokatDataSet.Клиенты, textBox4.Text, textBox4.Text, textBox4.Text, textBox4.Text, textBox4.Text, textBox4.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.clientsBindingSource.RemoveCurrent();
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.поискАдминаTableAdapter.Fill(this.prokatDataSet.ПоискАдмина, textBox15.Text, textBox14.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                this.поискАдминаTableAdapter.Fill(this.prokatDataSet.ПоискАдмина, textBox4.Text, textBox4.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.RemoveCurrent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            форма форма = new форма();
            форма.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             switch (this.listBox1.SelectedItem.ToString())
            {
                case "Автомобили":
                    label20.Text = "Форма «Автомобили» содержит информацию об автомобилях в салоне. Имеет кнопки: «Создать», «Сохранить»,\n «Удалить», «Поиск», «Посмотреть все автомобили», «Назад».\n" +
                        "Для добавления автомобиля, нажмите на кнопку 'Создать'.\n Для сохранения автомобиля в базе данных - нажмите на кнопку 'Сохранить'.\n" +
                        "Для удаления автомобиля, нажмите на кнопку 'Удалить'.";
                    break;      
                case "Выдачи":
                    label20.Text = "Форма «Выдачи» содержит информацию о выдачах. Имеет кнопки: «Создать», «Сохранить»,\n «Удалить», «Поиск», «Назад».\n" +
                        "Для добавления выдачи, нажмите на кнопку 'Создать'.\n Для сохранения выдачи в базе данных - нажмите на кнопку 'Сохранить'.\n" +
                        "Для удаления выдачи, нажмите на кнопку 'Удалить'.";
                    break;
                case "Клиенты":
                    label20.Text = "Форма «Клиенты» содержит информацию о клиентах. Имеет кнопки: «Создать», «Сохранить»,\n «Удалить», «Поиск», «Посмотреть всех клиентов, «Назад».\n" +
                        "Для добавления клиента, нажмите на кнопку 'Создать'.\n Для сохранения клиента в базе данных - нажмите на кнопку 'Сохранить'.\n" +
                        "Для удаления клиента, нажмите на кнопку 'Удалить'.";
                    break;
                case "Штрафы":
                    label20.Text = "Форма «Штрафы» содержит информацию о штрафах. Имеет кнопки: «Создать», «Сохранить»,\n «Удалить», «Поиск», «Посмотреть всех штрафов, «Назад».\n" +
                        "Для добавления штрафа, нажмите на кнопку 'Создать'.\n Для сохранения штрафа в базе данных - нажмите на кнопку 'Сохранить'.\n" +
                        "Для удаления штрафа, нажмите на кнопку 'Удалить'.";
                    break;
                case "Пользователи":
                    label20.Text = "Форма «Пользователи» содержит информацию об администраторах. Имеет кнопки: «Создать», «Сохранить»,\n «Удалить», «Поиск», «Посмотреть всех администраторов, «Назад».\n" +
                        "Для добавления администратора, нажмите на кнопку 'Создать'.\n Для сохранения администратора в базе данных - нажмите на кнопку 'Сохранить'.\n" +
                        "Для удаления администратора, нажмите на кнопку 'Удалить'.";
                    break;
                case "Чек":
                    label20.Text = "Форма Чек содержит информацию о выдачах и позволяет распечатать чек по любой из выдач путем нажатия кнопки «Чек».";
                    break;                
                default:
                    break;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            форма форма = new форма();
            форма.Show();
            this.Hide();
        }

        private void button32_Click(object sender, EventArgs e)
        {
             this.shtrafiBindingSource.AddNew();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shtrafiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prokatDataSet);
            MessageBox.Show("Штраф добавлен!!!!");
        }

        private void label21_Click(object sender, EventArgs e)
        {
            форма форма = new форма();
            форма.Show();
            this.Hide();
        }






        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.поискШтрафаTableAdapter.Fill(this.prokatDataSet.ПоискШтрафа, textBox4.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.shtrafiBindingSource.RemoveCurrent();
        }

        private void поискАдминаBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            форма форма = new форма();
            форма.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            форма форма = new форма();
            форма.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.vehicleBindingSource.AddNew();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prokatDataSet);
            MessageBox.Show("Машина добавлена!!!!");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shtrafiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prokatDataSet);
            MessageBox.Show("Штраф добавлен!!!!");
        }

        private void ReplaceWordXub(string StupToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: StupToReplace, ReplaceWith: text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            var idv = id_vComboBox.Text;
            var surname = name1TextBox1.Text;
            var vehicle = modelTextBox1.Text;
            var dateVid = dateVidachiDateTimePicker1.Value.ToShortDateString();
            var dateRet = dateReturnDateTimePicker1.Value.ToShortDateString();
            var Price = priceTextBox1.Text;

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            var wordDocument = wordApp.Documents.Open(TemplateFileName);
            ReplaceWordXub("{idv}", idv, wordDocument);
            ReplaceWordXub("{surname}", surname, wordDocument);
            ReplaceWordXub("{vehicle}", vehicle, wordDocument);
            ReplaceWordXub("{dateVid}", dateVid, wordDocument);
            ReplaceWordXub("{dateRet}", dateRet, wordDocument);
            ReplaceWordXub("{Price}", Price, wordDocument);

            wordDocument.SaveAs(@"D:\шарага\2сем\Kursovaya\чек1.docx");
            wordApp.Visible = true;
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            this.vidachiBindingSource.MoveNext();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.vidachiBindingSource.MoveFirst();
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            this.vidachiBindingSource.MoveLast();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            this.vidachiBindingSource.MovePrevious();
        }
    }
}
