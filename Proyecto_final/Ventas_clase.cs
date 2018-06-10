using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    class Ventas_clase
    {
        string nombre_de_vendedor;
        int nit_cliente;
        int total_producto;
        string nombre_producto;
        int codigo_producto;
        int cantidad_de_producto;
        int precio_total;

        public string Nombre_de_vendedor { get => nombre_de_vendedor; set => nombre_de_vendedor = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public int Cantidad_de_producto { get => cantidad_de_producto; set => cantidad_de_producto = value; }
        public int Total_producto { get => total_producto; set => total_producto = value; }
        public int Precio_total { get => precio_total; set => precio_total = value; }
    }
}
