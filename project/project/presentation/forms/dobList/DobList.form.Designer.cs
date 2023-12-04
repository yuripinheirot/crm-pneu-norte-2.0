namespace project.presentation.forms.dobList
{
    partial class DobListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new FastReport.DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.isDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFantasy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.phone,
            this.dob,
            this.isDone,
            this.CPFCNPJ,
            this.nameFantasy,
            this.observations});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.Location = new System.Drawing.Point(12, 70);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 24;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(621, 294);
            this.dgvClients.StandardTab = true;
            this.dgvClients.TabIndex = 3;
            this.dgvClients.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvClients_KeyDown);
            // 
            // dtpDob
            // 
            this.dtpDob.CustomFormat = "dd/MM";
            this.dtpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(12, 35);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(92, 26);
            this.dtpDob.TabIndex = 4;
            this.dtpDob.ValueChanged += new System.EventHandler(this.dtpDob_ValueChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(461, 408);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(83, 30);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "&Editar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(550, 408);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(83, 30);
            this.btnQuit.TabIndex = 18;
            this.btnQuit.Text = "Sai&r";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "CÓDIGO";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "RAZÃO";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "TELEFONE";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // dob
            // 
            // 
            // 
            // 
            this.dob.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.dob.BackgroundStyle.CornerType = FastReport.DevComponents.DotNetBar.eCornerType.Square;
            this.dob.BackgroundStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dob.DataPropertyName = "dob";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.dob.DefaultCellStyle = dataGridViewCellStyle2;
            this.dob.HeaderText = "DATA NASC.";
            this.dob.InputHorizontalAlignment = FastReport.DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.dob.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dob.MonthCalendar.BackgroundStyle.CornerType = FastReport.DevComponents.DotNetBar.eCornerType.Square;
            this.dob.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.dob.MonthCalendar.CommandsBackgroundStyle.CornerType = FastReport.DevComponents.DotNetBar.eCornerType.Square;
            this.dob.MonthCalendar.DisplayMonth = new System.DateTime(2023, 11, 1, 0, 0, 0, 0);
            this.dob.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dob.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dob.MonthCalendar.NavigationBackgroundStyle.CornerType = FastReport.DevComponents.DotNetBar.eCornerType.Square;
            this.dob.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dob.Width = 120;
            // 
            // isDone
            // 
            this.isDone.DataPropertyName = "isDone";
            this.isDone.HeaderText = "✔";
            this.isDone.Name = "isDone";
            this.isDone.ReadOnly = true;
            this.isDone.Width = 40;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.DataPropertyName = "cpfCnpj";
            this.CPFCNPJ.HeaderText = "CPF/CNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            this.CPFCNPJ.ReadOnly = true;
            this.CPFCNPJ.Visible = false;
            // 
            // nameFantasy
            // 
            this.nameFantasy.DataPropertyName = "nameFantasy";
            this.nameFantasy.HeaderText = "FANTASIA";
            this.nameFantasy.Name = "nameFantasy";
            this.nameFantasy.ReadOnly = true;
            this.nameFantasy.Visible = false;
            this.nameFantasy.Width = 250;
            // 
            // observations
            // 
            this.observations.HeaderText = "observations";
            this.observations.Name = "observations";
            this.observations.ReadOnly = true;
            this.observations.Visible = false;
            // 
            // DobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.dgvClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DobList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar relatório análise de questionário";
            this.Load += new System.EventHandler(this.DobList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private FastReport.DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn dob;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFantasy;
        private System.Windows.Forms.DataGridViewTextBoxColumn observations;
    }
}