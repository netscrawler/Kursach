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
                        PatientEmail = patient.Email,
                        PatientBirthday = patient.Birthday,
                        Patientphone = patient.Phone.ToString(), // Преобразуем в строку
                        PatientPhoneNumber = patient.Phone,
                        PatientSnils = patient.Snils,
                        ProcedureCardId = pc.Id,
                        ProcedureName = p.Name,
                        ProcedureLength = p.Length
                    })))
                    .Distinct()
                    .ToList();

                // Привязка данных к DataGridView
                dataGridView1.DataSource = patientsData;

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
    }
}
