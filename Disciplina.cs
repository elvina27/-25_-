using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр25_Малышева_и_Коршикова
{
    public partial class Disciplina : Form
    {
        public Disciplina()
        {
            InitializeComponent();
        }

        private void Disciplina_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatSQLDataSet.Дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.dekanatSQLDataSet.Дисциплины);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
