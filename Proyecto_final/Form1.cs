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
            Administrar falumno = new Administrar();
            falumno.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventas fventas = new Ventas();
            fventas.Show();
        }
    }
}
