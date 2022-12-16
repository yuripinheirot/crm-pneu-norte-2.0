namespace project.presentation.forms.questionnaireAnalysis
{
    partial class questionnaireAnalysisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbxTipoPedido = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPerguntas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRespostas = new System.Windows.Forms.DataGridView();
            this.RESPOSTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnalise = new System.Windows.Forms.DataGridView();
            this.analysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDti = new System.Windows.Forms.DateTimePicker();
            this.tbxDtf = new System.Windows.Forms.DateTimePicker();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FANTASIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACOES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespostas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(768, 573);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 30);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // cbxTipoPedido
            // 
            this.cbxTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoPedido.FormattingEnabled = true;
            this.cbxTipoPedido.Items.AddRange(new object[] {
            "VENDAS",
            "SERVIÇOS"});
            this.cbxTipoPedido.Location = new System.Drawing.Point(140, 30);
            this.cbxTipoPedido.Name = "cbxTipoPedido";
            this.cbxTipoPedido.Size = new System.Drawing.Size(576, 28);
            this.cbxTipoPedido.TabIndex = 1;
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
            // cbxPerguntas
            // 
            this.cbxPerguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPerguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPerguntas.FormattingEnabled = true;
            this.cbxPerguntas.Location = new System.Drawing.Point(140, 87);
            this.cbxPerguntas.Name = "cbxPerguntas";
            this.cbxPerguntas.Size = new System.Drawing.Size(576, 28);
            this.cbxPerguntas.TabIndex = 3;
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
            // dgvRespostas
            // 
            this.dgvRespostas.AllowUserToAddRows = false;
            this.dgvRespostas.AllowUserToDeleteRows = false;
            this.dgvRespostas.AllowUserToOrderColumns = true;
            this.dgvRespostas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRespostas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRespostas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRespostas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RESPOSTA,
            this.QTD});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRespostas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRespostas.Location = new System.Drawing.Point(16, 151);
            this.dgvRespostas.MultiSelect = false;
            this.dgvRespostas.Name = "dgvRespostas";
            this.dgvRespostas.ReadOnly = true;
            this.dgvRespostas.RowHeadersWidth = 4;
            this.dgvRespostas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRespostas.Size = new System.Drawing.Size(835, 153);
            this.dgvRespostas.StandardTab = true;
            this.dgvRespostas.TabIndex = 5;
            // 
            // RESPOSTA
            // 
            this.RESPOSTA.DataPropertyName = "RESPOSTA";
            this.RESPOSTA.HeaderText = "RESPOSTA";
            this.RESPOSTA.Name = "RESPOSTA";
            this.RESPOSTA.ReadOnly = true;
            this.RESPOSTA.Width = 750;
            // 
            // QTD
            // 
            this.QTD.DataPropertyName = "QTD";
            this.QTD.HeaderText = "QTD";
            this.QTD.Name = "QTD";
            this.QTD.ReadOnly = true;
            this.QTD.Width = 60;
            // 
            // dgvAnalise
            // 
            this.dgvAnalise.AllowUserToAddRows = false;
            this.dgvAnalise.AllowUserToDeleteRows = false;
            this.dgvAnalise.AllowUserToOrderColumns = true;
            this.dgvAnalise.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnalise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAnalise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME,
            this.FANTASIA,
            this.PEDIDO,
            this.OBSERVACOES});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnalise.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAnalise.Location = new System.Drawing.Point(16, 333);
            this.dgvAnalise.MultiSelect = false;
            this.dgvAnalise.Name = "dgvAnalise";
            this.dgvAnalise.ReadOnly = true;
            this.dgvAnalise.RowHeadersWidth = 24;
            this.dgvAnalise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnalise.Size = new System.Drawing.Size(835, 186);
            this.dgvAnalise.StandardTab = true;
            this.dgvAnalise.TabIndex = 6;
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
            this.btnSearch.Location = new System.Drawing.Point(722, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 85);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.tbxDtf.TabIndex = 2;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CLIENTE";
            this.CODIGO.HeaderText = "CLIENTE";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 60;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "RAZÃO";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 250;
            // 
            // FANTASIA
            // 
            this.FANTASIA.DataPropertyName = "FANTASIA";
            this.FANTASIA.HeaderText = "FANTASIA";
            this.FANTASIA.Name = "FANTASIA";
            this.FANTASIA.ReadOnly = true;
            this.FANTASIA.Width = 250;
            // 
            // PEDIDO
            // 
            this.PEDIDO.DataPropertyName = "PEDIDO";
            this.PEDIDO.HeaderText = "PEDIDO";
            this.PEDIDO.Name = "PEDIDO";
            this.PEDIDO.ReadOnly = true;
            this.PEDIDO.Width = 80;
            // 
            // OBSERVACOES
            // 
            this.OBSERVACOES.DataPropertyName = "observacoes";
            this.OBSERVACOES.HeaderText = "OBSERVAÇÕES";
            this.OBSERVACOES.Name = "OBSERVACOES";
            this.OBSERVACOES.ReadOnly = true;
            this.OBSERVACOES.Width = 400;
            // 
            // frmAnaliseDePerguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(865, 611);
            this.Controls.Add(this.tbxDtf);
            this.Controls.Add(this.tbxDti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvAnalise);
            this.Controls.Add(this.dgvRespostas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPerguntas);
            this.Controls.Add(this.cbxTipoPedido);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAnaliseDePerguntas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análise de questionário";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespostas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbxTipoPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPerguntas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRespostas;
        private System.Windows.Forms.DataGridView dgvAnalise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource analysisBindingSource;
        private System.Windows.Forms.DateTimePicker tbxDti;
        private System.Windows.Forms.DateTimePicker tbxDtf;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESPOSTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FANTASIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACOES;
    }
}