using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seguridad falumno = new Seguridad();
            falumno.Visible = true;
            Visible = false;          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seguridad fventas = new Seguridad();
            fventas.Visible = true;
            Visible = false;
        }
    }
}
