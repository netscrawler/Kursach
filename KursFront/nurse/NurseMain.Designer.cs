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
            button1 = new Button();
            button2 = new Button();
            listBox2 = new ListBox();
            comboBox1 = new ComboBox();
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
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(333, 424);
            listBox2.TabIndex = 4;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(351, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 23);
            comboBox1.TabIndex = 5;
            // 
            // NurseMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "NurseMain";
            Text = "NurseMain";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox2;
        private ComboBox comboBox1;
    }
}