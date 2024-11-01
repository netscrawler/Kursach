namespace KursFront.nurse
{
    partial class Zapis
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            patientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientSurnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientLastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientSnilsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            procedureCardIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            procedureNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            procedureLengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            procedureDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientCardViewModelBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientCardViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(896, 116);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 0;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(896, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { patientNameDataGridViewTextBoxColumn, patientSurnameDataGridViewTextBoxColumn, patientLastNameDataGridViewTextBoxColumn, patientSnilsDataGridViewTextBoxColumn, procedureCardIdDataGridViewTextBoxColumn, procedureNameDataGridViewTextBoxColumn, procedureLengthDataGridViewTextBoxColumn, procedureDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = patientCardViewModelBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(848, 410);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientSurnameDataGridViewTextBoxColumn
            // 
            patientSurnameDataGridViewTextBoxColumn.DataPropertyName = "PatientSurname";
            patientSurnameDataGridViewTextBoxColumn.HeaderText = "PatientSurname";
            patientSurnameDataGridViewTextBoxColumn.Name = "patientSurnameDataGridViewTextBoxColumn";
            patientSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientLastNameDataGridViewTextBoxColumn
            // 
            patientLastNameDataGridViewTextBoxColumn.DataPropertyName = "PatientLastName";
            patientLastNameDataGridViewTextBoxColumn.HeaderText = "PatientLastName";
            patientLastNameDataGridViewTextBoxColumn.Name = "patientLastNameDataGridViewTextBoxColumn";
            patientLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientSnilsDataGridViewTextBoxColumn
            // 
            patientSnilsDataGridViewTextBoxColumn.DataPropertyName = "PatientSnils";
            patientSnilsDataGridViewTextBoxColumn.HeaderText = "PatientSnils";
            patientSnilsDataGridViewTextBoxColumn.Name = "patientSnilsDataGridViewTextBoxColumn";
            patientSnilsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procedureCardIdDataGridViewTextBoxColumn
            // 
            procedureCardIdDataGridViewTextBoxColumn.DataPropertyName = "ProcedureCardId";
            procedureCardIdDataGridViewTextBoxColumn.HeaderText = "ProcedureCardId";
            procedureCardIdDataGridViewTextBoxColumn.Name = "procedureCardIdDataGridViewTextBoxColumn";
            procedureCardIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procedureNameDataGridViewTextBoxColumn
            // 
            procedureNameDataGridViewTextBoxColumn.DataPropertyName = "ProcedureName";
            procedureNameDataGridViewTextBoxColumn.HeaderText = "ProcedureName";
            procedureNameDataGridViewTextBoxColumn.Name = "procedureNameDataGridViewTextBoxColumn";
            procedureNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procedureLengthDataGridViewTextBoxColumn
            // 
            procedureLengthDataGridViewTextBoxColumn.DataPropertyName = "ProcedureLength";
            procedureLengthDataGridViewTextBoxColumn.HeaderText = "ProcedureLength";
            procedureLengthDataGridViewTextBoxColumn.Name = "procedureLengthDataGridViewTextBoxColumn";
            procedureLengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procedureDateDataGridViewTextBoxColumn
            // 
            procedureDateDataGridViewTextBoxColumn.DataPropertyName = "ProcedureDate";
            procedureDateDataGridViewTextBoxColumn.HeaderText = "ProcedureDate";
            procedureDateDataGridViewTextBoxColumn.Name = "procedureDateDataGridViewTextBoxColumn";
            procedureDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientCardViewModelBindingSource
            // 
            patientCardViewModelBindingSource.DataSource = typeof(Kursach.PatientCardViewModel);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(896, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(896, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(896, 228);
            button2.Name = "button2";
            button2.Size = new Size(200, 43);
            button2.TabIndex = 5;
            button2.Text = "Записать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(896, 22);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Снилс";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(896, 69);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 7;
            label2.Text = "Название процедуры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(896, 181);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 8;
            label3.Text = "Время записи";
            // 
            // button3
            // 
            button3.Location = new Point(896, 337);
            button3.Name = "button3";
            button3.Size = new Size(200, 67);
            button3.TabIndex = 9;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Zapis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 433);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Zapis";
            Text = "Zapis";
            Load += Zapis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientCardViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientSurnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientLastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientSnilsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn procedureCardIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn procedureNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn procedureLengthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn procedureDateDataGridViewTextBoxColumn;
        private BindingSource patientCardViewModelBindingSource;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}