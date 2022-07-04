namespace Solucion_NorthPearl
{
    partial class FrmCalificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalificacion));
            this.lblSitioPregunta = new System.Windows.Forms.Label();
            this.picbxLogofrm2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIngreResena = new System.Windows.Forms.Label();
            this.lblGracias = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogofrm2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSitioPregunta
            // 
            this.lblSitioPregunta.AutoSize = true;
            this.lblSitioPregunta.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSitioPregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSitioPregunta.Location = new System.Drawing.Point(30, 90);
            this.lblSitioPregunta.Name = "lblSitioPregunta";
            this.lblSitioPregunta.Size = new System.Drawing.Size(243, 28);
            this.lblSitioPregunta.TabIndex = 0;
            this.lblSitioPregunta.Text = "¿Qué le parecio el sitio?";
            // 
            // picbxLogofrm2
            // 
            this.picbxLogofrm2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbxLogofrm2.BackgroundImage")));
            this.picbxLogofrm2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbxLogofrm2.Location = new System.Drawing.Point(204, 3);
            this.picbxLogofrm2.Name = "picbxLogofrm2";
            this.picbxLogofrm2.Size = new System.Drawing.Size(100, 50);
            this.picbxLogofrm2.TabIndex = 21;
            this.picbxLogofrm2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(3, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 178);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIngreResena
            // 
            this.lblIngreResena.AutoSize = true;
            this.lblIngreResena.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreResena.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngreResena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblIngreResena.Location = new System.Drawing.Point(12, 147);
            this.lblIngreResena.Name = "lblIngreResena";
            this.lblIngreResena.Size = new System.Drawing.Size(141, 22);
            this.lblIngreResena.TabIndex = 23;
            this.lblIngreResena.Text = "Escriba su reseña:";
            // 
            // lblGracias
            // 
            this.lblGracias.AutoSize = true;
            this.lblGracias.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGracias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGracias.Location = new System.Drawing.Point(40, 372);
            this.lblGracias.Name = "lblGracias";
            this.lblGracias.Size = new System.Drawing.Size(235, 23);
            this.lblGracias.TabIndex = 24;
            this.lblGracias.Text = "Gracias por su contribuciòn...";
            this.lblGracias.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviar.Location = new System.Drawing.Point(204, 435);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 28);
            this.btnEnviar.TabIndex = 25;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 491);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblGracias);
            this.Controls.Add(this.lblIngreResena);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picbxLogofrm2);
            this.Controls.Add(this.lblSitioPregunta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCalificacion";
            this.Text = "North Pearl";
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogofrm2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSitioPregunta;
        private PictureBox picbxLogofrm2;
        private TextBox textBox1;
        private Label lblIngreResena;
        private Label lblGracias;
        private Button btnEnviar;
    }
}