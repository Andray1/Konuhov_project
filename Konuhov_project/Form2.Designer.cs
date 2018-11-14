namespace Konuhov_project
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.valutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konuhov_projectDataSet = new Konuhov_project.Konuhov_projectDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.kursvalutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Konuhov_project.Konuhov_projectDataSetTableAdapters.TableAdapterManager();
            this.kurs_valutDataGridView = new System.Windows.Forms.DataGridView();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.покупкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продажаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиевалютыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viduvkladovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konuhov_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursvalutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurs_valutDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduvkladovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Курс валют";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(462, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сортировка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 165);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По убыванию";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поле сортировки";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Название_валюты",
            "Дата",
            "Покупка",
            "Продажа"});
            this.listBox1.Location = new System.Drawing.Point(10, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 142);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По возрастанию";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название валюты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Критерий";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 20);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.valutBindingSource;
            this.comboBox1.DisplayMember = "Naz_val";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(324, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // valutBindingSource
            // 
            this.valutBindingSource.DataMember = "Valut";
            this.valutBindingSource.DataSource = this.konuhov_projectDataSet;
            // 
            // konuhov_projectDataSet
            // 
            this.konuhov_projectDataSet.DataSetName = "Konuhov_projectDataSet";
            this.konuhov_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Фильтровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Показать все";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(567, 320);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Закрыть";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // kursvalutBindingSource
            // 
            this.kursvalutBindingSource.DataMember = "Kurs_valut";
            this.kursvalutBindingSource.DataSource = this.konuhov_projectDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Dogovor_o_vkladeTableAdapter = null;
            this.tableAdapterManager.DolzhnostiTableAdapter = null;
            this.tableAdapterManager.KursTableAdapter = null;
            this.tableAdapterManager.SotrudnikiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Konuhov_project.Konuhov_projectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValutTableAdapter = null;
            this.tableAdapterManager.VkladchikiTableAdapter = null;
            this.tableAdapterManager.VkladuTableAdapter = null;
            // 
            // kurs_valutDataGridView
            // 
            this.kurs_valutDataGridView.AllowUserToDeleteRows = false;
            this.kurs_valutDataGridView.AutoGenerateColumns = false;
            this.kurs_valutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kurs_valutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаDataGridViewTextBoxColumn,
            this.покупкаDataGridViewTextBoxColumn,
            this.продажаDataGridViewTextBoxColumn,
            this.названиевалютыDataGridViewTextBoxColumn});
            this.kurs_valutDataGridView.DataSource = this.kursvalutBindingSource;
            this.kurs_valutDataGridView.Location = new System.Drawing.Point(12, 46);
            this.kurs_valutDataGridView.Name = "kurs_valutDataGridView";
            this.kurs_valutDataGridView.ReadOnly = true;
            this.kurs_valutDataGridView.Size = new System.Drawing.Size(444, 220);
            this.kurs_valutDataGridView.TabIndex = 11;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // покупкаDataGridViewTextBoxColumn
            // 
            this.покупкаDataGridViewTextBoxColumn.DataPropertyName = "Покупка";
            this.покупкаDataGridViewTextBoxColumn.HeaderText = "Покупка";
            this.покупкаDataGridViewTextBoxColumn.Name = "покупкаDataGridViewTextBoxColumn";
            this.покупкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // продажаDataGridViewTextBoxColumn
            // 
            this.продажаDataGridViewTextBoxColumn.DataPropertyName = "Продажа";
            this.продажаDataGridViewTextBoxColumn.HeaderText = "Продажа";
            this.продажаDataGridViewTextBoxColumn.Name = "продажаDataGridViewTextBoxColumn";
            this.продажаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиевалютыDataGridViewTextBoxColumn
            // 
            this.названиевалютыDataGridViewTextBoxColumn.DataPropertyName = "Название_валюты";
            this.названиевалютыDataGridViewTextBoxColumn.HeaderText = "Название валюты";
            this.названиевалютыDataGridViewTextBoxColumn.Name = "названиевалютыDataGridViewTextBoxColumn";
            this.названиевалютыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viduvkladovBindingSource
            // 
            this.viduvkladovBindingSource.DataMember = "vidu_vkladov";
            this.viduvkladovBindingSource.DataSource = this.konuhov_projectDataSet;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 363);
            this.Controls.Add(this.kurs_valutDataGridView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Курс валют";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konuhov_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursvalutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurs_valutDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduvkladovBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Konuhov_projectDataSet konuhov_projectDataSet;
        private System.Windows.Forms.BindingSource kursvalutBindingSource;
        private Konuhov_projectDataSetTableAdapters.Kurs_valutTableAdapter kurs_valutTableAdapter;
        private Konuhov_projectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kurs_valutDataGridView;
        private Konuhov_projectDataSetTableAdapters.VkladuTableAdapter vkladuTableAdapter;
        private System.Windows.Forms.BindingSource viduvkladovBindingSource;
        private Konuhov_projectDataSetTableAdapters.vidu_vkladovTableAdapter vidu_vkladovTableAdapter;
        private Konuhov_projectDataSetTableAdapters.ValutTableAdapter valutTableAdapter;
        private System.Windows.Forms.BindingSource valutBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn покупкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продажаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиевалютыDataGridViewTextBoxColumn;
    }
}