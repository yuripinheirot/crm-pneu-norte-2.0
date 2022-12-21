namespace project.presentation.forms.crmNotResolved
{
    partial class CrmNotResolved
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvNotResolved = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.respostasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotResolved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respostasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1039, 408);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 30);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(950, 408);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 30);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvNotResolved
            // 
            this.dgvNotResolved.AllowUserToAddRows = false;
            this.dgvNotResolved.AllowUserToDeleteRows = false;
            this.dgvNotResolved.AllowUserToOrderColumns = true;
            this.dgvNotResolved.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotResolved.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotResolved.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotResolved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotResolved.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAnswer,
            this.idCompany,
            this.idSale,
            this.idClient,
            this.descriptionQuestion,
            this.answer,
            this.observation,
            this.resolution});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotResolved.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotResolved.Location = new System.Drawing.Point(13, 13);
            this.dgvNotResolved.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNotResolved.MultiSelect = false;
            this.dgvNotResolved.Name = "dgvNotResolved";
            this.dgvNotResolved.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotResolved.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotResolved.RowHeadersWidth = 24;
            this.dgvNotResolved.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotResolved.Size = new System.Drawing.Size(1109, 361);
            this.dgvNotResolved.StandardTab = true;
            this.dgvNotResolved.TabIndex = 8;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            // 
            // idAnswer
            // 
            this.idAnswer.DataPropertyName = "idAnswer";
            this.idAnswer.HeaderText = "idQuestion";
            this.idAnswer.Name = "idAnswer";
            this.idAnswer.ReadOnly = true;
            this.idAnswer.Visible = false;
            // 
            // idCompany
            // 
            this.idCompany.DataPropertyName = "idCompany";
            this.idCompany.HeaderText = "EMPRESA";
            this.idCompany.Name = "idCompany";
            this.idCompany.ReadOnly = true;
            this.idCompany.Width = 80;
            // 
            // idSale
            // 
            this.idSale.DataPropertyName = "idSale";
            this.idSale.HeaderText = "PEDIDO";
            this.idSale.Name = "idSale";
            this.idSale.ReadOnly = true;
            this.idSale.Width = 80;
            // 
            // idClient
            // 
            this.idClient.DataPropertyName = "idClient";
            this.idClient.HeaderText = "CLIENTE";
            this.idClient.Name = "idClient";
            this.idClient.ReadOnly = true;
            this.idClient.Width = 60;
            // 
            // descriptionQuestion
            // 
            this.descriptionQuestion.DataPropertyName = "descriptionQuestion";
            this.descriptionQuestion.HeaderText = "PERGUNTA";
            this.descriptionQuestion.Name = "descriptionQuestion";
            this.descriptionQuestion.ReadOnly = true;
            this.descriptionQuestion.Width = 200;
            // 
            // answer
            // 
            this.answer.DataPropertyName = "answer";
            this.answer.HeaderText = "RESPOSTA";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Width = 180;
            // 
            // observation
            // 
            this.observation.DataPropertyName = "observation";
            this.observation.HeaderText = "OBSERVAÇÃO";
            this.observation.Name = "observation";
            this.observation.ReadOnly = true;
            this.observation.Width = 230;
            // 
            // resolution
            // 
            this.resolution.DataPropertyName = "resolution";
            this.resolution.HeaderText = "RESOLUÇÃO";
            this.resolution.Name = "resolution";
            this.resolution.ReadOnly = true;
            this.resolution.Width = 230;
            // 
            // CrmNotResolved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.dgvNotResolved);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CrmNotResolved";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questionários não resolvidos";
            this.Load += new System.EventHandler(this.CrmNotResolved_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotResolved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respostasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.BindingSource respostasBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        public System.Windows.Forms.DataGridView dgvNotResolved;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn observation;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolution;
    }
}