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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }
        Actions.Vendedor_Action vendedor_action = new Actions.Vendedor_Action();
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Entities.Vendedor vendedor = new Entities.Vendedor();
            vendedor.DNI = txtDNI.Text;
            vendedor.NOMBRE = txtNOMBRE.Text;
            vendedor.APELLIDO = txtAPELLIDO.Text;
            vendedor.DIRRECIOn = txtDIRECCION.Text;
            vendedor.TELEFONO = txtTELEFONO.Text;
            vendedor.EMAIL = txtEMAIL.Text;
            vendedor_action.Create(vendedor);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.Vendedor vendedor = vendedor_action.Read(txtDNI.Text);
                txtDNI.Text = vendedor.DNI;
                if (txtDNI.Text != null)
                {
                    txtNOMBRE.Text = vendedor.NOMBRE;
                    txtAPELLIDO.Text = vendedor.APELLIDO;
                    txtDIRECCION.Text = vendedor.DIRRECIOn;
                    txtTELEFONO.Text = vendedor.TELEFONO;
                    txtEMAIL.Text = vendedor.EMAIL;
                }
            }
            catch
            {
                MessageBox.Show("El vendedor no existe.", "Mostrar vendedor.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
