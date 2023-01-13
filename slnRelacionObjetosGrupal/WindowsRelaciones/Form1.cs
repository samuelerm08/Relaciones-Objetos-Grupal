using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFactura.Entidad;

namespace WindowsRelaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarProductos(object sender, EventArgs e)
        {                                                      
            foreach (var item in Lista.Listar())
            {
                listProducts.Items.Add(item.Categoria.Nombre);
            }
        }
    }
}
