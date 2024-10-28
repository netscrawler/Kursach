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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 12);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 23);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "15:56";
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(12, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2024, 10, 28, 15, 56, 28, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // CreateProcedure
            // 
            ClientSize = new Size(704, 444);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Name = "CreateProcedure";
            ResumeLayout(false);
            PerformLayout();
        }

        private DateTimePicker dateTimePicker1;
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
    }
}
