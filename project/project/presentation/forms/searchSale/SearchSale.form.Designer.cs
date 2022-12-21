namespace project.presentation.forms.searchSale
{
    partial class SearchSaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxClientId = new System.Windows.Forms.TextBox();
            this.tbxClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.idCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liquidValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxTypeCrm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberSales = new System.Windows.Forms.Label();
            this.tbxDti = new System.Windows.Forms.DateTimePicker();
            this.tbxDtf = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxIdCompany = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(925, 433);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(83, 30);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Sai&r";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(836, 433);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 30);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "&Inserir";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // tbxClientId
            // 
            this.tbxClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClientId.Location = new System.Drawing.Point(92, 31);
            this.tbxClientId.MaxLength = 5;
            this.tbxClientId.Name = "tbxClientId";
            this.tbxClientId.Size = new System.Drawing.Size(64, 26);
            this.tbxClientId.TabIndex = 1;
            this.tbxClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxClientId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxClientId_KeyDown);
            this.tbxClientId.Leave += new System.EventHandler(this.tbxClientId_Leave);
            // 
            // tbxClientName
            // 
            this.tbxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClientName.Location = new System.Drawing.Point(162, 31);
            this.tbxClientName.Name = "tbxClientName";
            this.tbxClientName.ReadOnly = true;
            this.tbxClientName.Size = new System.Drawing.Size(315, 26);
            this.tbxClientName.TabIndex = 2;
            this.tbxClientName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(603, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data final";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToOrderColumns = true;
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompany,
            this.id,
            this.client,
            this.liquidValue,
            this.dateSale,
            this.clientCpfCnpj,
            this.posSale});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSales.Location = new System.Drawing.Point(16, 84);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidth = 24;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(992, 325);
            this.dgvSales.StandardTab = true;
            this.dgvSales.TabIndex = 7;
            this.dgvSales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPedidos_KeyDown);
            // 
            // idCompany
            // 
            this.idCompany.DataPropertyName = "idCompany";
            this.idCompany.HeaderText = "EMPRESA";
            this.idCompany.MinimumWidth = 6;
            this.idCompany.Name = "idCompany";
            this.idCompany.ReadOnly = true;
            this.idCompany.Width = 65;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "PEDIDO";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 65;
            // 
            // client
            // 
            this.client.DataPropertyName = "client";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.client.DefaultCellStyle = dataGridViewCellStyle2;
            this.client.HeaderText = "CLIENTE";
            this.client.MinimumWidth = 6;
            this.client.Name = "client";
            this.client.ReadOnly = true;
            this.client.Width = 415;
            // 
            // liquidValue
            // 
            this.liquidValue.DataPropertyName = "liquidValue";
            dataGridViewCellStyle3.Format = "N2";
            this.liquidValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.liquidValue.HeaderText = "VALOR LIQ.";
            this.liquidValue.MinimumWidth = 6;
            this.liquidValue.Name = "liquidValue";
            this.liquidValue.ReadOnly = true;
            this.liquidValue.Width = 125;
            // 
            // dateSale
            // 
            this.dateSale.DataPropertyName = "dateSale";
            this.dateSale.HeaderText = "DATA PED.";
            this.dateSale.MinimumWidth = 6;
            this.dateSale.Name = "dateSale";
            this.dateSale.ReadOnly = true;
            this.dateSale.Width = 125;
            // 
            // clientCpfCnpj
            // 
            this.clientCpfCnpj.DataPropertyName = "clientCpfCnpj";
            this.clientCpfCnpj.HeaderText = "CPF/CNPJ";
            this.clientCpfCnpj.MinimumWidth = 6;
            this.clientCpfCnpj.Name = "clientCpfCnpj";
            this.clientCpfCnpj.ReadOnly = true;
            this.clientCpfCnpj.Width = 125;
            // 
            // posSale
            // 
            this.posSale.DataPropertyName = "posSale";
            this.posSale.HeaderText = "PÓS VENDA";
            this.posSale.MinimumWidth = 6;
            this.posSale.Name = "posSale";
            this.posSale.ReadOnly = true;
            this.posSale.Width = 125;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(909, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "&Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.cbxTypeCrm.Location = new System.Drawing.Point(731, 31);
            this.cbxTypeCrm.Name = "cbxTypeCrm";
            this.cbxTypeCrm.Size = new System.Drawing.Size(172, 26);
            this.cbxTypeCrm.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(727, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pós venda";
            // 
            // lblNumberSales
            // 
            this.lblNumberSales.AutoSize = true;
            this.lblNumberSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberSales.Location = new System.Drawing.Point(12, 61);
            this.lblNumberSales.Name = "lblNumberSales";
            this.lblNumberSales.Size = new System.Drawing.Size(176, 20);
            this.lblNumberSales.TabIndex = 1;
            this.lblNumberSales.Text = "Pedidos encontrados: 0";
            // 
            // tbxDti
            // 
            this.tbxDti.Checked = false;
            this.tbxDti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDti.Location = new System.Drawing.Point(483, 31);
            this.tbxDti.Name = "tbxDti";
            this.tbxDti.Size = new System.Drawing.Size(118, 26);
            this.tbxDti.TabIndex = 3;
            // 
            // tbxDtf
            // 
            this.tbxDtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDtf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDtf.Location = new System.Drawing.Point(607, 31);
            this.tbxDtf.Name = "tbxDtf";
            this.tbxDtf.Size = new System.Drawing.Size(118, 26);
            this.tbxDtf.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Empresa";
            // 
            // tbxIdCompany
            // 
            this.tbxIdCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdCompany.Location = new System.Drawing.Point(16, 31);
            this.tbxIdCompany.MaxLength = 2;
            this.tbxIdCompany.Name = "tbxIdCompany";
            this.tbxIdCompany.Size = new System.Drawing.Size(70, 26);
            this.tbxIdCompany.TabIndex = 0;
            this.tbxIdCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchSaleForm
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(1030, 474);
            this.Controls.Add(this.tbxDtf);
            this.Controls.Add(this.tbxDti);
            this.Controls.Add(this.cbxTypeCrm);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.tbxClientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxIdCompany);
            this.Controls.Add(this.tbxClientId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumberSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SearchSaleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar pedidos";
            this.Load += new System.EventHandler(this.SearchSale_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchSaleForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox tbxClientId;
        public System.Windows.Forms.TextBox tbxClientName;
        private System.Windows.Forms.ComboBox cbxTypeCrm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberSales;
        private System.Windows.Forms.DateTimePicker tbxDti;
        private System.Windows.Forms.DateTimePicker tbxDtf;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbxIdCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn liquidValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn posSale;
    }
}