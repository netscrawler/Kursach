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
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(637, 12);
            button1.Name = "button1";
            button1.Size = new Size(151, 60);
            button1.TabIndex = 0;
            button1.Text = "Create Pacient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(280, 424);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(298, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(333, 424);
            listBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(637, 78);
            button2.Name = "button2";
            button2.Size = new Size(151, 60);
            button2.TabIndex = 3;
            button2.Text = "Назначить процедуру";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DoctorMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "DoctorMain";
            Text = "DoctorMain";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button2;
    }
}