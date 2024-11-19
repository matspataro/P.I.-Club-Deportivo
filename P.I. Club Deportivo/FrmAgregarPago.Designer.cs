namespace P.I._Club_Deportivo
{
    partial class FrmAgregarPago
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
            label1 = new Label();
            txtMonto = new TextBox();
            label2 = new Label();
            cboMetodoPago = new ComboBox();
            label3 = new Label();
            btnAceptarPago = new Button();
            btnVolver = new Button();
            label4 = new Label();
            txtTipoCliente = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(309, 38);
            label1.Name = "label1";
            label1.Size = new Size(168, 38);
            label1.TabIndex = 2;
            label1.Text = "Nuevo pago";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = SystemColors.InactiveBorder;
            txtMonto.ForeColor = Color.Black;
            txtMonto.Location = new Point(496, 135);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 31);
            txtMonto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 135);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 4;
            label2.Text = "Monto:";
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.Location = new Point(247, 225);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(182, 33);
            cboMetodoPago.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 228);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 6;
            label3.Text = "Método de pago";
            // 
            // btnAceptarPago
            // 
            btnAceptarPago.BackColor = SystemColors.ButtonHighlight;
            btnAceptarPago.Location = new Point(292, 301);
            btnAceptarPago.Name = "btnAceptarPago";
            btnAceptarPago.Size = new Size(208, 50);
            btnAceptarPago.TabIndex = 7;
            btnAceptarPago.Text = "Aceptar pago";
            btnAceptarPago.UseVisualStyleBackColor = false;
            btnAceptarPago.Click += btnAceptarPago_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(62, 387);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 34);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 135);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 9;
            label4.Text = "Tipo cliente:";
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Enabled = false;
            txtTipoCliente.Location = new Point(205, 135);
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.Size = new Size(150, 31);
            txtTipoCliente.TabIndex = 10;
            // 
            // FrmAgregarPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTipoCliente);
            Controls.Add(label4);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptarPago);
            Controls.Add(label3);
            Controls.Add(cboMetodoPago);
            Controls.Add(label2);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Name = "FrmAgregarPago";
            Text = "FrmAgregarPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtMonto;
        private Label label2;
        private ComboBox cboMetodoPago;
        private Label label3;
        private Button btnAceptarPago;
        private Button btnVolver;
        private Label label4;
        private TextBox txtTipoCliente;
    }
}