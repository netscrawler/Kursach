using Kursach;
using KursFront.Doctorn;
using KursFront.nurse;
using Microsoft.EntityFrameworkCore;
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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        public static User CurrentUser { get; set; }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PacientRegister PacientRegister = new PacientRegister();
            //PacientRegister.ShowDialog();
            DoctorMain doctorMain = new DoctorMain();
            doctorMain.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NurseMain nurseMain = new NurseMain();
            nurseMain.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adminmain adminmain = new Adminmain();
            adminmain.ShowDialog(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            using (var context = new Ctx())
            {
                var user = context.users
                                  .Include(u => u.Doctor)
                                  .Include(u => u.Nurse)
                                  .Include(u => u.Admin)
                                  .SingleOrDefault(u => u.Login == username);

                if (user != null)
                {
                    if (user.Logining(username, password))
                    {
                        CurrentUser = user; // Сохранение пользователя в статическую переменную
                        MessageBox.Show("Успешный вход");

                        // Очистка текстбоксов
                        textBox1.Clear();
                        textBox2.Clear();

                        // Скрытие текущей формы
                        this.Hide();

                        Form nextForm = null;

                        if (user.Doctor != null && user.Doctor.Email == username)
                        {
                            nextForm = new DoctorMain();
                        }
                        else if (user.Nurse != null && user.Nurse.Email == username)
                        {
                            nextForm = new NurseMain();
                        }
                        else if (user.Admin != null && user.Admin.Email == username)
                        {
                            nextForm = new Adminmain();
                        }
                        else
                        {
                            MessageBox.Show("Роль пользователя не найдена");
                            this.Show();
                            return;
                        }

                        // Подписка на событие FormClosed для открытия текущей формы снова
                        nextForm.FormClosed += (s, args) => this.Show();
                        nextForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
            
