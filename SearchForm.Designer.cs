namespace Пр25_Малышева_и_Коршикова
{
    partial class SearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPoisk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите фамилию студента";
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Location = new System.Drawing.Point(30, 62);
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(423, 20);
            this.textBoxPoisk.TabIndex = 1;
            // 
            // btnPoisk
            // 
            this.btnPoisk.Location = new System.Drawing.Point(63, 147);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(105, 32);
            this.btnPoisk.TabIndex = 1;
            this.btnPoisk.Text = "Найти";
            this.btnPoisk.UseVisualStyleBackColor = true;
            this.btnPoisk.Click += new System.EventHandler(this.btnPoisk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(299, 147);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 207);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPoisk);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск записи";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.Button btnClose;
    }
}