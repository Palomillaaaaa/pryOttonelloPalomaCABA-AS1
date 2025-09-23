namespace pryOttonelloPalomaCABAÑAS
{
    partial class frmReservaCabañas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpbTipodeCabañas = new GroupBox();
            cmbDias = new ComboBox();
            lblCantidaddeDias = new Label();
            cmbCantidaddePersonas = new ComboBox();
            lblCantidaddePersonas = new Label();
            cmbTipodeCabaña = new ComboBox();
            lblTipo = new Label();
            gpbAdicionales = new GroupBox();
            chkTelevisor = new CheckBox();
            chkCocina = new CheckBox();
            chkHeladera = new CheckBox();
            gpbFormasdePago = new GroupBox();
            rbmTarjeta = new RadioButton();
            rbmEfectivo = new RadioButton();
            cmbTarjeta = new ComboBox();
            lblTarjeta = new Label();
            gbpTitulardelaReserva = new GroupBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblNombre = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            gpbTipodeCabañas.SuspendLayout();
            gpbAdicionales.SuspendLayout();
            gpbFormasdePago.SuspendLayout();
            gbpTitulardelaReserva.SuspendLayout();
            SuspendLayout();
            // 
            // gpbTipodeCabañas
            // 
            gpbTipodeCabañas.Controls.Add(cmbDias);
            gpbTipodeCabañas.Controls.Add(lblCantidaddeDias);
            gpbTipodeCabañas.Controls.Add(cmbCantidaddePersonas);
            gpbTipodeCabañas.Controls.Add(lblCantidaddePersonas);
            gpbTipodeCabañas.Controls.Add(cmbTipodeCabaña);
            gpbTipodeCabañas.Controls.Add(lblTipo);
            gpbTipodeCabañas.Location = new Point(33, 24);
            gpbTipodeCabañas.Name = "gpbTipodeCabañas";
            gpbTipodeCabañas.Size = new Size(1022, 174);
            gpbTipodeCabañas.TabIndex = 0;
            gpbTipodeCabañas.TabStop = false;
            gpbTipodeCabañas.Text = "Tipo de cabañas";
            gpbTipodeCabañas.Enter += gpbTipodeCabañas_Enter;
            // 
            // cmbDias
            // 
            cmbDias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDias.FormattingEnabled = true;
            cmbDias.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cmbDias.Location = new Point(848, 68);
            cmbDias.Name = "cmbDias";
            cmbDias.Size = new Size(77, 33);
            cmbDias.TabIndex = 5;
            cmbDias.SelectedIndexChanged += cmbDias_SelectedIndexChanged;
            // 
            // lblCantidaddeDias
            // 
            lblCantidaddeDias.AutoSize = true;
            lblCantidaddeDias.Location = new Point(798, 72);
            lblCantidaddeDias.Name = "lblCantidaddeDias";
            lblCantidaddeDias.Size = new Size(55, 25);
            lblCantidaddeDias.TabIndex = 4;
            lblCantidaddeDias.Text = "Días: ";
            // 
            // cmbCantidaddePersonas
            // 
            cmbCantidaddePersonas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCantidaddePersonas.FormattingEnabled = true;
            cmbCantidaddePersonas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbCantidaddePersonas.Location = new Point(573, 68);
            cmbCantidaddePersonas.Name = "cmbCantidaddePersonas";
            cmbCantidaddePersonas.Size = new Size(77, 33);
            cmbCantidaddePersonas.TabIndex = 3;
            cmbCantidaddePersonas.SelectedIndexChanged += cmbCantidaddePersonas_SelectedIndexChanged;
            cmbCantidaddePersonas.EnabledChanged += gpbTipodeCabañas_Enter;
            // 
            // lblCantidaddePersonas
            // 
            lblCantidaddePersonas.AutoSize = true;
            lblCantidaddePersonas.Location = new Point(380, 72);
            lblCantidaddePersonas.Name = "lblCantidaddePersonas";
            lblCantidaddePersonas.Size = new Size(187, 25);
            lblCantidaddePersonas.TabIndex = 2;
            lblCantidaddePersonas.Text = "Cantidad de Personas:";
            // 
            // cmbTipodeCabaña
            // 
            cmbTipodeCabaña.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipodeCabaña.FormattingEnabled = true;
            cmbTipodeCabaña.Items.AddRange(new object[] { "A", "B" });
            cmbTipodeCabaña.Location = new Point(139, 68);
            cmbTipodeCabaña.Name = "cmbTipodeCabaña";
            cmbTipodeCabaña.Size = new Size(77, 33);
            cmbTipodeCabaña.TabIndex = 1;
            cmbTipodeCabaña.SelectedIndexChanged += cmbTipodeCabaña_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(82, 72);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(51, 25);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo:";
            lblTipo.Click += label1_Click;
            // 
            // gpbAdicionales
            // 
            gpbAdicionales.Controls.Add(chkTelevisor);
            gpbAdicionales.Controls.Add(chkCocina);
            gpbAdicionales.Controls.Add(chkHeladera);
            gpbAdicionales.Location = new Point(33, 217);
            gpbAdicionales.Name = "gpbAdicionales";
            gpbAdicionales.Size = new Size(300, 222);
            gpbAdicionales.TabIndex = 1;
            gpbAdicionales.TabStop = false;
            gpbAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(25, 146);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(105, 29);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(25, 98);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(91, 29);
            chkCocina.TabIndex = 1;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(25, 48);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(108, 29);
            chkHeladera.TabIndex = 0;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            chkHeladera.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // gpbFormasdePago
            // 
            gpbFormasdePago.Controls.Add(rbmTarjeta);
            gpbFormasdePago.Controls.Add(rbmEfectivo);
            gpbFormasdePago.Controls.Add(cmbTarjeta);
            gpbFormasdePago.Controls.Add(lblTarjeta);
            gpbFormasdePago.Location = new Point(351, 216);
            gpbFormasdePago.Name = "gpbFormasdePago";
            gpbFormasdePago.Size = new Size(704, 222);
            gpbFormasdePago.TabIndex = 2;
            gpbFormasdePago.TabStop = false;
            gpbFormasdePago.Text = "Formas de Pago";
            gpbFormasdePago.Enter += groupBox1_Enter;
            // 
            // rbmTarjeta
            // 
            rbmTarjeta.AutoSize = true;
            rbmTarjeta.Location = new Point(26, 99);
            rbmTarjeta.Name = "rbmTarjeta";
            rbmTarjeta.Size = new Size(87, 29);
            rbmTarjeta.TabIndex = 9;
            rbmTarjeta.TabStop = true;
            rbmTarjeta.Text = "Tarjeta";
            rbmTarjeta.UseVisualStyleBackColor = true;
            rbmTarjeta.CheckedChanged += rbmTarjeta_CheckedChanged;
            // 
            // rbmEfectivo
            // 
            rbmEfectivo.AutoSize = true;
            rbmEfectivo.Location = new Point(26, 49);
            rbmEfectivo.Name = "rbmEfectivo";
            rbmEfectivo.Size = new Size(99, 29);
            rbmEfectivo.TabIndex = 8;
            rbmEfectivo.TabStop = true;
            rbmEfectivo.Text = "Efectivo";
            rbmEfectivo.UseVisualStyleBackColor = true;
            rbmEfectivo.CheckedChanged += rbmEfectivo_CheckedChanged;
            // 
            // cmbTarjeta
            // 
            cmbTarjeta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarjeta.FlatStyle = FlatStyle.Flat;
            cmbTarjeta.FormattingEnabled = true;
            cmbTarjeta.Items.AddRange(new object[] { "Blue Card", "Red Card", "Green Card" });
            cmbTarjeta.Location = new Point(320, 94);
            cmbTarjeta.Name = "cmbTarjeta";
            cmbTarjeta.Size = new Size(287, 33);
            cmbTarjeta.TabIndex = 6;
            cmbTarjeta.SelectedIndexChanged += cmbTarjeta_SelectedIndexChanged;
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Location = new Point(184, 100);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(130, 25);
            lblTarjeta.TabIndex = 6;
            lblTarjeta.Text = "Tipo de tarjeta:";
            // 
            // gbpTitulardelaReserva
            // 
            gbpTitulardelaReserva.Controls.Add(txtTelefono);
            gbpTitulardelaReserva.Controls.Add(txtNombre);
            gbpTitulardelaReserva.Controls.Add(lblTelefono);
            gbpTitulardelaReserva.Controls.Add(lblNombre);
            gbpTitulardelaReserva.Location = new Point(33, 445);
            gbpTitulardelaReserva.Name = "gbpTitulardelaReserva";
            gbpTitulardelaReserva.Size = new Size(1022, 222);
            gbpTitulardelaReserva.TabIndex = 3;
            gbpTitulardelaReserva.TabStop = false;
            gbpTitulardelaReserva.Text = "Titular de la Reserva";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(118, 116);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(434, 31);
            txtTelefono.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(434, 31);
            txtNombre.TabIndex = 12;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(15, 116);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(88, 25);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(943, 683);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(816, 683);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btmCancelar_Click;
            // 
            // frmReservaCabañas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 794);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(gbpTitulardelaReserva);
            Controls.Add(gpbFormasdePago);
            Controls.Add(gpbAdicionales);
            Controls.Add(gpbTipodeCabañas);
            Name = "frmReservaCabañas";
            Text = "frmReservaCabañas";
            gpbTipodeCabañas.ResumeLayout(false);
            gpbTipodeCabañas.PerformLayout();
            gpbAdicionales.ResumeLayout(false);
            gpbAdicionales.PerformLayout();
            gpbFormasdePago.ResumeLayout(false);
            gpbFormasdePago.PerformLayout();
            gbpTitulardelaReserva.ResumeLayout(false);
            gbpTitulardelaReserva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbTipodeCabañas;
        private GroupBox gpbAdicionales;
        private GroupBox gpbFormasdePago;
        private Label lblTipo;
        private GroupBox gbpTitulardelaReserva;
        private Label lblCantidaddePersonas;
        private ComboBox cmbTipodeCabaña;
        private ComboBox cmbCantidaddePersonas;
        private ComboBox cmbDias;
        private Label lblCantidaddeDias;
        private CheckBox chkHeladera;
        private CheckBox chkTelevisor;
        private CheckBox chkCocina;
        private ComboBox cmbTarjeta;
        private Label lblTarjeta;
        private Label lblTelefono;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Button btnAceptar;
        private Button btnCancelar;
        private RadioButton rbmTarjeta;
        private RadioButton rbmEfectivo;
    }
}