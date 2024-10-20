using KursFront.Doctor;
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
        }

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
    }
}
