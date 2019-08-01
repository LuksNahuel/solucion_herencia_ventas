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
    public partial class frmCliente : Form
    {
        Actions.Cliente_Actions cliente_action = new Actions.Cliente_Actions();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Entities.Cliente cliente = new Entities.Cliente();
            cliente.DNI = txtDNI.Text;
            cliente.NOMBRE = txtNOMBRE.Text;
            cliente.APELLIDO = txtAPELLIDO.Text;
            cliente.DIRRECIOn = txtDIRECCION.Text;
            cliente.TELEFONO = txtTELEFONO.Text;
            cliente.EMAIL = txtEMAIL.Text;
            bool state = cliente_action.Create(cliente);
            if (state)
            {
                MessageBox.Show("El cliente fue agregado correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("El cliente no pudo ser cargado correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.Cliente cliente = cliente_action.Read(txtDNI.Text);
                //txtBuscarDNI.Text
                txtDNI.Text = cliente.DNI;
                if(txtDNI.Text != null)
                {
                    txtNOMBRE.Text = cliente.NOMBRE;
                    txtAPELLIDO.Text = cliente.APELLIDO;
                    txtDIRECCION.Text = cliente.DIRRECIOn;
                    txtTELEFONO.Text = cliente.TELEFONO;
                    txtEMAIL.Text = cliente.EMAIL;
                }
            }
            catch
            {
                MessageBox.Show("El cliente no existe", "Mostrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            cliente_action.Delete(txtDNI.Text);
        }
    }
}
