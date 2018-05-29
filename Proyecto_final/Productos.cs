using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    class Productos
    {
        int codigo_producto;
        string nombre_producto;
        int cantidad_producto;
        int precio_producto;

        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public int Cantidad_producto { get => cantidad_producto; set => cantidad_producto = value; }
        public int Precio_producto { get => precio_producto; set => precio_producto = value; }
    }
}
