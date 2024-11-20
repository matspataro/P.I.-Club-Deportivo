namespace P.I._Club_Deportivo
{
    partial class FrmListados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListados));
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
            cboListadoOpciones.Location = new Point(345, 86);
            cboListadoOpciones.Margin = new Padding(2);
            cboListadoOpciones.Name = "cboListadoOpciones";
            cboListadoOpciones.Size = new Size(146, 23);
            cboListadoOpciones.TabIndex = 0;
            cboListadoOpciones.SelectedIndexChanged += cboListadoOpciones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 17);
            label1.TabIndex = 1;
            label1.Text = "Seleccione una opción:";
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(11, 122);
            dgvSocios.Margin = new Padding(2);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowHeadersWidth = 62;
            dgvSocios.RowTemplate.Height = 33;
            dgvSocios.Size = new Size(777, 231);
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
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(186, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(433, 37);
            label2.TabIndex = 3;
            label2.Text = "Listado de clientes y vencimientos";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.WhiteSmoke;
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(11, 12);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 40);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.WhiteSmoke;
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(680, 12);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(108, 40);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmListados
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 364);
            Controls.Add(btnSalir);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(dgvSocios);
            Controls.Add(label1);
            Controls.Add(cboListadoOpciones);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FrmListados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Socios";
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