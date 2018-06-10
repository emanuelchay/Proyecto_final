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
    public partial class Agregar_Cliente : Form
    {
        List<Clientes> cliente = new List<Clientes>();
        public Agregar_Cliente()
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            Clientes temppro = new Clientes();
            temppro.Nombre = textBox1.Text;
            temppro.Nit = Convert.ToInt16(textBox2.Text);
            cliente.Add(temppro);


         


            //Nombre del archivo
            string fileName = "clientes.txt";
            //Abrir el archivo
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribie linea por linea
            //Write escribe en la misma linea.
            for (int i = 0; i < cliente.Count; i++)
            {
                writer.WriteLine(cliente[i].Nombre);
                writer.WriteLine(cliente[i].Nit);
            }
            //Cerrar el archivo
            writer.Close();
            MessageBox.Show("Cliente Agregado Exitosamente.");

            Ventas falumno = new Ventas();
            falumno.Visible = true;
            Visible = false;
        }
    }
}
