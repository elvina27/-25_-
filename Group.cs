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
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatSQLDataSet.ГруппыСтудентов". При необходимости она может быть перемещена или удалена.
            this.группыСтудентовTableAdapter.Fill(this.dekanatSQLDataSet.ГруппыСтудентов);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
