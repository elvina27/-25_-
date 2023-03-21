namespace Пр25_Малышева_и_Коршикова
{
    partial class Group
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
            this.группыСтудентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыСтудентовTableAdapter = new Пр25_Малышева_и_Коршикова.dekanatSQLDataSetTableAdapters.ГруппыСтудентовTableAdapter();
            this.кодГруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.курсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семестрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыСтудентовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодГруппыDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.курсDataGridViewTextBoxColumn,
            this.семестрDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.группыСтудентовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // dekanatSQLDataSet
            // 
            this.dekanatSQLDataSet.DataSetName = "dekanatSQLDataSet";
            this.dekanatSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группыСтудентовBindingSource
            // 
            this.группыСтудентовBindingSource.DataMember = "ГруппыСтудентов";
            this.группыСтудентовBindingSource.DataSource = this.dekanatSQLDataSet;
            // 
            // группыСтудентовTableAdapter
            // 
            this.группыСтудентовTableAdapter.ClearBeforeFill = true;
            // 
            // кодГруппыDataGridViewTextBoxColumn
            // 
            this.кодГруппыDataGridViewTextBoxColumn.DataPropertyName = "кодГруппы";
            this.кодГруппыDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.кодГруппыDataGridViewTextBoxColumn.Name = "кодГруппыDataGridViewTextBoxColumn";
            this.кодГруппыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // курсDataGridViewTextBoxColumn
            // 
            this.курсDataGridViewTextBoxColumn.DataPropertyName = "курс";
            this.курсDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.курсDataGridViewTextBoxColumn.Name = "курсDataGridViewTextBoxColumn";
            // 
            // семестрDataGridViewTextBoxColumn
            // 
            this.семестрDataGridViewTextBoxColumn.DataPropertyName = "семестр";
            this.семестрDataGridViewTextBoxColumn.HeaderText = "Семестр";
            this.семестрDataGridViewTextBoxColumn.Name = "семестрDataGridViewTextBoxColumn";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(211, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 446);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Group";
            this.Text = "Группы";
            this.Load += new System.EventHandler(this.Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыСтудентовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dekanatSQLDataSet dekanatSQLDataSet;
        private System.Windows.Forms.BindingSource группыСтудентовBindingSource;
        private dekanatSQLDataSetTableAdapters.ГруппыСтудентовTableAdapter группыСтудентовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодГруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn курсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn семестрDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}