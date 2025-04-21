namespace project.presentation.forms.crmPending
{
    partial class CrmPending
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvCrmsPendentes = new System.Windows.Forms.DataGridView();
            this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATAPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORLIQUIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCrmsPendentes = new System.Windows.Forms.Label();
            this.tbxDti = new System.Windows.Forms.DateTimePicker();
            this.tbxDtf = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrmsPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(837, 450);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 30);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(748, 450);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 30);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Inserir";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dgvCrmsPendentes
            // 
            this.dgvCrmsPendentes.AllowUserToAddRows = false;
            this.dgvCrmsPendentes.AllowUserToDeleteRows = false;
            this.dgvCrmsPendentes.AllowUserToOrderColumns = true;
            this.dgvCrmsPendentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCrmsPendentes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCrmsPendentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCrmsPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrmsPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMPRESA,
            this.PEDIDO,
            this.CLIENTE,
            this.POSVENDA,
            this.DATAPEDIDO,
            this.VALORLIQUIDO});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCrmsPendentes.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCrmsPendentes.Location = new System.Drawing.Point(13, 88);
            this.dgvCrmsPendentes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCrmsPendentes.MultiSelect = false;
            this.dgvCrmsPendentes.Name = "dgvCrmsPendentes";
            this.dgvCrmsPendentes.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCrmsPendentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCrmsPendentes.RowHeadersWidth = 24;
            this.dgvCrmsPendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCrmsPendentes.Size = new System.Drawing.Size(907, 343);
            this.dgvCrmsPendentes.StandardTab = true;
            this.dgvCrmsPendentes.TabIndex = 3;
            // 
            // EMPRESA
            // 
            this.EMPRESA.DataPropertyName = "EMPRESA";
            this.EMPRESA.HeaderText = "EMPRESA";
            this.EMPRESA.Name = "EMPRESA";
            this.EMPRESA.ReadOnly = true;
            this.EMPRESA.Width = 65;
            // 
            // PEDIDO
            // 
            this.PEDIDO.DataPropertyName = "PEDIDO";
            this.PEDIDO.HeaderText = "PEDIDO";
            this.PEDIDO.Name = "PEDIDO";
            this.PEDIDO.ReadOnly = true;
            this.PEDIDO.Width = 65;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle7;
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.Width = 400;
            // 
            // POSVENDA
            // 
            this.POSVENDA.DataPropertyName = "POSVENDA";
            this.POSVENDA.HeaderText = "PÓS VENDA";
            this.POSVENDA.Name = "POSVENDA";
            this.POSVENDA.ReadOnly = true;
            this.POSVENDA.Width = 130;
            // 
            // DATAPEDIDO
            // 
            this.DATAPEDIDO.DataPropertyName = "DATAPEDIDO";
            this.DATAPEDIDO.HeaderText = "DATA PED.";
            this.DATAPEDIDO.Name = "DATAPEDIDO";
            this.DATAPEDIDO.ReadOnly = true;
            // 
            // VALORLIQUIDO
            // 
            this.VALORLIQUIDO.DataPropertyName = "VALORLIQUIDO";
            dataGridViewCellStyle8.Format = "N2";
            this.VALORLIQUIDO.DefaultCellStyle = dataGridViewCellStyle8;
            this.VALORLIQUIDO.HeaderText = "VALOR LIQ.";
            this.VALORLIQUIDO.Name = "VALORLIQUIDO";
            this.VALORLIQUIDO.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data inicial";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(260, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblCrmsPendentes
            // 
            this.lblCrmsPendentes.AutoSize = true;
            this.lblCrmsPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrmsPendentes.Location = new System.Drawing.Point(9, 64);
            this.lblCrmsPendentes.Name = "lblCrmsPendentes";
            this.lblCrmsPendentes.Size = new System.Drawing.Size(153, 20);
            this.lblCrmsPendentes.TabIndex = 10;
            this.lblCrmsPendentes.Text = "CRM\'s pendentes: 0";
            // 
            // tbxDti
            // 
            this.tbxDti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDti.Location = new System.Drawing.Point(12, 27);
            this.tbxDti.Name = "tbxDti";
            this.tbxDti.Size = new System.Drawing.Size(118, 26);
            this.tbxDti.TabIndex = 0;
            // 
            // tbxDtf
            // 
            this.tbxDtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDtf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDtf.Location = new System.Drawing.Point(136, 27);
            this.tbxDtf.Name = "tbxDtf";
            this.tbxDtf.Size = new System.Drawing.Size(118, 26);
            this.tbxDtf.TabIndex = 1;
            // 
            // CrmPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(933, 492);
            this.Controls.Add(this.tbxDtf);
            this.Controls.Add(this.tbxDti);
            this.Controls.Add(this.lblCrmsPendentes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvCrmsPendentes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CrmPending";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM\'s Pendentes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrmsPendentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.DataGridView dgvCrmsPendentes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCrmsPendentes;
        private System.Windows.Forms.DateTimePicker tbxDti;
        private System.Windows.Forms.DateTimePicker tbxDtf;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATAPEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORLIQUIDO;
    }
}