namespace Пр25_Малышева_и_Коршикова
{
    partial class Disciplina
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dekanatSQLDataSet = new Пр25_Малышева_и_Коршикова.dekanatSQLDataSet();
            this.дисциплиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дисциплиныTableAdapter = new Пр25_Малышева_и_Коршикова.dekanatSQLDataSetTableAdapters.ДисциплиныTableAdapter();
            this.кодДисциплиныDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колЧасовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодДисциплиныDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.колЧасовDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.дисциплиныBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // dekanatSQLDataSet
            // 
            this.dekanatSQLDataSet.DataSetName = "dekanatSQLDataSet";
            this.dekanatSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дисциплиныBindingSource
            // 
            this.дисциплиныBindingSource.DataMember = "Дисциплины";
            this.дисциплиныBindingSource.DataSource = this.dekanatSQLDataSet;
            // 
            // дисциплиныTableAdapter
            // 
            this.дисциплиныTableAdapter.ClearBeforeFill = true;
            // 
            // кодДисциплиныDataGridViewTextBoxColumn
            // 
            this.кодДисциплиныDataGridViewTextBoxColumn.DataPropertyName = "КодДисциплины";
            this.кодДисциплиныDataGridViewTextBoxColumn.HeaderText = "Код дисциплины";
            this.кодДисциплиныDataGridViewTextBoxColumn.Name = "кодДисциплиныDataGridViewTextBoxColumn";
            this.кодДисциплиныDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // колЧасовDataGridViewTextBoxColumn
            // 
            this.колЧасовDataGridViewTextBoxColumn.DataPropertyName = "КолЧасов";
            this.колЧасовDataGridViewTextBoxColumn.HeaderText = "Кол-во часов";
            this.колЧасовDataGridViewTextBoxColumn.Name = "колЧасовDataGridViewTextBoxColumn";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(189, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Disciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 443);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Disciplina";
            this.Text = "Дисциплины";
            this.Load += new System.EventHandler(this.Disciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dekanatSQLDataSet dekanatSQLDataSet;
        private System.Windows.Forms.BindingSource дисциплиныBindingSource;
        private dekanatSQLDataSetTableAdapters.ДисциплиныTableAdapter дисциплиныTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДисциплиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колЧасовDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}