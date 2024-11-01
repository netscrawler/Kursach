using Kursach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursFront
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            // Добавляем элементы в comboBox1
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Nurse");
            comboBox1.Items.Add("Doctor");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string name = textBox3.Text;
            string surname = textBox4.Text;
            string lastname = textBox5.Text;
            DateOnly birthday = DateOnly.FromDateTime(dateTimePicker1.Value);
            ulong snils = (ulong)numericUpDown1.Value;
            ulong phone = (ulong)numericUpDown2.Value;

            User newUser = new User();
            newUser.Register(login, password);

            string? role = comboBox1.SelectedItem?.ToString();
            if (role == null)
            {
                MessageBox.Show("Пожалуйста, выберите роль.");
                return;
            }

            Person? person = null;

            switch (role)
            {
                case "Admin":
                    Admin admin = new Admin();
                    admin.Add(name, surname, lastname, login, birthday, password, snils, phone, newUser);
                    person = admin;
                    break;
                case "Nurse":
                    Nurse nurse = new Nurse();
                    nurse.Add(name, surname, lastname, login, birthday, password, snils, phone, newUser);
                    person = nurse;
                    break;
                case "Doctor":
                    Kursach.Doctor doctor = new Kursach.Doctor();
                    doctor.Add(name, surname, lastname, login, birthday, password, snils, phone, newUser);
                    person = doctor;
                    break;
            }

            if (person == null)
            {
                MessageBox.Show("Ошибка при создании пользователя.");
                return;
            }

            // Сохранение пользователя и роли в базу данных
            SaveToDatabase(newUser, person);
        }

        private void SaveToDatabase(User user, Person person)
        {
            using (var context = new Ctx())
            {
                context.Set<User>().Add(user);
                context.SaveChanges(); // Сохраняем User сначала, чтобы получить первичный ключ

                if (person is Admin admin)
                {
                    admin.UserId = user.Id; // Устанавливаем внешний ключ
                    context.Set<Admin>().Add(admin);
                }
                else if (person is Doctor doctor)
                {
                    doctor.UserId = user.Id;
                    context.Set<Doctor>().Add(doctor);
                }
                else if (person is Nurse nurse)
                {
                    nurse.UserId = user.Id; // Устанавливаем внешний ключ
                    context.Set<Nurse>().Add(nurse);
                }

                context.SaveChanges(); // Сохраняем сущность Person
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
