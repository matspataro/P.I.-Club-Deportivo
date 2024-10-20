namespace P.I._Club_Deportivo
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnInscripcion = new Button();
            btnCarnet = new Button();
            btnPago = new Button();
            btnSocios = new Button();
            btnExit = new Button();
            toolTipPrincipal = new ToolTip(components);
            lblIngreso = new Label();
            SuspendLayout();
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = Color.WhiteSmoke;
            btnInscripcion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscripcion.Location = new Point(112, 91);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(218, 78);
            btnInscripcion.TabIndex = 1;
            btnInscripcion.Text = "INSCRIPCION";
            toolTipPrincipal.SetToolTip(btnInscripcion, "Registro de Socios y de Adherentes");
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = Color.WhiteSmoke;
            btnCarnet.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarnet.Location = new Point(469, 91);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(218, 78);
            btnCarnet.TabIndex = 2;
            btnCarnet.Text = "EMITIR CARNET";
            toolTipPrincipal.SetToolTip(btnCarnet, "Emisión de carnets para Socios");
            btnCarnet.UseVisualStyleBackColor = false;
            // 
            // btnPago
            // 
            btnPago.BackColor = Color.WhiteSmoke;
            btnPago.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnPago.Location = new Point(112, 234);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(218, 78);
            btnPago.TabIndex = 3;
            btnPago.Text = "PAGAR CUOTA/ABONO";
            toolTipPrincipal.SetToolTip(btnPago, "Pago de Couta Mensual o Abono Diario");
            btnPago.UseVisualStyleBackColor = false;
            // 
            // btnSocios
            // 
            btnSocios.BackColor = Color.WhiteSmoke;
            btnSocios.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSocios.Location = new Point(469, 234);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new Size(218, 78);
            btnSocios.TabIndex = 4;
            btnSocios.Text = "SOCIOS";
            toolTipPrincipal.SetToolTip(btnSocios, "Listado de Socios y de Socios en mora");
            btnSocios.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(680, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "SALIR";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(28, 12);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(0, 15);
            lblIngreso.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 364);
            Controls.Add(lblIngreso);
            Controls.Add(btnExit);
            Controls.Add(btnSocios);
            Controls.Add(btnPago);
            Controls.Add(btnCarnet);
            Controls.Add(btnInscripcion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Inicio";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscripcion;
        private Button btnCarnet;
        private Button btnPago;
        private Button btnSocios;
        private Button btnExit;
        private ToolTip toolTipPrincipal;
        private Label lblIngreso;
    }
}