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

namespace KursFront.Doctor
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
                {
                    // Загрузка данных пациентов
                    var pacients = context.pacients
                        .Where(p => p.Name.Contains(searchQuery) || p.Surname.Contains(searchQuery) || p.LastName.Contains(searchQuery))
                        .ToList();
                    dataGridView1.DataSource = pacients;

                    // Загрузка процедурных карт, связанных с пациентами
                    var procedureCards = context.procedurecards
                        .ToList();
                    dataGridView2.DataSource = procedureCards;
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
            NewProcedure createProcedure = new NewProcedure();
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


    }
}
