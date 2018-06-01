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
        string nombre_producto;
        int codigo_producto;

        public string Nombre_de_vendedor { get => nombre_de_vendedor; set => nombre_de_vendedor = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
    }
}
