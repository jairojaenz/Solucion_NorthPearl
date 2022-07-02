namespace Solucion_NorthPearl
{
    partial class FrmImagenAmpliada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImagenAmpliada));
            this.picImagenAmpli = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.picbxLogofrm2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenAmpli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogofrm2)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagenAmpli
            // 
            this.picImagenAmpli.Location = new System.Drawing.Point(2, 0);
            this.picImagenAmpli.Name = "picImagenAmpli";
            this.picImagenAmpli.Size = new System.Drawing.Size(299, 334);
            this.picImagenAmpli.TabIndex = 0;
            this.picImagenAmpli.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(12, 347);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 28);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOk.Location = new System.Drawing.Point(242, 438);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // picbxLogofrm2
            // 
            this.picbxLogofrm2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbxLogofrm2.BackgroundImage")));
            this.picbxLogofrm2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbxLogofrm2.Location = new System.Drawing.Point(234, 6);
            this.picbxLogofrm2.Name = "picbxLogofrm2";
            this.picbxLogofrm2.Size = new System.Drawing.Size(67, 37);
            this.picbxLogofrm2.TabIndex = 21;
            this.picbxLogofrm2.TabStop = false;
            this.picbxLogofrm2.Click += new System.EventHandler(this.picbxLogofrm2_Click);
            // 
            // FrmImagenAmpliada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 473);
            this.Controls.Add(this.picbxLogofrm2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.picImagenAmpli);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImagenAmpliada";
            this.Text = "North Pearl";
            ((System.ComponentModel.ISupportInitialize)(this.picImagenAmpli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogofrm2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picImagenAmpli;
        private Label lblNombre;
        private Button btnOk;
        private PictureBox picbxLogofrm2;
    }
}