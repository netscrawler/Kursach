using KursFront.nurse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Kursach;

namespace KursFront
{
    public partial class Adminmain : Form
    {
        public Adminmain()
        {
            InitializeComponent();
            LoadUserData();
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Nurse");
            comboBox1.Items.Add("Doctor");
        }

        private void LoadUserData()
        {
            using (var context = new Ctx())
            {
                // Загрузка данных из таблиц Admin, Doctor и Nurse
                var admins = context.admins.Include(a => a.User).ToList();
                var doctors = context.doctors.Include(d => d.User).ToList();
                var nurses = context.nurses.Include(n => n.User).ToList();

                // Приведение данных к классу Person
                var persons = new List<Person>();
                persons.AddRange(admins);
                persons.AddRange(doctors);
                persons.AddRange(nurses);

                // Преобразование данных в UserViewModel
                var userViewModels = persons.Select(p => new UserViewModel
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    LastName = p.LastName,
                    Email = p.Email,
                    Role = p is Admin ? "Admin" : p is Doctor ? "Doctor" : p is Nurse ? "Nurse" : "Unknown"
                }).ToList();

                // Отладочное сообщение

                // Отображение данных в DataGridView
                dataGridView1.DataSource = userViewModels;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameFilter = textBox1.Text.ToLower();
            string surnameFilter = textBox2.Text.ToLower();
            string lastNameFilter = textBox3.Text.ToLower();
            string emailFilter = textBox4.Text.ToLower();
            string roleFilter = comboBox1.Text.ToLower();

            using (var context = new Ctx())
            {
                var admins = context.admins.Include(a => a.User).ToList();
                var doctors = context.doctors.Include(d => d.User).ToList();
                var nurses = context.nurses.Include(n => n.User).ToList();

                var persons = new List<Person>();
                persons.AddRange(admins);
                persons.AddRange(doctors);
                persons.AddRange(nurses);

                var filteredPersons = persons.Where(p =>
                    (string.IsNullOrEmpty(nameFilter) || p.Name.ToLower().Contains(nameFilter)) &&
                    (string.IsNullOrEmpty(surnameFilter) || p.Surname.ToLower().Contains(surnameFilter)) &&
                    (string.IsNullOrEmpty(lastNameFilter) || p.LastName.ToLower().Contains(lastNameFilter)) &&
                    (string.IsNullOrEmpty(emailFilter) || p.Email.ToLower().Contains(emailFilter)) &&
                    (string.IsNullOrEmpty(roleFilter) ||
                        (roleFilter == "admin" && p is Admin) ||
                        (roleFilter == "doctor" && p is Doctor) ||
                        (roleFilter == "nurse" && p is Nurse))
                ).ToList();

                var userViewModels = filteredPersons.Select(p => new UserViewModel
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    LastName = p.LastName,
                    Email = p.Email,
                    Role = p is Admin ? "Admin" : p is Doctor ? "Doctor" : p is Nurse ? "Nurse" : "Unknown"
                }).ToList();

                dataGridView1.DataSource = userViewModels;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUser();
            addUserForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            main.CurrentUser = null;
        }
    }
}
