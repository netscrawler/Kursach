using Kursach;
using Microsoft.EntityFrameworkCore;

namespace KursFront.Doctorn
{
    public partial class CreateProcedure : Form
    {
        public CreateProcedure()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(141, 387);
            button1.Name = "button1";
            button1.Size = new Size(108, 45);
            button1.TabIndex = 0;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 141);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 23);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "15:56";
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(12, 252);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2024, 10, 28, 15, 56, 28, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Снилс";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 8;
            label2.Text = "Название процедуры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 9;
            label3.Text = "Длительность";
            // 
            // button2
            // 
            button2.Location = new Point(12, 387);
            button2.Name = "button2";
            button2.Size = new Size(123, 45);
            button2.TabIndex = 10;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // CreateProcedure
            // 
            ClientSize = new Size(261, 444);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Name = "CreateProcedure";
            Load += CreateProcedure_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {




            using (var context = new Ctx())
            {
                var snils = uint.Parse(textBox4.Text); // Замените на нужный СНИЛС
                var patient = context.pacients
                                     .Include(p => p.ProcedureCards) // Загрузка карт процедур
                                     .FirstOrDefault(p => p.Snils == snils); // Поиск пациента по СНИЛС

                if (patient != null)
                {
                    // Создание новой процедуры
                    var newProcedure = new Procedure
                    {

                        Name = textBox2.Text,
                        Length = TimeOnly.FromDateTime(dateTimePicker1.Value)
                    };

                    // Поиск или создание процедурной карты
                    var procedureCard = patient.ProcedureCards.FirstOrDefault();
                    if (procedureCard == null)
                    {
                        // Создаем новую карту процедур, если она не существует
                        procedureCard = new Procedure_Card();
                        patient.ProcedureCards.Add(procedureCard);
                    }

                    // Добавляем процедуру в карту
                    procedureCard.AddProc(newProcedure);

                    // Сохраняем изменения в базе данных
                    context.SaveChanges();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private TextBox textBox2;
        private TextBox textBox4;

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateProcedure_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
