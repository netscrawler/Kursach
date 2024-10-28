using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KursFront.Doctorn
{
    public partial class CreatePacient : Form
    {
        public CreatePacient()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получить данные из формы  
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string lastname = textBox4.Text;
            UInt64 snils;
            if (!UInt64.TryParse(maskedTextBox1.Text, out snils))
            {
                MessageBox.Show("Invalid SNILS format. Please enter a valid number.");
                return;
            }
            string email = maskedTextBox2.Text;
            UInt64 phone = UInt64.Parse(numericUpDown1.Value.ToString());
            DateOnly birthDate = new DateOnly(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);

            string[] Zhalobi = textBox3.Text.Split(',');
            string[] Diseases = textBox5.Text.Split(',');

            //TODO: Доработать напильником
            // Создать нового пациента  
            Pacient newPacient = new Pacient();
            newPacient.New(name, surname, lastname, email, birthDate, snils, phone);

            Kursach.User user = new Kursach.User();
            user.Register(email, "password");

            Kursach.Doctor doctor = new Kursach.Doctor();
            doctor.Add(name, surname, lastname, email, birthDate, "password", snils, phone, user);



            Procedure_Card procedure_Card = new Procedure_Card();
            procedure_Card.New(Zhalobi, newPacient, doctor, Diseases);

            // Сохранить пациента в базу данных с использованием Entity Framework  
            using (var context = new Ctx())
            {

                context.pacients.Add(newPacient);
                context.procedurecards.Add(procedure_Card);
                context.doctors.Add(doctor);
                context.users.Add(user);
                context.SaveChanges();
            }

            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CreatePacient_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
