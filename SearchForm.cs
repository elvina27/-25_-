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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnPoisk_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridViewDekan.RowCount; i++)
                {
                    main.dataGridViewDekan.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridViewDekan.ColumnCount; j++)
                        if (main.dataGridViewDekan.Rows[i].Cells[j].Value != null)
                            if(main.dataGridViewDekan.Rows[i].Cells[j].Value.ToString().Contains(textBoxPoisk.Text))
                            {
                                main.dataGridViewDekan.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
