using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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
        bool FASE = false;
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
            mtbTelefono.Text = "";

            //Valores de la chk

            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;

            //Valores de radios

            rbmEfectivo.Checked = true;
            rbmTarjeta.Checked = false;

            //La fase me va a servir para poder habilitar en cantidad 

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
                while (i <= 4)
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
            if (txtNombre.Text == "")
            {
                mtbTelefono.Enabled = false;
                MessageBox.Show("Complete con sus datos");
            }
            else
            {
                mtbTelefono.Enabled = true;
            }
        }

        private void rbmEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmEfectivo.Checked == true)
            {
                cmbTarjeta.Enabled = false;
            }
            else 
            {
                cmbTarjeta .Enabled = true;
            }
        }

        private void rbmTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmTarjeta.Checked == true)
            {
                cmbTarjeta.Enabled = true;
            }
            else
            {
                cmbTarjeta.Enabled = false;
            }
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
                FASE = true;
            }

            if(FASE ) 
            {
                chkCocina.Enabled = true;
                chkHeladera.Enabled = true;
                chkTelevisor.Enabled = true;
                rbmEfectivo.Enabled = true;
                rbmTarjeta.Enabled = true;
                txtNombre.Enabled = true;
            }

        }

        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDias.Text == "0")
                {
                cmbDias.Text = "1";
                }
        }

        private void cmbTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PRECIO = 0;
            switch (cmbTipodeCabaña.Text)
            {
                case "Tipo A":
                    PRECIO = 20;
                    break;
                case "Tipo B":
                    PRECIO = 34;
                    break;
            }

            if (chkCocina.Checked)
            {
                PRECIO += 1;
            }
            if (chkHeladera.Checked)
            {
                PRECIO += 1.5m;
            }
            if (chkTelevisor.Checked)
            {
                PRECIO += 2;
            }

            int personas = Convert.ToInt32(cmbCantidaddePersonas.SelectedItem);
            int dias = Convert.ToInt32(cmbDias.Text);

            switch (cmbTarjeta.Text)
            {
                case "Red Card":
                    PRECIO = (PRECIO + personas) * dias * 1.1m;
                    break;

                case "Green Card":
                    PRECIO = (PRECIO + personas) * dias * 1.2m;
                    break;

                case "Blue Card":
                    PRECIO = (PRECIO + personas) * dias * 1.2m;
                    break;
            }
            PRECIO = (PRECIO + personas) * dias;

           


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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbTelefono.MaskFull)
            {
                btnAceptar.Enabled = false;
                MessageBox.Show("Complete con sus datos");
            }
            else
            {
                btnAceptar.Enabled = true;
            }
        }
    }
}
