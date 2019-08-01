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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente();
            frmcliente.MdiParent = this;
            frmcliente.Show();
        }

        private void VendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor frmvendedor = new frmVendedor();
            frmvendedor.MdiParent = this;
            frmvendedor.Show();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto frmproducto = new frmProducto();
            frmproducto.MdiParent = this;
            frmproducto.Show();
        }
    }
}
