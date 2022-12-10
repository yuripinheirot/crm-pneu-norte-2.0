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
            this.TbxModule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perguntasNãoResolvidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRMsNãoFeitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analiseDeRespostasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxCompany = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.FlpQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(995, 654);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(111, 37);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Text = "Sai&r";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(876, 654);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(111, 37);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "&Salvar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TbxIdSale
            // 
            this.TbxIdSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxIdSale.Location = new System.Drawing.Point(21, 62);
            this.TbxIdSale.Margin = new System.Windows.Forms.Padding(4);
            this.TbxIdSale.Name = "TbxIdSale";
            this.TbxIdSale.Size = new System.Drawing.Size(108, 30);
            this.TbxIdSale.TabIndex = 0;
            this.TbxIdSale.Text = "0000300";
            this.TbxIdSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedido";
            // 
            // TbxClientName
            // 
            this.TbxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxClientName.Location = new System.Drawing.Point(256, 62);
            this.TbxClientName.Margin = new System.Windows.Forms.Padding(4);
            this.TbxClientName.Name = "TbxClientName";
            this.TbxClientName.ReadOnly = true;
            this.TbxClientName.Size = new System.Drawing.Size(608, 30);
            this.TbxClientName.TabIndex = 2;
            this.TbxClientName.TabStop = false;
            this.TbxClientName.Text = "1-CLIENTE SEM NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // TbxModule
            // 
            this.TbxModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxModule.Location = new System.Drawing.Point(873, 62);
            this.TbxModule.Margin = new System.Windows.Forms.Padding(4);
            this.TbxModule.Name = "TbxModule";
            this.TbxModule.ReadOnly = true;
            this.TbxModule.Size = new System.Drawing.Size(231, 30);
            this.TbxModule.TabIndex = 3;
            this.TbxModule.TabStop = false;
            this.TbxModule.Text = "SERVIÇOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(868, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1121, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesquisasToolStripMenuItem
            // 
            this.pesquisasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perguntasNãoResolvidasToolStripMenuItem,
            this.cRMsNãoFeitosToolStripMenuItem});
            this.pesquisasToolStripMenuItem.Name = "pesquisasToolStripMenuItem";
            this.pesquisasToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.pesquisasToolStripMenuItem.Text = "Pesquisas";
            // 
            // perguntasNãoResolvidasToolStripMenuItem
            // 
            this.perguntasNãoResolvidasToolStripMenuItem.Name = "perguntasNãoResolvidasToolStripMenuItem";
            this.perguntasNãoResolvidasToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.perguntasNãoResolvidasToolStripMenuItem.Text = "Questionários não resolvidos";
            // 
            // cRMsNãoFeitosToolStripMenuItem
            // 
            this.cRMsNãoFeitosToolStripMenuItem.Name = "cRMsNãoFeitosToolStripMenuItem";
            this.cRMsNãoFeitosToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.cRMsNãoFeitosToolStripMenuItem.Text = "CRM\'s pendentes";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analiseDeRespostasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // analiseDeRespostasToolStripMenuItem
            // 
            this.analiseDeRespostasToolStripMenuItem.Name = "analiseDeRespostasToolStripMenuItem";
            this.analiseDeRespostasToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.analiseDeRespostasToolStripMenuItem.Text = "Análise de questionário";
            // 
            // TbxCompany
            // 
            this.TbxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCompany.Location = new System.Drawing.Point(139, 62);
            this.TbxCompany.Margin = new System.Windows.Forms.Padding(4);
            this.TbxCompany.MaxLength = 2;
            this.TbxCompany.Name = "TbxCompany";
            this.TbxCompany.Size = new System.Drawing.Size(108, 30);
            this.TbxCompany.TabIndex = 1;
            this.TbxCompany.Text = "01";
            this.TbxCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(133, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Empresa";
            // 
            // FlpQuestions
            // 
            this.FlpQuestions.AutoScroll = true;
            this.FlpQuestions.Location = new System.Drawing.Point(21, 101);
            this.FlpQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.FlpQuestions.Name = "FlpQuestions";
            this.FlpQuestions.Size = new System.Drawing.Size(1084, 526);
            this.FlpQuestions.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(1121, 705);
            this.Controls.Add(this.FlpQuestions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxClientName);
            this.Controls.Add(this.TbxModule);
            this.Controls.Add(this.TbxCompany);
            this.Controls.Add(this.TbxIdSale);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem perguntasNãoResolvidasToolStripMenuItem;
        public System.Windows.Forms.TextBox TbxIdSale;
        public System.Windows.Forms.TextBox TbxClientName;
        public System.Windows.Forms.TextBox TbxModule;
        private System.Windows.Forms.ToolStripMenuItem cRMsNãoFeitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analiseDeRespostasToolStripMenuItem;
        public System.Windows.Forms.TextBox TbxCompany;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel FlpQuestions;
    }
}

