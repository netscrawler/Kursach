namespace KursFront
{
    partial class Cabinetform
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
            dataGridView1 = new DataGridView();
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            openDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            closeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weekendDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cabinetBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cabinetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(761, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numberDataGridViewTextBoxColumn, openDataGridViewTextBoxColumn, closeDataGridViewTextBoxColumn, weekendDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cabinetBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(447, 426);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "Number";
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // openDataGridViewTextBoxColumn
            // 
            openDataGridViewTextBoxColumn.DataPropertyName = "Open";
            openDataGridViewTextBoxColumn.HeaderText = "Open";
            openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            // 
            // closeDataGridViewTextBoxColumn
            // 
            closeDataGridViewTextBoxColumn.DataPropertyName = "Close";
            closeDataGridViewTextBoxColumn.HeaderText = "Close";
            closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            // 
            // weekendDataGridViewTextBoxColumn
            // 
            weekendDataGridViewTextBoxColumn.DataPropertyName = "Weekend";
            weekendDataGridViewTextBoxColumn.HeaderText = "Weekend";
            weekendDataGridViewTextBoxColumn.Name = "weekendDataGridViewTextBoxColumn";
            // 
            // cabinetBindingSource
            // 
            cabinetBindingSource.DataSource = typeof(Kursach.Cabinet);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(736, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(736, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(636, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(636, 99);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // Cabinetform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 450);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Cabinetform";
            Text = "Cabinetform";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cabinetBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weekendDataGridViewTextBoxColumn;
        private BindingSource cabinetBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}