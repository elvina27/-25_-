using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Пр25_Малышева_и_Коршикова
{
    public partial class StudOcenki : Form
    {
        public const string CONECT = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\USERS\1088-20\DOCUMENTS\ПР25_МАЛЫШЕВА И КОРШИКОВА\BIN\DEBUG\DEKANATSQL.MDF"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection myConnection;  
        public StudOcenki()
        {
            InitializeComponent();
            myConnection = new SqlConnection(CONECT);
            myConnection.Open();
            StudOcenki_Load(this, null);
        }

        private void StudOcenki_Load(object sender, EventArgs e)
        {
            try
            {
                myConnection = new SqlConnection(CONECT);
                myConnection.Open();
                string query = "SELECT" +
                    "[ГруппыСтудентов].[название]," +
                    "[студенты].[Фамилия]," +
                    "[студенты].[Имя]," +
                    "[Дисциплины].[Название]," +
                    "[Успеваемость].[Оценка]," +
                    "[Успеваемость].[Вид контроля]" +
                    "FROM" +
                    "[студенты]," +
                    "[ГруппыСтудентов]," +
                    "[Дисциплины]," +
                    "[Успеваемость]" +
                    "WHERE" +
                    "([Успеваемость].[КодСтудента]=[студенты].[кодСтудента]) AND" +
                    "([студенты].[кодГруппы]=[ГруппыСтудентов].[кодГруппы]) AND" +
                    "([Успеваемость].[КодДисциплины]=[Дисциплины].[КодДисциплины])";

                var comand = new SqlCommand(query);
                comand.Connection= myConnection;
                var reader = comand.ExecuteReader();
                List<string[]> data = new List<string[]>();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Данные не найдены!");
                }
                else
                {
                    while (reader.Read())
                    {
                        data.Add(new string[6]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                    }
                    foreach (string[] s in data)
                        dataGridView1.Rows.Add(s);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
        }

        private void StudOcenki_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = true;

            Excel.Workbook wBook;
            Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 15;
            xlSheet = (Excel.Worksheet)wBook.Sheets[1];
            xlSheet.Name = "Оценки";
            xlApp.Cells[1, 1] = "Группа";
            xlApp.Cells[1, 2] = "Фамилия студента";
            xlApp.Cells[1, 3] = "Имя студента";
            xlApp.Cells[1, 4] = "Название дисциплины";
            xlApp.Cells[1, 5] = "Оценка";
            xlApp.Cells[1, 6] = "Вид контроля";
            //продолжить 
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    xlApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    xlSheet.Cells.HorizontalAlignment = 3;
                    xlApp.Visible = true;
                }
            }
        }
    }
}
