namespace Solucion_NorthPearl
{
    partial class frmCambiarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarContrasena));
            this.lblCambiarContrasena = new System.Windows.Forms.Label();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.lblNuevaContrasena = new System.Windows.Forms.Label();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCambiarContrasena
            // 
            this.lblCambiarContrasena.AutoSize = true;
            this.lblCambiarContrasena.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCambiarContrasena.Location = new System.Drawing.Point(57, 105);
            this.lblCambiarContrasena.Name = "lblCambiarContrasena";
            this.lblCambiarContrasena.Size = new System.Drawing.Size(197, 26);
            this.lblCambiarContrasena.TabIndex = 0;
            this.lblCambiarContrasena.Text = "Cambiar Contraseña";
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(57, 188);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.Size = new System.Drawing.Size(197, 23);
            this.txtNuevaContrasena.TabIndex = 1;
            // 
            // lblNuevaContrasena
            // 
            this.lblNuevaContrasena.AutoSize = true;
            this.lblNuevaContrasena.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNuevaContrasena.Location = new System.Drawing.Point(55, 169);
            this.lblNuevaContrasena.Name = "lblNuevaContrasena";
            this.lblNuevaContrasena.Size = new System.Drawing.Size(170, 18);
            this.lblNuevaContrasena.TabIndex = 2;
            this.lblNuevaContrasena.Text = "Escribir Nueva Contraseña";
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(55, 251);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(186, 18);
            this.lblConfirmarContrasena.TabIndex = 4;
            this.lblConfirmarContrasena.Text = "Confirmar Nueva Contraseña";
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(57, 270);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(197, 23);
            this.txtConfirmarContrasena.TabIndex = 3;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 2;
            this.btnGuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(86, 343);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(129, 28);
            this.btnGuardarCambios.TabIndex = 13;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // frmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblConfirmarContrasena);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.Controls.Add(this.lblNuevaContrasena);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Controls.Add(this.lblCambiarContrasena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCambiarContrasena";
            this.Text = "North Pearl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCambiarContrasena;
        private TextBox txtNuevaContrasena;
        private Label lblNuevaContrasena;
        private Label lblConfirmarContrasena;
        private TextBox txtConfirmarContrasena;
        private Button btnGuardarCambios;
    }
}