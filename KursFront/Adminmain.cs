using KursFront.nurse;
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
    public partial class Adminmain : Form
    {
        public Adminmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cabinetform cabinetform = new Cabinetform();
            cabinetform.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
