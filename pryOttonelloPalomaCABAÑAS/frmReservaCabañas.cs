using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOttonelloPalomaCABAÑAS
{
    public partial class frmReservaCabañas : Form
    {
        public frmReservaCabañas()
        {
            InitializeComponent();
            

        }
        private void InicializarFormulario()
        {
            cmbTipodeCabaña.Items.Clear();
            cmbTipodeCabaña.Items.Add("A");
            cmbTipodeCabaña.Items.Add("B");
            cmbTipodeCabaña.SelectedIndex = 0;

            //Esto es para que cuente las personas, porque arranca en A
            cmbCantidaddePersonas.Items.Clear();
            for (int i = 1; i <= 4; i++) cmbCantidaddePersonas.Items.Add(i);
            cmbCantidaddePersonas.SelectedIndex = 0;

            //Esto es para el tipo de pago
            rbmEfectivo.Checked = true;
            cmbTarjeta.Enabled = false;

            //El bóton va a arrancar desactivado

            bmtAceptar.Enabled = false;

            //Los txt van a estar vacios

            txtNombre.Clear();
            txtTelefono.Clear();

            //Chau adicionales

            chkCocina.Enabled = false;  
            chkHeladera.Enabled = false;
            chkTelevisor.Enabled = false; 
        } 

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gpbTipodeCabañas_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbTipodeCabaña_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCantidaddePersonas.Items.Clear();

            if (cmbTipodeCabaña.SelectedItem.ToString() == "A")
            {
                for (int i = 1; i <= 4; i++) cmbCantidaddePersonas.Items.Add(i);
            }
            else
                for (int i = 1; i <= 8; i++) cmbCantidaddePersonas.Items.Add(i);
            cmbCantidaddePersonas.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbmEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            cmbTarjeta.Enabled = false;
        }

        private void rbmTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cmbTarjeta.Enabled = true;
        }
    }
}
