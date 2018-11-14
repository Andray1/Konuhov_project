using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konuhov_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "konuhov_projectDataSet1.Kurs_valut". При необходимости она может быть перемещена или удалена.
            this.kurs_valutTableAdapter.Fill(this.konuhov_projectDataSet.Kurs_valut);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "konuhov_projectDataSet.Valut". При необходимости она может быть перемещена или удалена.
            this.valutTableAdapter.Fill(this.konuhov_projectDataSet.Valut);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "konuhov_projectDataSet.vidu_vkladov". При необходимости она может быть перемещена или удалена.
            this.vidu_vkladovTableAdapter.Fill(this.konuhov_projectDataSet.vidu_vkladov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "konuhov_projectDataSet.Vkladu". При необходимости она может быть перемещена или удалена.
            this.vkladuTableAdapter.Fill(this.konuhov_projectDataSet.Vkladu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "konuhov_projectDataSet.Kurs_valut". При необходимости она может быть перемещена или удалена.
            this.kurs_valutTableAdapter.Fill(this.konuhov_projectDataSet.Kurs_valut);

            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "konuhov_projectDataSet.Kurs_valut". При необходимости она может быть перемещена или удалена.
            this.kurs_valutTableAdapter.Fill(this.konuhov_projectDataSet.Kurs_valut);

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn col = new DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    col = датаDataGridViewTextBoxColumn;
                    break;
                case 1:
                    col = покупкаDataGridViewTextBoxColumn;
                    break;
                case 2:
                    col = продажаDataGridViewTextBoxColumn;
                    break;
                case 3:
                    col = названиевалютыDataGridViewTextBoxColumn;
                    break;
            }
            if (radioButton1.Checked)
                kurs_valutDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending);
            else kurs_valutDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kursvalutBindingSource.Filter = "Название_валюты='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kursvalutBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i=0; i <= kurs_valutDataGridView.ColumnCount-1;i++)
            {
                for (int j=0; j <= kurs_valutDataGridView.RowCount-2;j++)
                {
                    kurs_valutDataGridView[i, j].Style.BackColor = Color.White;
                    kurs_valutDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i <= kurs_valutDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j <= kurs_valutDataGridView.RowCount - 2; j++)
                {
                    if (kurs_valutDataGridView[i,j].Value.ToString().IndexOf(textBox1.Text)!=-1)
                    {
                        kurs_valutDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        kurs_valutDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
