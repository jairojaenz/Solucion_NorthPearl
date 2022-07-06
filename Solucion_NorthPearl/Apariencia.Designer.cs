namespace Solucion_NorthPearl
{
    partial class FrmApariencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApariencia));
            this.lblApariencia = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblClaro = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.picbxLogoApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApariencia
            // 
            this.lblApariencia.AutoSize = true;
            this.lblApariencia.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApariencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblApariencia.Location = new System.Drawing.Point(99, 166);
            this.lblApariencia.Name = "lblApariencia";
            this.lblApariencia.Size = new System.Drawing.Size(101, 26);
            this.lblApariencia.TabIndex = 0;
            this.lblApariencia.Text = "Apariencia";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // lblClaro
            // 
            this.lblClaro.AutoSize = true;
            this.lblClaro.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClaro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblClaro.Location = new System.Drawing.Point(99, 227);
            this.lblClaro.Name = "lblClaro";
            this.lblClaro.Size = new System.Drawing.Size(39, 17);
            this.lblClaro.TabIndex = 2;
            this.lblClaro.Text = "Claro";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(122, 296);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 32);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // picbxLogoApp
            // 
            this.picbxLogoApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbxLogoApp.BackgroundImage")));
            this.picbxLogoApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbxLogoApp.Location = new System.Drawing.Point(87, 35);
            this.picbxLogoApp.Name = "picbxLogoApp";
            this.picbxLogoApp.Size = new System.Drawing.Size(127, 88);
            this.picbxLogoApp.TabIndex = 7;
            this.picbxLogoApp.TabStop = false;
            // 
            // FrmApariencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 491);
            this.ControlBox = false;
            this.Controls.Add(this.picbxLogoApp);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblClaro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblApariencia);
            this.Name = "FrmApariencia";
            this.ShowIcon = false;
            this.Text = "North Pearl";
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogoApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblApariencia;
        private ComboBox comboBox1;
        private Label lblClaro;
        private Button btnGuardar;
        private PictureBox picbxLogoApp;
    }
}