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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void студентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudOcenki studocenki = new StudOcenki();
            studocenki.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void вызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Owner = this;
            main.Show();

            AddStud addStud = new AddStud();
            addStud.Owner = this;
            addStud.Show();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Show();
        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.Show();
        }
    }
}
