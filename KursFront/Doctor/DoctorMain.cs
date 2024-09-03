using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursFront.Doctor
{
    public partial class DoctorMain : Form
    {
        public DoctorMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CreatePacient createPacient = new CreatePacient();
            createPacient.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewProcedure createProcedure = new NewProcedure();
            createProcedure.ShowDialog();
        }
    }
}
