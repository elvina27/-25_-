namespace Пр25_Малышева_и_Коршикова
{
    partial class AddStud
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumBilet = new System.Windows.Forms.TextBox();
            this.txtOtch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbPol = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dekanatSQLDataSet = new Пр25_Малышева_и_Коршикова.dekanatSQLDataSet();
            this.группыСтудентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыСтудентовTableAdapter = new Пр25_Малышева_и_Коршикова.dekanatSQLDataSetTableAdapters.ГруппыСтудентовTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыСтудентовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер студ. билета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пол";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Место рождения";
            // 
            // txtNumBilet
            // 
            this.txtNumBilet.Location = new System.Drawing.Point(180, 35);
            this.txtNumBilet.Name = "txtNumBilet";
            this.txtNumBilet.Size = new System.Drawing.Size(200, 20);
            this.txtNumBilet.TabIndex = 8;
            // 
            // txtOtch
            // 
            this.txtOtch.Location = new System.Drawing.Point(180, 160);
            this.txtOtch.Name = "txtOtch";
            this.txtOtch.Size = new System.Drawing.Size(200, 20);
            this.txtOtch.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(180, 96);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(200, 20);
            this.txtFamily.TabIndex = 11;
            // 
            // txtMesto
            // 
            this.txtMesto.Location = new System.Drawing.Point(180, 256);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(200, 20);
            this.txtMesto.TabIndex = 12;
            // 
            // cmbGroup
            // 
            this.cmbGroup.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.группыСтудентовBindingSource, "название", true));
            this.cmbGroup.DataSource = this.группыСтудентовBindingSource;
            this.cmbGroup.DisplayMember = "название";
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(180, 64);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(200, 21);
            this.cmbGroup.TabIndex = 13;
            this.cmbGroup.ValueMember = "кодГруппы";
            // 
            // cmbPol
            // 
            this.cmbPol.FormattingEnabled = true;
            this.cmbPol.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.cmbPol.Location = new System.Drawing.Point(180, 191);
            this.cmbPol.Name = "cmbPol";
            this.cmbPol.Size = new System.Drawing.Size(200, 21);
            this.cmbPol.TabIndex = 14;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(180, 223);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(252, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 32);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // AddStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 402);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cmbPol);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.txtMesto);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtOtch);
            this.Controls.Add(this.txtNumBilet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление студента";
            this.Load += new System.EventHandler(this.AddStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dekanatSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыСтудентовBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumBilet;
        private System.Windows.Forms.TextBox txtOtch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbPol;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private dekanatSQLDataSet dekanatSQLDataSet;
        private System.Windows.Forms.BindingSource группыСтудентовBindingSource;
        private dekanatSQLDataSetTableAdapters.ГруппыСтудентовTableAdapter группыСтудентовTableAdapter;
    }
}