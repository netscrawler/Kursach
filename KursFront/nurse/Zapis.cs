using Kursach;
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

namespace KursFront.nurse
{
    public partial class Zapis : Form
    {
        public Zapis()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string searchQuery = "")
        {
            using (var context = new Ctx())
            {
                // Получаем всех пациентов с их процедурами и процедурами
                var patientsData = context.pacients
                    .Include(p => p.ProcedureCards) // Загружаем карты процедур
                        .ThenInclude(pc => pc.Procedures) // Загружаем процедуры
                    .ToList() // Загружаем все записи в память
                    .SelectMany(patient => patient.ProcedureCards.SelectMany(pc => pc.Procedures.Select(p => new PatientCardViewModel
                    {
                        PatientName = patient.Name,
                        PatientSurname = patient.Surname,
                        PatientLastName = patient.LastName,
                        PatientSnils = patient.Snils,
                        ProcedureCardId = pc.Id,
                        ProcedureName = p.Name,
                        ProcedureLength = p.Length,
                        ProcedureDate = p.Time
                    })))
                    .Distinct()
                    .ToList();

                // Фильтрация данных по СНИЛСу, если задан поисковый запрос
                if (!string.IsNullOrWhiteSpace(searchQuery) && ulong.TryParse(searchQuery, out ulong snilsQuery))
                {
                    patientsData = patientsData
                        .Where(data => data.PatientSnils == snilsQuery) // Поиск по СНИЛСу
                        .ToList();
                }

                // Привязка данных к DataGridView
                dataGridView1.DataSource = patientsData;
            }
        }



        private void Zapis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
