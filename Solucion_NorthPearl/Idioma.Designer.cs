namespace Solucion_NorthPearl
{
    partial class FrmIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIdioma));
            this.picbxLogoApp = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblEspanol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxLogoApp
            // 
            this.picbxLogoApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbxLogoApp.BackgroundImage")));
            this.picbxLogoApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbxLogoApp.Location = new System.Drawing.Point(229, 3);
            this.picbxLogoApp.Name = "picbxLogoApp";
            this.picbxLogoApp.Size = new System.Drawing.Size(72, 52);
            this.picbxLogoApp.TabIndex = 7;
            this.picbxLogoApp.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(114, 293);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 31);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblIdioma.Location = new System.Drawing.Point(110, 106);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(87, 32);
            this.lblIdioma.TabIndex = 10;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblEspanol
            // 
            this.lblEspanol.AutoSize = true;
            this.lblEspanol.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEspanol.ForeColor = System.Drawing.Color.Blue;
            this.lblEspanol.Location = new System.Drawing.Point(106, 200);
            this.lblEspanol.Name = "lblEspanol";
            this.lblEspanol.Size = new System.Drawing.Size(52, 17);
            this.lblEspanol.TabIndex = 11;
            this.lblEspanol.Text = "Español";
            // 
            // FrmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 491);
            this.ControlBox = false;
            this.Controls.Add(this.lblEspanol);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.picbxLogoApp);
            this.Name = "FrmIdioma";
            this.ShowIcon = false;
            this.Text = "North Pearl";
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogoApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picbxLogoApp;
        private ComboBox comboBox1;
        private Button btnGuardar;
        private Label lblIdioma;
        private Label lblEspanol;
    }
}