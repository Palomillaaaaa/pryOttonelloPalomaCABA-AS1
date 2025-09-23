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


        //Declaración de Variables Globales
        bool TIPOA = false;
        bool TIPOB = false;
        bool COCINA = false;
        bool HELADERA = false;
        bool TELEVISOR = false;

        public static decimal PRECIO = 0;
        int i = 1;

        private void InicializarFormulario()
        {
            //Al inicializar el formulario el boton esta deshabilitado
            btnAceptar.Enabled = false; 

            //Como van a estar seleccionados los elementos en el combo box- Tipo
            cmbTipodeCabaña.Items.Clear();
            cmbTipodeCabaña.Items.Add("Tipo A");
            cmbTipodeCabaña.Items.Add("Tipo B");
            cmbTipodeCabaña.SelectedIndex = -1;

            //Como van a estar seleccionados los elementos en el combo box- Tarjeta
            cmbTarjeta.Items.Clear();
            cmbTarjeta.Items.Add("Red Card");
            cmbTarjeta.Items.Add("Blue Card");
            cmbTarjeta.Items.Add("Green Card");
            
            //Inicialización de los textos
            txtNombre.Text = "";
            txtTelefono.Text = "";

            //Valores de la chk

            chkCocina.Checked = false;  
            chkHeladera.Checked = false;
            chkTelevisor.Checked=false;
           
            //Valores de radios

            rbmEfectivo.Checked = false;    
            rbmTarjeta.Checked = false;

            //La fase me va a servir para poder habilitar en cantidad 
            bool FASE = false;

            i = 1;
        }



        //string vTelefono = new string Telefono();

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
            
            if (cmbTipodeCabaña.Text == "Tipo A")
            {
                TIPOA = true;
            }
            else
            {
                TIPOA = false;
            }
            if (cmbTipodeCabaña.Text == "Tipo B")
            {
                TIPOB = true;
            }
            else
            {
                TIPOB = false;
            }
            if (cmbTipodeCabaña.Text == "")
            {
                cmbCantidaddePersonas.Enabled = false;

            }
            else
            {
                cmbCantidaddePersonas.Enabled = true;
            }
            if (TIPOA)
            {
                i = 1;
                cmbCantidaddePersonas.Items.Clear();
                while (i <=4)
                { 
                cmbCantidaddePersonas.Items.Add(i);
                    i++;
                }
            }
            if (TIPOB)
            {
                i = 1;
                cmbCantidaddePersonas.Items.Clear();
                while (i <= 8)
                {
                    cmbCantidaddePersonas.Items.Add(i);
                    i++;
                }
            }
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

        private void cmbCantidaddePersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantidaddePersonas.Text == "")
            {
                cmbDias.Enabled = false;

            }
            else
            {
                cmbDias.Enabled = true;
            }

        }

        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDias.Text == "")
            {
                cmbTarjeta.Enabled = false;
            }
            else
            {
                cmbTarjeta.Enabled = true;
            }
        }

        private void cmbTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbTipodeCabaña.Text == "")
            {
                MessageBox.Show("Elija un tipo de cabaña");
            }
            else if (cmbCantidaddePersonas.Text == "")
            {
                MessageBox.Show("Elija un número de personas");
            }
            else if (cmbDias.Text == "")
            {
                MessageBox.Show("Elija la cantidad de días");
            }
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
          //  txtNombre.Text == "";
            //txtTelefono.Text == !

        }
    }
}
