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
    public partial class ProcedureCheck : Form
    {
        public ProcedureCheck()
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
                    .OrderBy(data => data.ProcedureDate)
                    .ToList();

                // Привязка данных к DataGridView
                dataGridView1.DataSource = patientsData;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong patientSnils;
            if (!ulong.TryParse(textBox1.Text, out patientSnils))
            {
                MessageBox.Show("Неверный формат СНИЛС.");
                return;
            }
            string procedureName = textBox2.Text;

            using (var context = new Ctx())
            {
                var procedure = context.pacients
                    .Include(p => p.ProcedureCards)
                        .ThenInclude(pc => pc.Procedures)
                    .Where(p => p.Snils == patientSnils)
                    .SelectMany(p => p.ProcedureCards)
                    .SelectMany(pc => pc.Procedures)
                    .FirstOrDefault(p => p.Name == procedureName);

                if (procedure != null)
                {
                    MessageBox.Show($"Процедура найдена: {procedure.Name}, Дата: {procedure.Time}, Длительность: {procedure.Length}");
                }
                else
                {
                    MessageBox.Show("Процедура не найдена.");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ulong patientSnils;
            if (!ulong.TryParse(textBox1.Text, out patientSnils))
            {
                MessageBox.Show("Неверный формат СНИЛС.");
                return;
            }
            string procedureName = textBox2.Text;
            DateTime procedureDate = dateTimePicker1.Value.ToUniversalTime().AddHours(3); // Convert to UTC  

            using (var context = new Ctx())
            {
                var procedure = context.pacients
                    .Include(p => p.ProcedureCards)
                        .ThenInclude(pc => pc.Procedures)
                    .Where(p => p.Snils == patientSnils)
                    .SelectMany(p => p.ProcedureCards)
                    .SelectMany(pc => pc.Procedures)
                    .FirstOrDefault(p => p.Name == procedureName);

                if (procedure != null)
                {
                    // Получаем карту процедур, к которой относится процедура
                    var procedureCard = context.procedurecards
                        .Include(pc => pc.Procedures)
                        .FirstOrDefault(pc => pc.Procedures.Any(pr => pr.Id == procedure.Id));

                    if (procedureCard != null)
                    {
                        // Удаляем процедуру из текущих процедур  
                        context.procedures.Remove(procedure);

                        // Переносим процедуру в историю процедур  
                        var procedureHistory = new Procedures_History
                        {
                            Date = procedureDate,
                            Card = procedureCard
                        };
                        context.procedureshistories.Add(procedureHistory);

                        context.SaveChanges();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Карта процедур не найдена.");
                    }
                }
                else
                {
                    MessageBox.Show($"Процедура не найдена. СНИЛС: {patientSnils}, Имя процедуры: {procedureName}");
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProcedureCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
