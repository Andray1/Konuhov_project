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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "konuhov_projectDataSet1.Otchet_dogovor_o_vklade". При необходимости она может быть перемещена или удалена.
            this.otchet_dogovor_o_vkladeTableAdapter.Fill(this.konuhov_projectDataSet1.Otchet_dogovor_o_vklade);




        }
    }
}
