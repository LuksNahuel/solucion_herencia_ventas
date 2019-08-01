using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasBDD
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        Actions.Producto_Actions producto_action = new Actions.Producto_Actions();
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Entities.Producto producto = new Entities.Producto();
            producto.NOMBRE = txtNOMBRE.Text;
            producto.PRECIO = float.Parse(txtPRECIO.Text);
            producto.DESCRIPCION = txtDESCRIPCION.Text;
            producto_action.Create(producto);
        }
    }
}
