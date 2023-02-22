namespace project.presentation.reports.questionnaireAnalysisGraphic
{
    partial class QuestionnaireAnalysisGraphicReportForm
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
            this.tbxIdCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tbxDtf = new System.Windows.Forms.DateTimePicker();
            this.tbxDti = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTypeCrm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTypeCrm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxIdCompany);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnQuit);
            this.groupBox1.Controls.Add(this.tbxDtf);
            this.groupBox1.Controls.Add(this.tbxDti);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // tbxIdCompany
            // 
            this.tbxIdCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdCompany.Location = new System.Drawing.Point(87, 156);
            this.tbxIdCompany.MaxLength = 2;
            this.tbxIdCompany.Name = "tbxIdCompany";
            this.tbxIdCompany.Size = new System.Drawing.Size(173, 26);
            this.tbxIdCompany.TabIndex = 2;
            this.tbxIdCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empresa";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(88, 270);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(83, 30);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "&Exportar";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(177, 270);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(83, 30);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Sai&r";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // tbxDtf
            // 
            this.tbxDtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDtf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDtf.Location = new System.Drawing.Point(88, 104);
            this.tbxDtf.Name = "tbxDtf";
            this.tbxDtf.Size = new System.Drawing.Size(172, 26);
            this.tbxDtf.TabIndex = 1;
            // 
            // tbxDti
            // 
            this.tbxDti.Checked = false;
            this.tbxDti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDti.Location = new System.Drawing.Point(88, 53);
            this.tbxDti.Name = "tbxDti";
            this.tbxDti.Size = new System.Drawing.Size(172, 26);
            this.tbxDti.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data inicial";
            // 
            // cbxTypeCrm
            // 
            this.cbxTypeCrm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTypeCrm.FormattingEnabled = true;
            this.cbxTypeCrm.Items.AddRange(new object[] {
            " ",
            "SERVIÇOS",
            "VENDAS"});
            this.cbxTypeCrm.Location = new System.Drawing.Point(88, 207);
            this.cbxTypeCrm.Name = "cbxTypeCrm";
            this.cbxTypeCrm.Size = new System.Drawing.Size(172, 26);
            this.cbxTypeCrm.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pós venda";
            // 
            // QuestionnaireAnalysisReportForm
            // 
            this.AcceptButton = this.btnExport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(350, 312);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "QuestionnaireAnalysisReportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar relatório análise de questionário";
            this.Load += new System.EventHandler(this.QuestionnaireAnalysisReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker tbxDtf;
        private System.Windows.Forms.DateTimePicker tbxDti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnQuit;
        public System.Windows.Forms.TextBox tbxIdCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTypeCrm;
        private System.Windows.Forms.Label label4;
    }
}