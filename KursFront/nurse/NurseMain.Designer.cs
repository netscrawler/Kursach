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
            dataGridView1 = new DataGridView();
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
            patientCardViewModelBindingSource = new BindingSource(components);
            procedureCardBindingSource = new BindingSource(components);
            zhalobiBindingSource = new BindingSource(components);
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientCardViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)procedureCardBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zhalobiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1217, 276);
            button1.Name = "button1";
            button1.Size = new Size(139, 72);
            button1.TabIndex = 0;
            button1.Text = "Провести процедуру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1217, 198);
            button2.Name = "button2";
            button2.Size = new Size(139, 72);
            button2.TabIndex = 1;
            button2.Text = "Запись на процедуру";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            dataGridView1.Size = new Size(1156, 426);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // button3
            // 
            button3.Location = new Point(1217, 366);
            button3.Name = "button3";
            button3.Size = new Size(139, 72);
            button3.TabIndex = 7;
            button3.Text = "Выйти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1217, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(1217, 98);
            button4.Name = "button4";
            button4.Size = new Size(139, 33);
            button4.TabIndex = 9;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1217, 51);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 10;
            label1.Text = "Снилс";
            // 
            // NurseMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 461);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "NurseMain";
            Text = "NurseMain";
            Load += NurseMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientCardViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)procedureCardBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)zhalobiBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
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
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Label label1;
    }
}