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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcedureCheck procedureCheck = new ProcedureCheck();
            procedureCheck.ShowDialog(this);
            listBox2 = new ListBox();
            listBox2.Refresh();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zapis zapis = new Zapis();
            zapis.ShowDialog(this);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
