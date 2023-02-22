using project.validations;

namespace project.presentation.forms.main
{
    partial class MainForm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TbxIdSale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPosSale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crmNotResolvedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRMsNãoFeitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.análiseDeQuestionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analiseDeRespostasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxIdCompany = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.flpQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.análiseDeQuestionáriográficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(746, 531);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(83, 30);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Sai&r";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(657, 531);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 30);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "&Salvar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TbxIdSale
            // 
            this.TbxIdSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxIdSale.Location = new System.Drawing.Point(104, 50);
            this.TbxIdSale.MaxLength = 7;
            this.TbxIdSale.Name = "TbxIdSale";
            this.TbxIdSale.Size = new System.Drawing.Size(82, 26);
            this.TbxIdSale.TabIndex = 1;
            this.TbxIdSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxIdSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxIdSale_KeyDown);
            this.TbxIdSale.Leave += new System.EventHandler(this.TbxIdSale_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedido";
            // 
            // TbxClientName
            // 
            this.TbxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxClientName.Location = new System.Drawing.Point(192, 50);
            this.TbxClientName.Name = "TbxClientName";
            this.TbxClientName.ReadOnly = true;
            this.TbxClientName.Size = new System.Drawing.Size(457, 26);
            this.TbxClientName.TabIndex = 2;
            this.TbxClientName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // tbxPosSale
            // 
            this.tbxPosSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPosSale.Location = new System.Drawing.Point(655, 50);
            this.tbxPosSale.Name = "tbxPosSale";
            this.tbxPosSale.ReadOnly = true;
            this.tbxPosSale.Size = new System.Drawing.Size(174, 26);
            this.tbxPosSale.TabIndex = 3;
            this.tbxPosSale.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo pedido";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesquisasToolStripMenuItem
            // 
            this.pesquisasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crmNotResolvedToolStripMenuItem,
            this.cRMsNãoFeitosToolStripMenuItem,
            this.análiseDeQuestionárioToolStripMenuItem});
            this.pesquisasToolStripMenuItem.Name = "pesquisasToolStripMenuItem";
            this.pesquisasToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.pesquisasToolStripMenuItem.Text = "Pesquisas";
            // 
            // crmNotResolvedToolStripMenuItem
            // 
            this.crmNotResolvedToolStripMenuItem.Name = "crmNotResolvedToolStripMenuItem";
            this.crmNotResolvedToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.crmNotResolvedToolStripMenuItem.Text = "Questionários não resolvidos";
            this.crmNotResolvedToolStripMenuItem.Click += new System.EventHandler(this.crmNotResolvedToolStripMenuItem_Click);
            // 
            // cRMsNãoFeitosToolStripMenuItem
            // 
            this.cRMsNãoFeitosToolStripMenuItem.Name = "cRMsNãoFeitosToolStripMenuItem";
            this.cRMsNãoFeitosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cRMsNãoFeitosToolStripMenuItem.Text = "CRM\'s pendentes";
            // 
            // análiseDeQuestionárioToolStripMenuItem
            // 
            this.análiseDeQuestionárioToolStripMenuItem.Name = "análiseDeQuestionárioToolStripMenuItem";
            this.análiseDeQuestionárioToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.análiseDeQuestionárioToolStripMenuItem.Text = "Análise de questionário";
            this.análiseDeQuestionárioToolStripMenuItem.Click += new System.EventHandler(this.analiseDeQuestionarioToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analiseDeRespostasToolStripMenuItem,
            this.análiseDeQuestionáriográficoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // analiseDeRespostasToolStripMenuItem
            // 
            this.analiseDeRespostasToolStripMenuItem.Name = "analiseDeRespostasToolStripMenuItem";
            this.analiseDeRespostasToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.analiseDeRespostasToolStripMenuItem.Text = "Análise de questionário";
            this.analiseDeRespostasToolStripMenuItem.Click += new System.EventHandler(this.analiseDeRespostasToolStripMenuItem_Click);
            // 
            // TbxIdCompany
            // 
            this.TbxIdCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxIdCompany.Location = new System.Drawing.Point(16, 50);
            this.TbxIdCompany.MaxLength = 2;
            this.TbxIdCompany.Name = "TbxIdCompany";
            this.TbxIdCompany.Size = new System.Drawing.Size(82, 26);
            this.TbxIdCompany.TabIndex = 0;
            this.TbxIdCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxIdCompany.Leave += new System.EventHandler(this.TbxIdCompany_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Empresa";
            // 
            // flpQuestions
            // 
            this.flpQuestions.AutoScroll = true;
            this.flpQuestions.Location = new System.Drawing.Point(16, 82);
            this.flpQuestions.Name = "flpQuestions";
            this.flpQuestions.Size = new System.Drawing.Size(813, 427);
            this.flpQuestions.TabIndex = 4;
            // 
            // análiseDeQuestionáriográficoToolStripMenuItem
            // 
            this.análiseDeQuestionáriográficoToolStripMenuItem.Name = "análiseDeQuestionáriográficoToolStripMenuItem";
            this.análiseDeQuestionáriográficoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.análiseDeQuestionáriográficoToolStripMenuItem.Text = "Análise de questionário (gráfico)";
            this.análiseDeQuestionáriográficoToolStripMenuItem.Click += new System.EventHandler(this.análiseDeQuestionáriográficoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(841, 573);
            this.Controls.Add(this.flpQuestions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxClientName);
            this.Controls.Add(this.tbxPosSale);
            this.Controls.Add(this.TbxIdCompany);
            this.Controls.Add(this.TbxIdSale);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM PneuNorte";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesquisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crmNotResolvedToolStripMenuItem;
        public System.Windows.Forms.TextBox TbxIdSale;
        public System.Windows.Forms.TextBox TbxClientName;
        public System.Windows.Forms.TextBox tbxPosSale;
        private System.Windows.Forms.ToolStripMenuItem cRMsNãoFeitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analiseDeRespostasToolStripMenuItem;
        public System.Windows.Forms.TextBox TbxIdCompany;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flpQuestions;
        private System.Windows.Forms.ToolStripMenuItem análiseDeQuestionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem análiseDeQuestionáriográficoToolStripMenuItem;
    }
}

