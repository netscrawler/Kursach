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
using KursFront.Doctorn;
using System.CodeDom;
using Microsoft.EntityFrameworkCore;

namespace KursFront.Doctorn
{
    public partial class DoctorMain : Form
    {
        public DoctorMain()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string searchQuery = "")
        {
            using (var context = new Ctx())
            {
                // Загрузка данных пациентов
                var pacients = context.pacients
                    .Where(p => p.Name.Contains(searchQuery) || p.Surname.Contains(searchQuery) || p.LastName.Contains(searchQuery))
                    .ToList();
                dataGridView1.DataSource = pacients;

                // Загрузка процедурных карт, связанных с пациентами
                var procedureCards = context.procedurecards
                    .Include(pc => pc.Doctor) // Включаем данные о докторе
                    .Include(pc => pc.Procedures) // Включаем данные о процедурах
                    .Where(pc => pc.Pacient.Name.Contains(searchQuery) || pc.Pacient.Surname.Contains(searchQuery) || pc.Pacient.LastName.Contains(searchQuery))
                    .ToList();

                // Очистка listBox1 перед добавлением новых данных
                listBox1.Items.Clear();

                // Добавление данных в listBox1
                foreach (var card in procedureCards)
                {
                    var complaints = string.Join(", ", card.Zhalobi);
                    var diseases = string.Join(", ", card.Diseases);
                    var procedures = string.Join(", ", card.Procedures.Select(p => p.Name));

                    listBox1.Items.Add($"Пациент: {card.Pacient.Name} {card.Pacient.Surname} {card.Pacient.LastName} Снилс: {card.Pacient.Snils}, Жалобы: {complaints}, Болезни: {diseases}, Процедуры: {procedures}, Доктор: {card.Doctor.Name} {card.Doctor.Surname} {card.Doctor.LastName}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatePacient createPacient = new CreatePacient();
            createPacient.ShowDialog();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateProcedure createProcedure = new CreateProcedure();
            createProcedure.ShowDialog();
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text;
            LoadData(searchQuery);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            main.CurrentUser = null;
        }
    }
}
