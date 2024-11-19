namespace P.I._Club_Deportivo
{
    partial class FrmPago
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
            txtDocumento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            btnSalir = new Button();
            btnVolver = new Button();
            btnBuscar = new Button();
            label3 = new Label();
            label4 = new Label();
            txtApellido = new TextBox();
            txtVencimiento = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtEstado = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(230, 121);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(183, 31);
            txtDocumento.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(294, 27);
            label1.Name = "label1";
            label1.Size = new Size(196, 38);
            label1.TabIndex = 1;
            label1.Text = "Registrar pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 124);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 2;
            label2.Text = "Ingrese documento: ";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(136, 195);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(202, 31);
            txtNombre.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(644, 387);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(48, 387);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 34);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonFace;
            btnBuscar.ForeColor = SystemColors.HotTrack;
            btnBuscar.Location = new Point(419, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(48, 34);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "🔎                                          ";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 195);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 7;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 198);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 8;
            label4.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.InactiveCaption;
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(473, 195);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(247, 31);
            txtApellido.TabIndex = 9;
            // 
            // txtVencimiento
            // 
            txtVencimiento.BackColor = SystemColors.InactiveCaption;
            txtVencimiento.Enabled = false;
            txtVencimiento.Location = new Point(177, 263);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.Size = new Size(161, 31);
            txtVencimiento.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 266);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 11;
            label5.Text = "Vencimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(389, 263);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 12;
            label6.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.InactiveCaption;
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(473, 257);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(247, 31);
            txtEstado.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(321, 325);
            button1.Name = "button1";
            button1.Size = new Size(157, 47);
            button1.TabIndex = 14;
            button1.Text = "Agregar pago";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtEstado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtVencimiento);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnBuscar);
            Controls.Add(btnVolver);
            Controls.Add(btnSalir);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDocumento);
            Name = "FrmPago";
            Text = "FrmPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDocumento;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnSalir;
        private Button btnVolver;
        private Button btnBuscar;
        private Label label3;
        private Label label4;
        private TextBox txtApellido;
        private TextBox txtVencimiento;
        private Label label5;
        private Label label6;
        private TextBox txtEstado;
        private Button button1;
    }
}