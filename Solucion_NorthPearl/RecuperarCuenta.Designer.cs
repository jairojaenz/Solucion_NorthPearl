namespace Solucion_NorthPearl
{
    partial class frmRecuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperar));
            this.lblRecuperarCuenta = new System.Windows.Forms.Label();
            this.picbxLogoFrmRecuperarCuenta = new System.Windows.Forms.PictureBox();
            this.lblModoDeRecuperacion = new System.Windows.Forms.Label();
            this.rbtnCorreo = new System.Windows.Forms.RadioButton();
            this.txtCorreoFrmRecuperarCuenta = new System.Windows.Forms.TextBox();
            this.lblEscrbirCorreo = new System.Windows.Forms.Label();
            this.grpbxSelecModoRecup = new System.Windows.Forms.GroupBox();
            this.rbtnMensaje = new System.Windows.Forms.RadioButton();
            this.lblTlfnFrmRecup = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnviarCodigo = new System.Windows.Forms.Button();
            this.txtIngresarCodigo = new System.Windows.Forms.TextBox();
            this.lblIngreseCodigo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCambiarContra = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogoFrmRecuperarCuenta)).BeginInit();
            this.grpbxSelecModoRecup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecuperarCuenta
            // 
            this.lblRecuperarCuenta.AutoSize = true;
            this.lblRecuperarCuenta.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecuperarCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRecuperarCuenta.Location = new System.Drawing.Point(29, 27);
            this.lblRecuperarCuenta.Name = "lblRecuperarCuenta";
            this.lblRecuperarCuenta.Size = new System.Drawing.Size(144, 22);
            this.lblRecuperarCuenta.TabIndex = 0;
            this.lblRecuperarCuenta.Text = "Recuperar Cuenta";
            // 
            // picbxLogoFrmRecuperarCuenta
            // 
            this.picbxLogoFrmRecuperarCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbxLogoFrmRecuperarCuenta.BackgroundImage")));
            this.picbxLogoFrmRecuperarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbxLogoFrmRecuperarCuenta.Location = new System.Drawing.Point(213, 3);
            this.picbxLogoFrmRecuperarCuenta.Name = "picbxLogoFrmRecuperarCuenta";
            this.picbxLogoFrmRecuperarCuenta.Size = new System.Drawing.Size(89, 50);
            this.picbxLogoFrmRecuperarCuenta.TabIndex = 1;
            this.picbxLogoFrmRecuperarCuenta.TabStop = false;
            // 
            // lblModoDeRecuperacion
            // 
            this.lblModoDeRecuperacion.AutoSize = true;
            this.lblModoDeRecuperacion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModoDeRecuperacion.Location = new System.Drawing.Point(95, 59);
            this.lblModoDeRecuperacion.Name = "lblModoDeRecuperacion";
            this.lblModoDeRecuperacion.Size = new System.Drawing.Size(145, 18);
            this.lblModoDeRecuperacion.TabIndex = 2;
            this.lblModoDeRecuperacion.Text = "Modo de recuperación";
            // 
            // rbtnCorreo
            // 
            this.rbtnCorreo.AutoSize = true;
            this.rbtnCorreo.Checked = true;
            this.rbtnCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnCorreo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnCorreo.Location = new System.Drawing.Point(9, 22);
            this.rbtnCorreo.Name = "rbtnCorreo";
            this.rbtnCorreo.Size = new System.Drawing.Size(173, 22);
            this.rbtnCorreo.TabIndex = 3;
            this.rbtnCorreo.TabStop = true;
            this.rbtnCorreo.Text = "Enviar código por correo";
            this.rbtnCorreo.UseVisualStyleBackColor = true;
            // 
            // txtCorreoFrmRecuperarCuenta
            // 
            this.txtCorreoFrmRecuperarCuenta.Location = new System.Drawing.Point(49, 171);
            this.txtCorreoFrmRecuperarCuenta.Name = "txtCorreoFrmRecuperarCuenta";
            this.txtCorreoFrmRecuperarCuenta.Size = new System.Drawing.Size(191, 23);
            this.txtCorreoFrmRecuperarCuenta.TabIndex = 4;
            // 
            // lblEscrbirCorreo
            // 
            this.lblEscrbirCorreo.AutoSize = true;
            this.lblEscrbirCorreo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEscrbirCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEscrbirCorreo.Location = new System.Drawing.Point(49, 150);
            this.lblEscrbirCorreo.Name = "lblEscrbirCorreo";
            this.lblEscrbirCorreo.Size = new System.Drawing.Size(111, 18);
            this.lblEscrbirCorreo.TabIndex = 5;
            this.lblEscrbirCorreo.Text = "Escriba su correo";
            // 
            // grpbxSelecModoRecup
            // 
            this.grpbxSelecModoRecup.Controls.Add(this.rbtnMensaje);
            this.grpbxSelecModoRecup.Controls.Add(this.rbtnCorreo);
            this.grpbxSelecModoRecup.Location = new System.Drawing.Point(49, 59);
            this.grpbxSelecModoRecup.Name = "grpbxSelecModoRecup";
            this.grpbxSelecModoRecup.Size = new System.Drawing.Size(200, 88);
            this.grpbxSelecModoRecup.TabIndex = 6;
            this.grpbxSelecModoRecup.TabStop = false;
            // 
            // rbtnMensaje
            // 
            this.rbtnMensaje.AutoSize = true;
            this.rbtnMensaje.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnMensaje.Location = new System.Drawing.Point(9, 50);
            this.rbtnMensaje.Name = "rbtnMensaje";
            this.rbtnMensaje.Size = new System.Drawing.Size(184, 22);
            this.rbtnMensaje.TabIndex = 4;
            this.rbtnMensaje.Text = "Enviar código por mensaje";
            this.rbtnMensaje.UseVisualStyleBackColor = true;
            // 
            // lblTlfnFrmRecup
            // 
            this.lblTlfnFrmRecup.AutoSize = true;
            this.lblTlfnFrmRecup.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTlfnFrmRecup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTlfnFrmRecup.Location = new System.Drawing.Point(51, 204);
            this.lblTlfnFrmRecup.Name = "lblTlfnFrmRecup";
            this.lblTlfnFrmRecup.Size = new System.Drawing.Size(125, 18);
            this.lblTlfnFrmRecup.TabIndex = 8;
            this.lblTlfnFrmRecup.Text = "Ingrese su telefono";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 23);
            this.textBox1.TabIndex = 7;
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEnviarCodigo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEnviarCodigo.FlatAppearance.BorderSize = 2;
            this.btnEnviarCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEnviarCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnEnviarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCodigo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviarCodigo.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCodigo.Location = new System.Drawing.Point(95, 265);
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.Size = new System.Drawing.Size(109, 28);
            this.btnEnviarCodigo.TabIndex = 13;
            this.btnEnviarCodigo.Text = "Enviar Código";
            this.btnEnviarCodigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnviarCodigo.UseVisualStyleBackColor = false;
            // 
            // txtIngresarCodigo
            // 
            this.txtIngresarCodigo.Location = new System.Drawing.Point(49, 323);
            this.txtIngresarCodigo.Name = "txtIngresarCodigo";
            this.txtIngresarCodigo.Size = new System.Drawing.Size(191, 23);
            this.txtIngresarCodigo.TabIndex = 14;
            // 
            // lblIngreseCodigo
            // 
            this.lblIngreseCodigo.AutoSize = true;
            this.lblIngreseCodigo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngreseCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIngreseCodigo.Location = new System.Drawing.Point(49, 302);
            this.lblIngreseCodigo.Name = "lblIngreseCodigo";
            this.lblIngreseCodigo.Size = new System.Drawing.Size(113, 18);
            this.lblIngreseCodigo.TabIndex = 15;
            this.lblIngreseCodigo.Text = "Ingrese el código";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 2;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(84, 362);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(129, 28);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar Código";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCambiarContra
            // 
            this.btnCambiarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCambiarContra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCambiarContra.FlatAppearance.BorderSize = 2;
            this.btnCambiarContra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCambiarContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCambiarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContra.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarContra.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContra.Location = new System.Drawing.Point(67, 408);
            this.btnCambiarContra.Name = "btnCambiarContra";
            this.btnCambiarContra.Size = new System.Drawing.Size(165, 28);
            this.btnCambiarContra.TabIndex = 17;
            this.btnCambiarContra.Text = "Ir a cambiar contraseña";
            this.btnCambiarContra.UseVisualStyleBackColor = false;
            this.btnCambiarContra.Click += new System.EventHandler(this.btnCambiarContra_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(95, 452);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 28);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 491);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiarContra);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblIngreseCodigo);
            this.Controls.Add(this.txtIngresarCodigo);
            this.Controls.Add(this.btnEnviarCodigo);
            this.Controls.Add(this.lblTlfnFrmRecup);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpbxSelecModoRecup);
            this.Controls.Add(this.lblEscrbirCorreo);
            this.Controls.Add(this.txtCorreoFrmRecuperarCuenta);
            this.Controls.Add(this.lblModoDeRecuperacion);
            this.Controls.Add(this.picbxLogoFrmRecuperarCuenta);
            this.Controls.Add(this.lblRecuperarCuenta);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecuperar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Cuenta";
            this.Load += new System.EventHandler(this.v_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogoFrmRecuperarCuenta)).EndInit();
            this.grpbxSelecModoRecup.ResumeLayout(false);
            this.grpbxSelecModoRecup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRecuperarCuenta;
        private PictureBox picbxLogoFrmRecuperarCuenta;
        private Label lblModoDeRecuperacion;
        private RadioButton rbtnCorreo;
        private TextBox txtCorreoFrmRecuperarCuenta;
        private Label lblEscrbirCorreo;
        private GroupBox grpbxSelecModoRecup;
        private RadioButton rbtnMensaje;
        private Label lblTlfnFrmRecup;
        private TextBox textBox1;
        private Button btnEnviarCodigo;
        private TextBox txtIngresarCodigo;
        private Label lblIngreseCodigo;
        private Button btnConfirmar;
        private Button btnCambiarContra;
        private Button btnCancelar;
    }
}