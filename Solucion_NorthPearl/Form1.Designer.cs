namespace Solucion_NorthPearl
{
    partial class frmNorthPearl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNorthPearl));
            this.llbIniciarSesion = new System.Windows.Forms.Label();
            this.picbxUsuario = new System.Windows.Forms.PictureBox();
            this.picbxLogoApp = new System.Windows.Forms.PictureBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.llbContrasena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // llbIniciarSesion
            // 
            this.llbIniciarSesion.AutoSize = true;
            this.llbIniciarSesion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llbIniciarSesion.Location = new System.Drawing.Point(87, 9);
            this.llbIniciarSesion.Name = "llbIniciarSesion";
            this.llbIniciarSesion.Size = new System.Drawing.Size(133, 26);
            this.llbIniciarSesion.TabIndex = 0;
            this.llbIniciarSesion.Text = "Iniciar Sesión";
            // 
            // picbxUsuario
            // 
            this.picbxUsuario.Location = new System.Drawing.Point(30, 57);
            this.picbxUsuario.Name = "picbxUsuario";
            this.picbxUsuario.Size = new System.Drawing.Size(100, 50);
            this.picbxUsuario.TabIndex = 1;
            this.picbxUsuario.TabStop = false;
            // 
            // picbxLogoApp
            // 
            this.picbxLogoApp.Location = new System.Drawing.Point(172, 57);
            this.picbxLogoApp.Name = "picbxLogoApp";
            this.picbxLogoApp.Size = new System.Drawing.Size(100, 50);
            this.picbxLogoApp.TabIndex = 2;
            this.picbxLogoApp.TabStop = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.Location = new System.Drawing.Point(30, 154);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(50, 18);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(30, 172);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(233, 23);
            this.txtCorreo.TabIndex = 4;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(30, 236);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(233, 23);
            this.txtContrasena.TabIndex = 6;
            // 
            // llbContrasena
            // 
            this.llbContrasena.AutoSize = true;
            this.llbContrasena.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llbContrasena.Location = new System.Drawing.Point(30, 218);
            this.llbContrasena.Name = "llbContrasena";
            this.llbContrasena.Size = new System.Drawing.Size(77, 18);
            this.llbContrasena.TabIndex = 5;
            this.llbContrasena.Text = "Contraseña";
            // 
            // frmNorthPearl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 402);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.llbContrasena);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.picbxLogoApp);
            this.Controls.Add(this.picbxUsuario);
            this.Controls.Add(this.llbIniciarSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNorthPearl";
            this.Text = "Noth Pearl";
            ((System.ComponentModel.ISupportInitialize)(this.picbxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogoApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label llbIniciarSesion;
        private PictureBox picbxUsuario;
        private PictureBox picbxLogoApp;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private Label llbContrasena;
    }
}