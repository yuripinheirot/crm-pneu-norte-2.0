namespace project.presentation.forms.questionnaireAnalysis
{
    partial class QuestionnaireAnalysisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbxPosSale = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxQuestions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAnswers = new System.Windows.Forms.DataGridView();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnalysis = new System.Windows.Forms.DataGridView();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameFantasy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDti = new System.Windows.Forms.DateTimePicker();
            this.tbxDtf = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxIdCompany = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(768, 573);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 30);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // cbxPosSale
            // 
            this.cbxPosSale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPosSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPosSale.FormattingEnabled = true;
            this.cbxPosSale.Items.AddRange(new object[] {
            "VENDAS",
            "SERVIÇOS"});
            this.cbxPosSale.Location = new System.Drawing.Point(140, 30);
            this.cbxPosSale.Name = "cbxPosSale";
            this.cbxPosSale.Size = new System.Drawing.Size(576, 28);
            this.cbxPosSale.TabIndex = 2;
            this.cbxPosSale.SelectedIndexChanged += new System.EventHandler(this.cbxPosSale_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pós venda";
            // 
            // cbxQuestions
            // 
            this.cbxQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuestions.FormattingEnabled = true;
            this.cbxQuestions.Location = new System.Drawing.Point(140, 87);
            this.cbxQuestions.Name = "cbxQuestions";
            this.cbxQuestions.Size = new System.Drawing.Size(576, 28);
            this.cbxQuestions.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pergunta";
            // 
            // dgvAnswers
            // 
            this.dgvAnswers.AllowUserToAddRows = false;
            this.dgvAnswers.AllowUserToDeleteRows = false;
            this.dgvAnswers.AllowUserToOrderColumns = true;
            this.dgvAnswers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnswers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnswers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.answer,
            this.count});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnswers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnswers.Location = new System.Drawing.Point(16, 151);
            this.dgvAnswers.MultiSelect = false;
            this.dgvAnswers.Name = "dgvAnswers";
            this.dgvAnswers.ReadOnly = true;
            this.dgvAnswers.RowHeadersWidth = 4;
            this.dgvAnswers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnswers.Size = new System.Drawing.Size(835, 153);
            this.dgvAnswers.StandardTab = true;
            this.dgvAnswers.TabIndex = 6;
            this.dgvAnswers.DataSourceChanged += new System.EventHandler(this.dgvAnswers_DataSourceChanged);
            this.dgvAnswers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnswers_CellEnter);
            // 
            // answer
            // 
            this.answer.DataPropertyName = "answer";
            this.answer.HeaderText = "RESPOSTA";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Width = 750;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "QTD";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 60;
            // 
            // dgvAnalysis
            // 
            this.dgvAnalysis.AllowUserToAddRows = false;
            this.dgvAnalysis.AllowUserToDeleteRows = false;
            this.dgvAnalysis.AllowUserToOrderColumns = true;
            this.dgvAnalysis.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnalysis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClient,
            this.clientName,
            this.clientNameFantasy,
            this.idSale,
            this.observation});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnalysis.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAnalysis.Location = new System.Drawing.Point(16, 333);
            this.dgvAnalysis.MultiSelect = false;
            this.dgvAnalysis.Name = "dgvAnalysis";
            this.dgvAnalysis.ReadOnly = true;
            this.dgvAnalysis.RowHeadersWidth = 24;
            this.dgvAnalysis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnalysis.Size = new System.Drawing.Size(835, 186);
            this.dgvAnalysis.StandardTab = true;
            this.dgvAnalysis.TabIndex = 7;
            // 
            // idClient
            // 
            this.idClient.DataPropertyName = "idClient";
            this.idClient.HeaderText = "CLIENTE";
            this.idClient.Name = "idClient";
            this.idClient.ReadOnly = true;
            this.idClient.Width = 60;
            // 
            // clientName
            // 
            this.clientName.DataPropertyName = "clientName";
            this.clientName.HeaderText = "RAZÃO";
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            this.clientName.Width = 250;
            // 
            // clientNameFantasy
            // 
            this.clientNameFantasy.DataPropertyName = "clientNameFantasy";
            this.clientNameFantasy.HeaderText = "FANTASIA";
            this.clientNameFantasy.Name = "clientNameFantasy";
            this.clientNameFantasy.ReadOnly = true;
            this.clientNameFantasy.Width = 250;
            // 
            // idSale
            // 
            this.idSale.DataPropertyName = "idSale";
            this.idSale.HeaderText = "PEDIDO";
            this.idSale.Name = "idSale";
            this.idSale.ReadOnly = true;
            this.idSale.Width = 80;
            // 
            // observation
            // 
            this.observation.DataPropertyName = "observation";
            this.observation.HeaderText = "OBSERVAÇÕES";
            this.observation.Name = "observation";
            this.observation.ReadOnly = true;
            this.observation.Width = 400;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Respostas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Análise";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(722, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 51);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data inicial";
            // 
            // tbxDti
            // 
            this.tbxDti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDti.Location = new System.Drawing.Point(16, 32);
            this.tbxDti.Name = "tbxDti";
            this.tbxDti.Size = new System.Drawing.Size(118, 26);
            this.tbxDti.TabIndex = 0;
            // 
            // tbxDtf
            // 
            this.tbxDtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDtf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDtf.Location = new System.Drawing.Point(16, 87);
            this.tbxDtf.Name = "tbxDtf";
            this.tbxDtf.Size = new System.Drawing.Size(118, 26);
            this.tbxDtf.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(718, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Empresa";
            // 
            // tbxIdCompany
            // 
            this.tbxIdCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdCompany.Location = new System.Drawing.Point(722, 30);
            this.tbxIdCompany.MaxLength = 2;
            this.tbxIdCompany.Name = "tbxIdCompany";
            this.tbxIdCompany.Size = new System.Drawing.Size(129, 26);
            this.tbxIdCompany.TabIndex = 4;
            this.tbxIdCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxIdCompany.Leave += new System.EventHandler(this.tbxIdCompany_Leave);
            // 
            // QuestionnaireAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(865, 611);
            this.Controls.Add(this.tbxIdCompany);
            this.Controls.Add(this.tbxDtf);
            this.Controls.Add(this.tbxDti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvAnalysis);
            this.Controls.Add(this.dgvAnswers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxQuestions);
            this.Controls.Add(this.cbxPosSale);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "QuestionnaireAnalysisForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análise de questionário";
            this.Load += new System.EventHandler(this.QuestionnaireAnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbxPosSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAnswers;
        private System.Windows.Forms.DataGridView dgvAnalysis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tbxDti;
        private System.Windows.Forms.DateTimePicker tbxDtf;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameFantasy;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn observation;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbxIdCompany;
    }
}