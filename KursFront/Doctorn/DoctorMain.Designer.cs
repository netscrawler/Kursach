

namespace KursFront.Doctor
{
    partial class DoctorMain
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
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pacientBindingSource = new BindingSource(components);
            pacientBindingSource1 = new BindingSource(components);
            textBox1 = new TextBox();
            button3 = new Button();
            zhalobiBindingSource = new BindingSource(components);
            procedureCardBindingSource = new BindingSource(components);
            zhalobiBindingSource1 = new BindingSource(components);
            procedureCardBindingSource2 = new BindingSource(components);
            zhalobiBindingSource2 = new BindingSource(components);
            procedureCardBindingSource1 = new BindingSource(components);
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacientBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zhalobiBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)procedureCardBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zhalobiBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)procedureCardBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zhalobiBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)procedureCardBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1288, 12);
            button1.Name = "button1";
            button1.Size = new Size(151, 60);
            button1.TabIndex = 0;
            button1.Text = "Create Pacient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1288, 78);
            button2.Name = "button2";
            button2.Size = new Size(151, 60);
            button2.TabIndex = 3;
            button2.Text = "Назначить процедуру";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, idDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = pacientBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(745, 426);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "ProcedureCards";
            dataGridViewTextBoxColumn9.HeaderText = "ProcedureCards";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Name";
            dataGridViewTextBoxColumn10.HeaderText = "Name";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Surname";
            dataGridViewTextBoxColumn11.HeaderText = "Surname";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "LastName";
            dataGridViewTextBoxColumn12.HeaderText = "LastName";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "Birthday";
            dataGridViewTextBoxColumn13.HeaderText = "Birthday";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "Email";
            dataGridViewTextBoxColumn14.HeaderText = "Email";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "Snils";
            dataGridViewTextBoxColumn15.HeaderText = "Snils";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "Phone";
            dataGridViewTextBoxColumn16.HeaderText = "Phone";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // pacientBindingSource
            // 
            pacientBindingSource.DataSource = typeof(Kursach.Pacient);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1288, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(1288, 173);
            button3.Name = "button3";
            button3.Size = new Size(151, 23);
            button3.TabIndex = 6;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // zhalobiBindingSource
            // 
            zhalobiBindingSource.DataMember = "Zhalobi";
            zhalobiBindingSource.DataSource = procedureCardBindingSource;
            // 
            // procedureCardBindingSource
            // 
            procedureCardBindingSource.DataSource = typeof(Kursach.Procedure_Card);
            // 
            // zhalobiBindingSource1
            // 
            zhalobiBindingSource1.DataMember = "Zhalobi";
            zhalobiBindingSource1.DataSource = procedureCardBindingSource;
            // 
            // procedureCardBindingSource2
            // 
            procedureCardBindingSource2.DataSource = typeof(Kursach.Procedure_Card);
            // 
            // zhalobiBindingSource2
            // 
            zhalobiBindingSource2.DataMember = "Zhalobi";
            zhalobiBindingSource2.DataSource = procedureCardBindingSource1;
            // 
            // procedureCardBindingSource1
            // 
            procedureCardBindingSource1.DataSource = typeof(Kursach.Procedure_Card);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(763, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(503, 424);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // DoctorMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 450);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "DoctorMain";
            Text = "DoctorMain";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacientBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)zhalobiBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)procedureCardBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)zhalobiBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)procedureCardBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)zhalobiBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)procedureCardBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn procedureCardsDataGridViewTextBoxColumn;
        private BindingSource pacientBindingSource;
        private TextBox textBox1;
        private Button button3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn snilsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private BindingSource pacientBindingSource1;
        private BindingSource procedureCardBindingSource;
        private BindingSource zhalobiBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private BindingSource zhalobiBindingSource1;
        private BindingSource procedureCardBindingSource1;
        private BindingSource zhalobiBindingSource2;
        private BindingSource procedureCardBindingSource2;
        private ListBox listBox1;
    }
}