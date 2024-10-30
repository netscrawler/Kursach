namespace KursFront.nurse
{
    partial class NurseMain
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            patientCardViewModelBindingSource = new BindingSource(components);
            procedureCardBindingSource = new BindingSource(components);
            zhalobiBindingSource = new BindingSource(components);
            Pacientt = new DataGridViewTextBoxColumn();
            patientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientSurnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientLastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientBirthdayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientphoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientPhoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientSnilsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            procedureCardIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            procedureNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientCardViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)procedureCardBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zhalobiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(649, 90);
            button1.Name = "button1";
            button1.Size = new Size(139, 72);
            button1.TabIndex = 0;
            button1.Text = "Провести процедуру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(649, 12);
            button2.Name = "button2";
            button2.Size = new Size(139, 72);
            button2.TabIndex = 1;
            button2.Text = "Запись на процедуру";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(649, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 23);
            comboBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Pacientt, patientNameDataGridViewTextBoxColumn, patientSurnameDataGridViewTextBoxColumn, patientLastNameDataGridViewTextBoxColumn, patientEmailDataGridViewTextBoxColumn, patientBirthdayDataGridViewTextBoxColumn, patientphoneDataGridViewTextBoxColumn, patientPhoneNumberDataGridViewTextBoxColumn, patientSnilsDataGridViewTextBoxColumn, procedureCardIdDataGridViewTextBoxColumn, procedureNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = patientCardViewModelBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(631, 426);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // patientCardViewModelBindingSource
            // 
            patientCardViewModelBindingSource.DataSource = typeof(Kursach.PatientCardViewModel);
            // 
            // procedureCardBindingSource
            // 
            procedureCardBindingSource.DataSource = typeof(Kursach.Procedure_Card);
            // 
            // zhalobiBindingSource
            // 
            zhalobiBindingSource.DataMember = "Zhalobi";
            zhalobiBindingSource.DataSource = procedureCardBindingSource;
            // 
            // Pacientt
            // 
            Pacientt.HeaderText = "Pacient";
            Pacientt.Name = "Pacientt";
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // patientSurnameDataGridViewTextBoxColumn
            // 
            patientSurnameDataGridViewTextBoxColumn.DataPropertyName = "PatientSurname";
            patientSurnameDataGridViewTextBoxColumn.HeaderText = "PatientSurname";
            patientSurnameDataGridViewTextBoxColumn.Name = "patientSurnameDataGridViewTextBoxColumn";
            // 
            // patientLastNameDataGridViewTextBoxColumn
            // 
            patientLastNameDataGridViewTextBoxColumn.DataPropertyName = "PatientLastName";
            patientLastNameDataGridViewTextBoxColumn.HeaderText = "PatientLastName";
            patientLastNameDataGridViewTextBoxColumn.Name = "patientLastNameDataGridViewTextBoxColumn";
            // 
            // patientEmailDataGridViewTextBoxColumn
            // 
            patientEmailDataGridViewTextBoxColumn.DataPropertyName = "PatientEmail";
            patientEmailDataGridViewTextBoxColumn.HeaderText = "PatientEmail";
            patientEmailDataGridViewTextBoxColumn.Name = "patientEmailDataGridViewTextBoxColumn";
            // 
            // patientBirthdayDataGridViewTextBoxColumn
            // 
            patientBirthdayDataGridViewTextBoxColumn.DataPropertyName = "PatientBirthday";
            patientBirthdayDataGridViewTextBoxColumn.HeaderText = "PatientBirthday";
            patientBirthdayDataGridViewTextBoxColumn.Name = "patientBirthdayDataGridViewTextBoxColumn";
            // 
            // patientphoneDataGridViewTextBoxColumn
            // 
            patientphoneDataGridViewTextBoxColumn.DataPropertyName = "Patientphone";
            patientphoneDataGridViewTextBoxColumn.HeaderText = "Patientphone";
            patientphoneDataGridViewTextBoxColumn.Name = "patientphoneDataGridViewTextBoxColumn";
            // 
            // patientPhoneNumberDataGridViewTextBoxColumn
            // 
            patientPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PatientPhoneNumber";
            patientPhoneNumberDataGridViewTextBoxColumn.HeaderText = "PatientPhoneNumber";
            patientPhoneNumberDataGridViewTextBoxColumn.Name = "patientPhoneNumberDataGridViewTextBoxColumn";
            // 
            // patientSnilsDataGridViewTextBoxColumn
            // 
            patientSnilsDataGridViewTextBoxColumn.DataPropertyName = "PatientSnils";
            patientSnilsDataGridViewTextBoxColumn.HeaderText = "PatientSnils";
            patientSnilsDataGridViewTextBoxColumn.Name = "patientSnilsDataGridViewTextBoxColumn";
            // 
            // procedureCardIdDataGridViewTextBoxColumn
            // 
            procedureCardIdDataGridViewTextBoxColumn.DataPropertyName = "ProcedureCardId";
            procedureCardIdDataGridViewTextBoxColumn.HeaderText = "ProcedureCardId";
            procedureCardIdDataGridViewTextBoxColumn.Name = "procedureCardIdDataGridViewTextBoxColumn";
            // 
            // procedureNameDataGridViewTextBoxColumn
            // 
            procedureNameDataGridViewTextBoxColumn.DataPropertyName = "ProcedureName";
            procedureNameDataGridViewTextBoxColumn.HeaderText = "ProcedureName";
            procedureNameDataGridViewTextBoxColumn.Name = "procedureNameDataGridViewTextBoxColumn";
            // 
            // NurseMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "NurseMain";
            Text = "NurseMain";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientCardViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)procedureCardBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)zhalobiBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private BindingSource procedureCardBindingSource;
        private BindingSource zhalobiBindingSource;
        private BindingSource patientCardViewModelBindingSource;
        private DataGridViewTextBoxColumn Pacientt;
        private DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientSurnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientLastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientBirthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientphoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientPhoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientSnilsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn procedureCardIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn procedureNameDataGridViewTextBoxColumn;
    }
}