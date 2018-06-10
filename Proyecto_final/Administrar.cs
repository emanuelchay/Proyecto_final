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
    public partial class Administrar : Form
    {
        List<Productos> lproductos =  new List<Productos>();
        public Administrar()
        {
            InitializeComponent();
            string fileName = "productos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                Productos depatemp = new Productos();
                depatemp.Nombre_producto = reader.ReadLine();
                depatemp.Codigo_producto = Convert.ToInt16(reader.ReadLine());
                depatemp.Precio_producto = Convert.ToInt16(reader.ReadLine());
                depatemp.Cantidad_producto = Convert.ToInt16(reader.ReadLine());
                //agregar ala lista temporal
                lproductos.Add(depatemp);
            }

            reader.Close();

            comboBox1.DisplayMember = "Nombre_producto";
            comboBox1.ValueMember = "Codigo_producto";
            comboBox1.DataSource = lproductos;
            comboBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos temppro = new Productos();
            temppro.Nombre_producto = textBox1.Text;
            temppro.Codigo_producto = Convert.ToInt16(textBox2.Text);
            temppro.Precio_producto = Convert.ToInt16(textBox3.Text);
            temppro.Cantidad_producto = Convert.ToInt16(textBox7.Text);
            lproductos.Add(temppro);

            //Nombre del archivo
            string fileName = "productos.txt";
            //Abrir el archivo
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribie linea por linea
            //Write escribe en la misma linea.
            for (int i = 0; i < lproductos.Count; i++)
            {
                writer.WriteLine(lproductos[i].Nombre_producto);
                writer.WriteLine(lproductos[i].Codigo_producto);
                writer.WriteLine(lproductos[i].Precio_producto);
                writer.WriteLine(lproductos[i].Cantidad_producto);
            }
            //Cerrar el archivo
            writer.Close();
            MessageBox.Show("Producto Agregado Exitosamente.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = lproductos;
            dataGridView1.Refresh();

    

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 falumno = new Form1();
            falumno.Visible = true;
            Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        
            for (int x = 0; x != lproductos.Count; x++)
            {
                if (lproductos[x].Nombre_producto == comboBox1.Text)
                {
                    textBox4.Text = lproductos[x].Nombre_producto;
                    textBox5.Text = Convert.ToString(lproductos[x].Codigo_producto);
                    textBox6.Text = Convert.ToString(lproductos[x].Precio_producto);
                    textBox8.Text = Convert.ToString(lproductos[x].Cantidad_producto);

                }
            }
        }
    }
}
