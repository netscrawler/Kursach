namespace KursFront.Doctorn
{
    partial class CreatePacient
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
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            notifyIcon1 = new NotifyIcon(components);
            maskedTextBox2 = new MaskedTextBox();
            label7 = new Label();
            button2 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(853, 498);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 0;
            button1.Text = "Созранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(116, 70);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(307, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 15);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 7;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 44);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 73);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Отчество:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 105);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 10;
            label4.Text = "Дата Рождения:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(301, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(116, 131);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(307, 23);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.TextMaskFormat = MaskFormat.IncludePrompt;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 134);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 14;
            label5.Text = "Снилс:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 163);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 15;
            label6.Text = "Номер Телефона:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(116, 163);
            numericUpDown1.Maximum = new decimal(new int[] { -1604378624, 18, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1280523264, 16, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(307, 23);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.Value = new decimal(new int[] { 1280523264, 16, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "Errror";
            notifyIcon1.Visible = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(116, 192);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(307, 23);
            maskedTextBox2.TabIndex = 17;
            maskedTextBox2.TextMaskFormat = MaskFormat.IncludePrompt;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 192);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 18;
            label7.Text = "Адрес:";
            // 
            // button2
            // 
            button2.Location = new Point(694, 498);
            button2.Name = "button2";
            button2.Size = new Size(159, 34);
            button2.TabIndex = 19;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(116, 221);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(307, 23);
            maskedTextBox3.TabIndex = 20;
            maskedTextBox3.TextMaskFormat = MaskFormat.IncludePrompt;
            maskedTextBox3.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 250);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 229);
            textBox3.TabIndex = 21;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(444, 12);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(307, 229);
            textBox5.TabIndex = 22;
            textBox5.TextChanged += textBox5_TextChanged_1;
            // 
            // CreatePacient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 544);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(maskedTextBox3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(maskedTextBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(maskedTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "CreatePacient";
            Text = "CreatePacient";
            Load += CreatePacient_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private NotifyIcon notifyIcon1;
        private MaskedTextBox maskedTextBox2;
        private Label label7;
        private Button button2;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox3;
        private TextBox textBox5;
    }
}