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
    public partial class NurseMain : Form
    {
        public NurseMain()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadData(string searchQuery = "")
        {
            using (var context = new Ctx())
            {
                // Получаем всех пациентов с их процедурами
                var patientsData = context.pacients
                    .Include(p => p.ProcedureCards) // Загружаем карты процедур
                        .ThenInclude(pc => pc.Procedures) // Загружаем процедуры
                    .ToList() // Загружаем все записи в память
                    .SelectMany(patient => patient.ProcedureCards.Select(pc => new PatientCardViewModel
                    {
                        PatientName = patient.Name,
                        PatientSurname = patient.Surname,
                        PatientLastName = patient.LastName,
                        PatientEmail = patient.Email,
                        PatientBirthday = patient.Birthday,
                        PatientSnils = patient.Snils,
                        ProcedureCardId = pc.Id,
                        // Объединяем названия процедур и их длительности в одну строку
                        ProcedureName = string.Join(", ", pc.Procedures.Select(p => $"{p.Name} (Длительность: {p.Length}) (Дата: {p.Time})")),

                    }))
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
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    Console.WriteLine(column.Name);
                }
            }
        }
        // В вашем конструкторе или методе инициализации

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что клик был по валидной строке и столбцу
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Получаем данные о пациенте из выбранной строки
                var patient = (PatientCardViewModel)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                // Собираем информацию для отображения
                var message = $"Имя: {patient.PatientName}\n" +
                              $"Фамилия: {patient.PatientSurname}\n" +
                              $"Отчество: {patient.PatientLastName}\n" +
                              $"Email: {patient.PatientEmail}\n" +
                              $"День рождения: {patient.PatientBirthday.ToShortDateString()}\n" +
                              $"СНИЛС: {patient.PatientSnils}\n" +
                              $"ID карты: {patient.ProcedureCardId}\n" +
                              $"Процедуры: {patient.ProcedureName}";

                // Отображаем сообщение с информацией о пациенте
                MessageBox.Show(message, "Информация о пациенте", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }








        private void button1_Click(object sender, EventArgs e)
        {
            ProcedureCheck procedureCheck = new ProcedureCheck();
            procedureCheck.ShowDialog(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zapis zapis = new Zapis();
            zapis.ShowDialog(this);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            main.CurrentUser = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NurseMain_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text;
            LoadData(searchQuery);
        }
    }
}
