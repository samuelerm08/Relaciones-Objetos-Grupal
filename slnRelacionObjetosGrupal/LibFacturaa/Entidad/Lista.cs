using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura.Entidad
{
    public static class Lista
    {
        public static List<Producto> productos = new List<Producto>();

        public static List<Producto> Listar()
        {
            productos.Add(new Producto("Cartera", 200)
            {
                Categoria = new Categoria("Moda"),
            });
            return productos;
        }
    }
}
