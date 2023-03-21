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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatSQLDataSet1.студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.dekanatSQLDataSet1.студенты);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.студентыTableAdapter.Update(this.dekanatSQLDataSet1);
        }

        private void dataGridViewDekan_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel) 
            {
                e.Cancel = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStud af = new AddStud();
            af.Owner = this;
            af.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm mu = new SearchForm();
            mu.Owner = this;
            mu.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            StudOcenki mu = new StudOcenki();
            mu.Owner = this;
            mu.Show();
        }
    }
}
