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
    public partial class AddStud : Form
    {
        public AddStud()
        {
            InitializeComponent();
        }

        private void AddStud_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatSQLDataSet.ГруппыСтудентов". При необходимости она может быть перемещена или удалена.
            this.группыСтудентовTableAdapter.Fill(this.dekanatSQLDataSet.ГруппыСтудентов);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            
            if (main != null)
            {
                DataRow nRow = main.dekanatSQLDataSet1.Tables[2].NewRow();
                int rc = main.dataGridViewDekan.RowCount + 1;
                nRow[0] = txtNumBilet.Text;
                nRow[1] = cmbGroup.SelectedValue.ToString();
                nRow[2] = txtFamily.Text;
                nRow[3] = txtName.Text;
                nRow[4] = txtOtch.Text;
                nRow[5] = cmbPol.Text;
                nRow[6] = dateTimePicker.Text;
                nRow[7] = txtMesto.Text;

                main.dekanatSQLDataSet1.Tables[2].Rows.Add(nRow);
                main.студентыTableAdapter.Update(main.dekanatSQLDataSet1.студенты);
                main.dekanatSQLDataSet1.Tables[2].AcceptChanges();
                main.dataGridViewDekan.Refresh();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
