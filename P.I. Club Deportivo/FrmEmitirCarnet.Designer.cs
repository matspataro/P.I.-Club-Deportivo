namespace P.I._Club_Deportivo
{
    partial class FrmEmitirCarnet
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
            btnVolver = new Button();
            btnImprimir = new Button();
            txtDocumento = new TextBox();
            btnBuscar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(301, 39);
            label1.Name = "label1";
            label1.Size = new Size(173, 38);
            label1.TabIndex = 0;
            label1.Text = "Emitir carnet";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(57, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 34);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button1_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(301, 228);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(173, 78);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(179, 124);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(150, 31);
            txtDocumento.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonFace;
            btnBuscar.ForeColor = SystemColors.HotTrack;
            btnBuscar.Location = new Point(335, 122);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(58, 34);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "🔎";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += button2_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Location = new Point(468, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(259, 31);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 127);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 6;
            label2.Text = "Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 255);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 7;
            label3.Text = "Imprimiendo...";
            // 
            // FrmEmitirCarnet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImprimir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnBuscar);
            Controls.Add(txtDocumento);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Name = "FrmEmitirCarnet";
            Text = "FrmEmitirCarnet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVolver;
        private Button btnImprimir;
        private TextBox txtDocumento;
        private Button btnBuscar;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
    }
}