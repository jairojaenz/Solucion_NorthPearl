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
            this.picbxLogoApp = new System.Windows.Forms.PictureBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.llbContrasena = new System.Windows.Forms.Label();
            this.lblRecupContra = new System.Windows.Forms.Label();
            this.linklblRecuperar = new System.Windows.Forms.LinkLabel();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblContinuarCon = new System.Windows.Forms.Label();
            this.lblÓ = new System.Windows.Forms.Label();
            this.picbxFacebook = new System.Windows.Forms.PictureBox();
            this.picbxGoogle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogoApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGoogle)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxLogoApp
            // 
            this.picbxLogoApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbxLogoApp.BackgroundImage")));
            this.picbxLogoApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbxLogoApp.Location = new System.Drawing.Point(68, 21);
            this.picbxLogoApp.Name = "picbxLogoApp";
            this.picbxLogoApp.Size = new System.Drawing.Size(164, 111);
            this.picbxLogoApp.TabIndex = 2;
            this.picbxLogoApp.TabStop = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCorreo.Location = new System.Drawing.Point(30, 154);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(50, 18);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Location = new System.Drawing.Point(30, 172);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(233, 23);
            this.txtCorreo.TabIndex = 4;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(30, 225);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(233, 23);
            this.txtContrasena.TabIndex = 6;
            // 
            // llbContrasena
            // 
            this.llbContrasena.AutoSize = true;
            this.llbContrasena.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llbContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llbContrasena.Location = new System.Drawing.Point(30, 207);
            this.llbContrasena.Name = "llbContrasena";
            this.llbContrasena.Size = new System.Drawing.Size(77, 18);
            this.llbContrasena.TabIndex = 5;
            this.llbContrasena.Text = "Contraseña";
            // 
            // lblRecupContra
            // 
            this.lblRecupContra.AutoSize = true;
            this.lblRecupContra.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecupContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecupContra.Location = new System.Drawing.Point(44, 268);
            this.lblRecupContra.Name = "lblRecupContra";
            this.lblRecupContra.Size = new System.Drawing.Size(155, 18);
            this.lblRecupContra.TabIndex = 7;
            this.lblRecupContra.Text = "Olvidaste la contraseña?";
            // 
            // linklblRecuperar
            // 
            this.linklblRecuperar.ActiveLinkColor = System.Drawing.Color.Green;
            this.linklblRecuperar.AutoSize = true;
            this.linklblRecuperar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblRecuperar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linklblRecuperar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linklblRecuperar.Location = new System.Drawing.Point(192, 268);
            this.linklblRecuperar.Name = "linklblRecuperar";
            this.linklblRecuperar.Size = new System.Drawing.Size(113, 18);
            this.linklblRecuperar.TabIndex = 8;
            this.linklblRecuperar.TabStop = true;
            this.linklblRecuperar.Tag = "";
            this.linklblRecuperar.Text = "Recuperar cuenta";
            this.linklblRecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRecuperar_LinkClicked);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.White;
            this.btnCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCuenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrearCuenta.FlatAppearance.BorderSize = 2;
            this.btnCrearCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCrearCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrearCuenta.Location = new System.Drawing.Point(28, 307);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(102, 28);
            this.btnCrearCuenta.TabIndex = 9;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 2;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(166, 307);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(106, 28);
            this.btnIniciarSesion.TabIndex = 10;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblContinuarCon
            // 
            this.lblContinuarCon.AutoSize = true;
            this.lblContinuarCon.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContinuarCon.Location = new System.Drawing.Point(107, 343);
            this.lblContinuarCon.Name = "lblContinuarCon";
            this.lblContinuarCon.Size = new System.Drawing.Size(103, 18);
            this.lblContinuarCon.TabIndex = 11;
            this.lblContinuarCon.Text = "Continuar Con :";
            // 
            // lblÓ
            // 
            this.lblÓ.AutoSize = true;
            this.lblÓ.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblÓ.Location = new System.Drawing.Point(145, 397);
            this.lblÓ.Name = "lblÓ";
            this.lblÓ.Size = new System.Drawing.Size(18, 18);
            this.lblÓ.TabIndex = 13;
            this.lblÓ.Text = "Ó";
            // 
            // picbxFacebook
            // 
            this.picbxFacebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbxFacebook.BackgroundImage")));
            this.picbxFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbxFacebook.Location = new System.Drawing.Point(136, 364);
            this.picbxFacebook.Name = "picbxFacebook";
            this.picbxFacebook.Size = new System.Drawing.Size(35, 30);
            this.picbxFacebook.TabIndex = 15;
            this.picbxFacebook.TabStop = false;
            // 
            // picbxGoogle
            // 
            this.picbxGoogle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbxGoogle.BackgroundImage")));
            this.picbxGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbxGoogle.Location = new System.Drawing.Point(136, 418);
            this.picbxGoogle.Name = "picbxGoogle";
            this.picbxGoogle.Size = new System.Drawing.Size(35, 30);
            this.picbxGoogle.TabIndex = 16;
            this.picbxGoogle.TabStop = false;
            // 
            // frmNorthPearl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(304, 455);
            this.Controls.Add(this.picbxGoogle);
            this.Controls.Add(this.picbxFacebook);
            this.Controls.Add(this.lblÓ);
            this.Controls.Add(this.lblContinuarCon);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.linklblRecuperar);
            this.Controls.Add(this.lblRecupContra);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.llbContrasena);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.picbxLogoApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNorthPearl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noth Pearl";
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogoApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGoogle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox picbxLogoApp;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private Label llbContrasena;
        private Label lblRecupContra;
        private LinkLabel linklblRecuperar;
        private Button btnCrearCuenta;
        private Button btnIniciarSesion;
        private Label lblContinuarCon;
        private Label lblÓ;
        private PictureBox picbxFacebook;
        private PictureBox picbxGoogle;
    }
}