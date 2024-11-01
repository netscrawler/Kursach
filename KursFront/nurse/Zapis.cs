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

        private void LoadData(string searchQuery = "", string procedureQuery = "")
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

                // Фильтрация данных по названию процедуры, если задан поисковый запрос
                if (!string.IsNullOrWhiteSpace(procedureQuery))
                {
                    patientsData = patientsData
                        .Where(data => data.ProcedureName.Contains(procedureQuery, StringComparison.OrdinalIgnoreCase)) // Поиск по названию процедуры
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
            string procedureQuery = textBox2.Text;
            LoadData(searchQuery, procedureQuery);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text;
            string procedureQuery = textBox2.Text;

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

                // Фильтрация данных по названию процедуры, если задан поисковый запрос
                if (!string.IsNullOrWhiteSpace(procedureQuery))
                {
                    patientsData = patientsData
                        .Where(data => data.ProcedureName.Contains(procedureQuery, StringComparison.OrdinalIgnoreCase)) // Поиск по названию процедуры
                        .ToList();
                }

                // Обновление времени процедуры для отфильтрованных данных
                foreach (var patientData in patientsData)
                {
                    var procedureCard = context.procedurecards
                        .Include(pc => pc.Procedures)
                        .FirstOrDefault(pc => pc.Id == patientData.ProcedureCardId);

                    if (procedureCard != null)
                    {
                        var procedure = procedureCard.Procedures.FirstOrDefault(p => p.Name == patientData.ProcedureName);
                        if (procedure != null)
                        {
                            procedure.Time = dateTimePicker1.Value.ToUniversalTime().AddHours(3); // Преобразование времени в UTC
                            context.Entry(procedure).State = EntityState.Modified;
                        }
                    }
                }

                context.SaveChanges();
            }

            // Обновление данных в DataGridView
            LoadData(searchQuery, procedureQuery);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
