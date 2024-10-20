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
            Pacientt = new DataGridViewTextBoxColumn();
            procedureCardBindingSource = new BindingSource(components);
            zhalobiBindingSource = new BindingSource(components);
            lengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Pacientt, lengthDataGridViewTextBoxColumn });
            dataGridView1.DataSource = zhalobiBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(631, 426);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Pacientt
            // 
            Pacientt.HeaderText = "Pacient";
            Pacientt.Name = "Pacientt";
            Pacientt.ReadOnly = true;
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
            // lengthDataGridViewTextBoxColumn
            // 
            lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            lengthDataGridViewTextBoxColumn.ReadOnly = true;
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
        private DataGridViewTextBoxColumn Pacientt;
        private DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private BindingSource zhalobiBindingSource;
    }
}