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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbxIdSale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxModule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perguntasNãoResolvidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRMsNãoFeitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analiseDeRespostasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxCompany = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.flpQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(746, 531);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 30);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(657, 531);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 30);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbxIdSale
            // 
            this.tbxIdSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdSale.Location = new System.Drawing.Point(16, 50);
            this.tbxIdSale.Name = "tbxIdSale";
            this.tbxIdSale.Size = new System.Drawing.Size(82, 26);
            this.tbxIdSale.TabIndex = 0;
            this.tbxIdSale.Text = "0000300";
            this.tbxIdSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedido";
            // 
            // tbxClientName
            // 
            this.tbxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClientName.Location = new System.Drawing.Point(192, 50);
            this.tbxClientName.Name = "tbxClientName";
            this.tbxClientName.ReadOnly = true;
            this.tbxClientName.Size = new System.Drawing.Size(457, 26);
            this.tbxClientName.TabIndex = 2;
            this.tbxClientName.TabStop = false;
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
            // tbxSaleType
            // 
            this.tbxModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModule.Location = new System.Drawing.Point(655, 50);
            this.tbxModule.Name = "tbxSaleType";
            this.tbxModule.ReadOnly = true;
            this.tbxModule.Size = new System.Drawing.Size(174, 26);
            this.tbxModule.TabIndex = 3;
            this.tbxModule.TabStop = false;
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesquisasToolStripMenuItem
            // 
            this.pesquisasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perguntasNãoResolvidasToolStripMenuItem,
            this.cRMsNãoFeitosToolStripMenuItem});
            this.pesquisasToolStripMenuItem.Name = "pesquisasToolStripMenuItem";
            this.pesquisasToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.pesquisasToolStripMenuItem.Text = "Pesquisas";
            // 
            // perguntasNãoResolvidasToolStripMenuItem
            // 
            this.perguntasNãoResolvidasToolStripMenuItem.Name = "perguntasNãoResolvidasToolStripMenuItem";
            this.perguntasNãoResolvidasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.perguntasNãoResolvidasToolStripMenuItem.Text = "Questionários não resolvidos";
            // 
            // cRMsNãoFeitosToolStripMenuItem
            // 
            this.cRMsNãoFeitosToolStripMenuItem.Name = "cRMsNãoFeitosToolStripMenuItem";
            this.cRMsNãoFeitosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cRMsNãoFeitosToolStripMenuItem.Text = "CRM\'s pendentes";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analiseDeRespostasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // analiseDeRespostasToolStripMenuItem
            // 
            this.analiseDeRespostasToolStripMenuItem.Name = "analiseDeRespostasToolStripMenuItem";
            this.analiseDeRespostasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.analiseDeRespostasToolStripMenuItem.Text = "Análise de questionário";
            // 
            // tbxCompany
            // 
            this.tbxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCompany.Location = new System.Drawing.Point(104, 50);
            this.tbxCompany.MaxLength = 2;
            this.tbxCompany.Name = "tbxCompany";
            this.tbxCompany.Size = new System.Drawing.Size(82, 26);
            this.tbxCompany.TabIndex = 1;
            this.tbxCompany.Text = "01";
            this.tbxCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(100, 27);
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
            this.flpQuestions.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(841, 573);
            this.Controls.Add(this.flpQuestions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxClientName);
            this.Controls.Add(this.tbxModule);
            this.Controls.Add(this.tbxCompany);
            this.Controls.Add(this.tbxIdSale);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
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

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesquisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perguntasNãoResolvidasToolStripMenuItem;
        public System.Windows.Forms.TextBox tbxIdSale;
        public System.Windows.Forms.TextBox tbxClientName;
        public System.Windows.Forms.TextBox tbxModule;
        private System.Windows.Forms.ToolStripMenuItem cRMsNãoFeitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analiseDeRespostasToolStripMenuItem;
        public System.Windows.Forms.TextBox tbxCompany;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel flpQuestions;
    }
}

