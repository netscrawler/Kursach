namespace KursFront.nurse
{
    partial class ProcedureCheck
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientCardViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(917, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(917, 173);
            button1.Name = "button1";
            button1.Size = new Size(181, 34);
            button1.TabIndex = 2;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(917, 279);
            button2.Name = "button2";
            button2.Size = new Size(187, 44);
            button2.TabIndex = 3;
            button2.Text = "Провести процедуру";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(917, 390);
            button3.Name = "button3";
            button3.Size = new Size(187, 48);
            button3.TabIndex = 4;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(917, 238);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(187, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(917, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
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
            dataGridView1.Size = new Size(861, 426);
            dataGridView1.TabIndex = 7;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(917, 62);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Снилс";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(917, 126);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 9;
            label2.Text = "Название Процедуры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(917, 220);
            label3.Name = "label3";
            label3.Size = new Size(175, 15);
            label3.TabIndex = 10;
            label3.Text = "Время проведения процедуры";
            // 
            // ProcedureCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "ProcedureCheck";
            Text = "ProcedureCheck";
            Load += ProcedureCheck_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientCardViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}