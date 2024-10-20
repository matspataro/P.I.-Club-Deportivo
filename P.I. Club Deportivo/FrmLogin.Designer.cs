namespace P.I._Club_Deportivo
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            picEscudo = new PictureBox();
            lblIngreso = new Label();
            toolTipIngreso = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picEscudo).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.WhiteSmoke;
            btnLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(342, 243);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(171, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "INGRESAR";
            toolTipIngreso.SetToolTip(btnLogin, "Presione para ingresar");
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(303, 116);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "USUARIO";
            txtUsuario.Size = new Size(264, 18);
            txtUsuario.TabIndex = 1;
            toolTipIngreso.SetToolTip(txtUsuario, "Ingrese su nombre de usuario");
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(303, 178);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "CONTRASEÑA";
            txtPass.Size = new Size(264, 18);
            txtPass.TabIndex = 2;
            toolTipIngreso.SetToolTip(txtPass, "Ingrese su contraseña");
            // 
            // picEscudo
            // 
            picEscudo.Image = (Image)resources.GetObject("picEscudo.Image");
            picEscudo.Location = new Point(62, 85);
            picEscudo.Name = "picEscudo";
            picEscudo.Size = new Size(186, 198);
            picEscudo.TabIndex = 3;
            picEscudo.TabStop = false;
            // 
            // lblIngreso
            // 
            lblIngreso.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngreso.Location = new Point(203, 26);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(255, 43);
            lblIngreso.TabIndex = 4;
            lblIngreso.Text = "INGRESO AL SISTEMA";
            lblIngreso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(639, 320);
            Controls.Add(lblIngreso);
            Controls.Add(picEscudo);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CLUB DEPORTIVO";
            ((System.ComponentModel.ISupportInitialize)picEscudo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private PictureBox picEscudo;
        private Label lblIngreso;
        private ToolTip toolTipIngreso;
    }
}