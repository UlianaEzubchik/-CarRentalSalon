
namespace Kursovaya
{
    partial class оформлениеЗаказа
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
            System.Windows.Forms.Label fk_cLabel;
            System.Windows.Forms.Label fk_vLabel;
            System.Windows.Forms.Label dateVidachiLabel;
            System.Windows.Forms.Label dateReturnLabel;
            System.Windows.Forms.Label priceLabel;
            this.prokatDataSet = new Kursovaya.ProkatDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Kursovaya.ProkatDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Kursovaya.ProkatDataSetTableAdapters.TableAdapterManager();
            this.vidachiTableAdapter = new Kursovaya.ProkatDataSetTableAdapters.VidachiTableAdapter();
            this.vidachiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateVidachiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new Kursovaya.ProkatDataSetTableAdapters.VehicleTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            fk_cLabel = new System.Windows.Forms.Label();
            fk_vLabel = new System.Windows.Forms.Label();
            dateVidachiLabel = new System.Windows.Forms.Label();
            dateReturnLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prokatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidachiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fk_cLabel
            // 
            fk_cLabel.AutoSize = true;
            fk_cLabel.Location = new System.Drawing.Point(508, 183);
            fk_cLabel.Name = "fk_cLabel";
            fk_cLabel.Size = new System.Drawing.Size(70, 17);
            fk_cLabel.TabIndex = 16;
            fk_cLabel.Text = "Фамилия";
            // 
            // fk_vLabel
            // 
            fk_vLabel.AutoSize = true;
            fk_vLabel.Location = new System.Drawing.Point(508, 211);
            fk_vLabel.Name = "fk_vLabel";
            fk_vLabel.Size = new System.Drawing.Size(116, 17);
            fk_vLabel.TabIndex = 17;
            fk_vLabel.Text = "Модель машины";
            // 
            // dateVidachiLabel
            // 
            dateVidachiLabel.AutoSize = true;
            dateVidachiLabel.Location = new System.Drawing.Point(509, 273);
            dateVidachiLabel.Name = "dateVidachiLabel";
            dateVidachiLabel.Size = new System.Drawing.Size(95, 17);
            dateVidachiLabel.TabIndex = 18;
            dateVidachiLabel.Text = "Дата выдачи";
            // 
            // dateReturnLabel
            // 
            dateReturnLabel.AutoSize = true;
            dateReturnLabel.Location = new System.Drawing.Point(509, 301);
            dateReturnLabel.Name = "dateReturnLabel";
            dateReturnLabel.Size = new System.Drawing.Size(110, 17);
            dateReturnLabel.TabIndex = 19;
            dateReturnLabel.Text = "Дата возврата ";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(509, 327);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(43, 17);
            priceLabel.TabIndex = 20;
            priceLabel.Text = "Цена";
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
            this.tableAdapterManager.VidachiTableAdapter = this.vidachiTableAdapter;
            // 
            // vidachiTableAdapter
            // 
            this.vidachiTableAdapter.ClearBeforeFill = true;
            // 
            // vidachiBindingSource
            // 
            this.vidachiBindingSource.DataMember = "Vidachi";
            this.vidachiBindingSource.DataSource = this.prokatDataSet;
            // 
            // dateVidachiDateTimePicker
            // 
            this.dateVidachiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vidachiBindingSource, "dateVidachi", true));
            this.dateVidachiDateTimePicker.Location = new System.Drawing.Point(655, 266);
            this.dateVidachiDateTimePicker.Name = "dateVidachiDateTimePicker";
            this.dateVidachiDateTimePicker.Size = new System.Drawing.Size(236, 22);
            this.dateVidachiDateTimePicker.TabIndex = 27;
            // 
            // dateReturnDateTimePicker
            // 
            this.dateReturnDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vidachiBindingSource, "dateReturn", true));
            this.dateReturnDateTimePicker.Location = new System.Drawing.Point(655, 294);
            this.dateReturnDateTimePicker.Name = "dateReturnDateTimePicker";
            this.dateReturnDateTimePicker.Size = new System.Drawing.Size(236, 22);
            this.dateReturnDateTimePicker.TabIndex = 29;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vidachiBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(655, 322);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(236, 22);
            this.priceTextBox.TabIndex = 31;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(776, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 48);
            this.button1.TabIndex = 32;
            this.button1.Text = "Оформить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vidachiBindingSource, "fk_c", true));
            this.comboBox1.DataSource = this.clientsBindingSource1;
            this.comboBox1.DisplayMember = "name1";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(655, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 24);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "id_c";
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.prokatDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vidachiBindingSource, "fk_v", true));
            this.comboBox2.DataSource = this.vehicleBindingSource;
            this.comboBox2.DisplayMember = "model";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(655, 206);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(236, 24);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.ValueMember = "id_v";
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.prokatDataSet;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(1027, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Назад";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(428, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 48);
            this.button2.TabIndex = 37;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.vehicleBindingSource;
            this.comboBox3.DisplayMember = "priceOneDay";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(655, 236);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(236, 24);
            this.comboBox3.TabIndex = 38;
            this.comboBox3.ValueMember = "id_v";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Триф в день";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(474, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Введите свои данные, чтобы оформить заказ";
            // 
            // оформлениеЗаказа
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 1055);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateVidachiDateTimePicker);
            this.Controls.Add(this.dateReturnDateTimePicker);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(fk_cLabel);
            this.Controls.Add(fk_vLabel);
            this.Controls.Add(dateVidachiLabel);
            this.Controls.Add(dateReturnLabel);
            this.Controls.Add(priceLabel);
            this.Name = "оформлениеЗаказа";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.оформлениеЗаказа_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prokatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidachiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProkatDataSet prokatDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ProkatDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private ProkatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ProkatDataSetTableAdapters.VidachiTableAdapter vidachiTableAdapter;
        private System.Windows.Forms.BindingSource vidachiBindingSource;
        private System.Windows.Forms.DateTimePicker dateVidachiDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateReturnDateTimePicker;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private ProkatDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}