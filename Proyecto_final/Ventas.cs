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
    public partial class Ventas : Form
    {
        List<Clientes> cliente = new List<Clientes>();
        public Ventas()
        {
            InitializeComponent();
            string fileName = "clientes.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                Clientes depatemp = new Clientes();
                depatemp.Nombre = reader.ReadLine();
                depatemp.Nit = Convert.ToInt16(reader.ReadLine());

                //agregar ala lista temporal
                cliente.Add(depatemp);
            }

            reader.Close();
        }


        
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 falumno = new Form1();
            falumno.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int encontrado = 0;
            for (int x = 0; x != cliente.Count; x++)
            {
                if (cliente[x].Nit == Convert.ToInt16(textBox1.Text))
                {
                    encontrado = 1;
                    label12.Text = cliente[x].Nombre;
                }


            }


            if (encontrado == 1)
            {
                MessageBox.Show("Existe");

            }
            else if (encontrado == 0)
            {
                MessageBox.Show("No existe"," Informacion " );
                Agregar_Cliente falumno = new Agregar_Cliente();
                falumno.Visible = true;
                Visible = false;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
