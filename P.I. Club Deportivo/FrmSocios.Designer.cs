namespace P.I._Club_Deportivo
{
    partial class FrmSocios
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
            cboListadoOpciones = new ComboBox();
            label1 = new Label();
            dgvSocios = new DataGridView();
            conexionBindingSource1 = new BindingSource(components);
            conexionBindingSource = new BindingSource(components);
            label2 = new Label();
            btnVolver = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cboListadoOpciones
            // 
            cboListadoOpciones.FormattingEnabled = true;
            cboListadoOpciones.Location = new Point(249, 89);
            cboListadoOpciones.Name = "cboListadoOpciones";
            cboListadoOpciones.Size = new Size(207, 33);
            cboListadoOpciones.TabIndex = 0;
            cboListadoOpciones.SelectedIndexChanged += cboListadoOpciones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 92);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 1;
            label1.Text = "Seleccione una opción";
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(44, 157);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowHeadersWidth = 62;
            dgvSocios.RowTemplate.Height = 33;
            dgvSocios.Size = new Size(700, 272);
            dgvSocios.TabIndex = 2;
            // 
            // conexionBindingSource1
            // 
            conexionBindingSource1.DataSource = typeof(Datos.Conexion);
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(267, 31);
            label2.Name = "label2";
            label2.Size = new Size(227, 38);
            label2.TabIndex = 3;
            label2.Text = "Listado de socios";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(44, 31);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 34);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(632, 31);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmSocios
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(dgvSocios);
            Controls.Add(label1);
            Controls.Add(cboListadoOpciones);
            Name = "FrmSocios";
            Text = "FrmSocios";
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboListadoOpciones;
        private Label label1;
        private DataGridView dgvSocios;
        private BindingSource conexionBindingSource;
        private Label label2;
        private BindingSource conexionBindingSource1;
        private Button btnVolver;
        private Button btnSalir;
    }
}