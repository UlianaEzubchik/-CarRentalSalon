
namespace Kursovaya
{
    partial class procat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label passportLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label otchestvoLabel;
            System.Windows.Forms.Label name1Label;
            System.Windows.Forms.Label phoneLabel1;
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prokatDataSet = new Kursovaya.ProkatDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Kursovaya.ProkatDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Kursovaya.ProkatDataSetTableAdapters.TableAdapterManager();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.otchestvoTextBox = new System.Windows.Forms.TextBox();
            this.name1TextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            otchestvoLabel = new System.Windows.Forms.Label();
            name1Label = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prokatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(551, 286);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(117, 17);
            passportLabel.TabIndex = 41;
            passportLabel.Text = "Номер паспорта";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(551, 317);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(48, 17);
            adressLabel.TabIndex = 43;
            adressLabel.Text = "Адрес";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(551, 171);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(70, 17);
            surnameLabel.TabIndex = 45;
            surnameLabel.Text = "Фамилия";
            // 
            // otchestvoLabel
            // 
            otchestvoLabel.AutoSize = true;
            otchestvoLabel.Location = new System.Drawing.Point(551, 230);
            otchestvoLabel.Name = "otchestvoLabel";
            otchestvoLabel.Size = new System.Drawing.Size(71, 17);
            otchestvoLabel.TabIndex = 47;
            otchestvoLabel.Text = "Отчество";
            // 
            // name1Label
            // 
            name1Label.AutoSize = true;
            name1Label.Location = new System.Drawing.Point(551, 199);
            name1Label.Name = "name1Label";
            name1Label.Size = new System.Drawing.Size(35, 17);
            name1Label.TabIndex = 49;
            name1Label.Text = "Имя";
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Location = new System.Drawing.Point(551, 258);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(68, 17);
            phoneLabel1.TabIndex = 50;
            phoneLabel1.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(470, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите свои данные, чтобы зарегестрироваться";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 56);
            this.button1.TabIndex = 35;
            this.button1.Text = "Зарагистрироваться ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(963, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Я есть в базе данных клиентов";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // prokatDataSet
            // 
            this.prokatDataSet.DataSetName = "ProkatDataSet";
            this.prokatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.prokatDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.ShtrafiTableAdapter = null;
            this.tableAdapterManager.SystemShtrafTableAdapter = null;
            this.tableAdapterManager.typeVTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kursovaya.ProkatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            this.tableAdapterManager.VidachiTableAdapter = null;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(685, 314);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(170, 22);
            this.adressTextBox.TabIndex = 44;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(685, 196);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(170, 22);
            this.surnameTextBox.TabIndex = 46;
            // 
            // otchestvoTextBox
            // 
            this.otchestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "otchestvo", true));
            this.otchestvoTextBox.Location = new System.Drawing.Point(686, 230);
            this.otchestvoTextBox.Name = "otchestvoTextBox";
            this.otchestvoTextBox.Size = new System.Drawing.Size(169, 22);
            this.otchestvoTextBox.TabIndex = 48;
            // 
            // name1TextBox
            // 
            this.name1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "name1", true));
            this.name1TextBox.Location = new System.Drawing.Point(685, 166);
            this.name1TextBox.Name = "name1TextBox";
            this.name1TextBox.Size = new System.Drawing.Size(170, 22);
            this.name1TextBox.TabIndex = 50;
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(685, 286);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(170, 22);
            this.passportTextBox.TabIndex = 42;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(686, 258);
            this.phoneMaskedTextBox.Mask = "375(99)000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(169, 22);
            this.phoneMaskedTextBox.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(475, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 56);
            this.button2.TabIndex = 52;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(1128, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Назад";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // procat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(phoneLabel1);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(otchestvoLabel);
            this.Controls.Add(this.otchestvoTextBox);
            this.Controls.Add(name1Label);
            this.Controls.Add(this.name1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "procat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prokatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private ProkatDataSet prokatDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ProkatDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private ProkatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox otchestvoTextBox;
        private System.Windows.Forms.TextBox name1TextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}