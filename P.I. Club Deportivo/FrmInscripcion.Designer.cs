namespace P.I._Club_Deportivo
{
    partial class FrmInscripcion
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscripcion));
            toolTipInscripcion = new ToolTip(components);
            btnVolver = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDocumento = new Label();
            lblDireccion = new Label();
            lblContacto = new Label();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtContacto = new TextBox();
            lblTipoCliente = new Label();
            cboTipoCliente = new ComboBox();
            lblAptoFisico = new Label();
            chkAptoFisico = new CheckBox();
            btnInscribir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.WhiteSmoke;
            btnVolver.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(971, 20);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(154, 67);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(17, 128);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(93, 28);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(17, 207);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(98, 28);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "APELLIDO";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumento.Location = new Point(17, 287);
            lblDocumento.Margin = new Padding(4, 0, 4, 0);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(134, 28);
            lblDocumento.TabIndex = 7;
            lblDocumento.Text = "DOCUMENTO";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(560, 128);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(111, 28);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "DIRECCION";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblContacto.Location = new Point(560, 207);
            lblContacto.Margin = new Padding(4, 0, 4, 0);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(111, 28);
            lblContacto.TabIndex = 7;
            lblContacto.Text = "CONTACTO";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(170, 132);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(347, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.None;
            txtDocumento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(170, 290);
            txtDocumento.Margin = new Padding(4, 5, 4, 5);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(347, 27);
            txtDocumento.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(713, 133);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(356, 27);
            txtDireccion.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(170, 210);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(347, 27);
            txtApellido.TabIndex = 2;
            // 
            // txtContacto
            // 
            txtContacto.BorderStyle = BorderStyle.None;
            txtContacto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtContacto.Location = new Point(713, 210);
            txtContacto.Margin = new Padding(4, 5, 4, 5);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(356, 27);
            txtContacto.TabIndex = 3;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoCliente.Location = new Point(560, 287);
            lblTipoCliente.Margin = new Padding(4, 0, 4, 0);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(129, 28);
            lblTipoCliente.TabIndex = 7;
            lblTipoCliente.Text = "TIPO CLIENTE";
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.Location = new Point(713, 285);
            cboTipoCliente.Margin = new Padding(4, 5, 4, 5);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(171, 36);
            cboTipoCliente.TabIndex = 5;
            // 
            // lblAptoFisico
            // 
            lblAptoFisico.AutoSize = true;
            lblAptoFisico.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAptoFisico.Location = new Point(911, 290);
            lblAptoFisico.Margin = new Padding(4, 0, 4, 0);
            lblAptoFisico.Name = "lblAptoFisico";
            lblAptoFisico.Size = new Size(122, 28);
            lblAptoFisico.TabIndex = 10;
            lblAptoFisico.Text = "APTO FISICO";
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(1047, 295);
            chkAptoFisico.Margin = new Padding(4, 5, 4, 5);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(22, 21);
            chkAptoFisico.TabIndex = 6;
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.WhiteSmoke;
            btnInscribir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.Location = new Point(303, 402);
            btnInscribir.Margin = new Padding(4, 5, 4, 5);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(179, 85);
            btnInscribir.TabIndex = 7;
            btnInscribir.Text = "INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.WhiteSmoke;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(623, 402);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(179, 85);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmInscripcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 750);
            Controls.Add(btnLimpiar);
            Controls.Add(btnInscribir);
            Controls.Add(chkAptoFisico);
            Controls.Add(lblAptoFisico);
            Controls.Add(cboTipoCliente);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtContacto);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(lblTipoCliente);
            Controls.Add(lblContacto);
            Controls.Add(lblDireccion);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnVolver);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTipInscripcion;
        private Button btnVolver;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private Label lblDireccion;
        private Label lblContacto;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtContacto;
        private Label lblTipoCliente;
        private ComboBox cboTipoCliente;
        private Label lblAptoFisico;
        private CheckBox chkAptoFisico;
        private Button btnInscribir;
        private Button btnLimpiar;
    }
}