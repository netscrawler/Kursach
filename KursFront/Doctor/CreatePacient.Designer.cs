namespace KursFront.Doctor
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(409, 236);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 0;
            button1.Text = "Созранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(244, 85);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(307, 23);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 30);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 7;
            label1.Text = "Имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 59);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 88);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Отчество:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 120);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 10;
            label4.Text = "Дата Рождения:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(244, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(301, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(244, 146);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(307, 23);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.TextMaskFormat = MaskFormat.IncludePrompt;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 149);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 14;
            label5.Text = "Снилс:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 178);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 15;
            label6.Text = "Номер Телефона:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(244, 178);
            numericUpDown1.Maximum = new decimal(new int[] { -1604378624, 18, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1280523264, 16, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(307, 23);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.Value = new decimal(new int[] { 1280523264, 16, 0, 0 });
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "Errror";
            notifyIcon1.Visible = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(244, 207);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(307, 23);
            maskedTextBox2.TabIndex = 17;
            maskedTextBox2.TextMaskFormat = MaskFormat.IncludePrompt;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(191, 207);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 18;
            label7.Text = "Адрес:";
            // 
            // button2
            // 
            button2.Location = new Point(244, 236);
            button2.Name = "button2";
            button2.Size = new Size(159, 34);
            button2.TabIndex = 19;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CreatePacient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}