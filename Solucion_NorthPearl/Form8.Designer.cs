namespace Solucion_NorthPearl
{
    partial class FrmInfoSitio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoSitio));
            this.txbxNombreSitio = new System.Windows.Forms.TextBox();
            this.txbxNumeroTelefon = new System.Windows.Forms.TextBox();
            this.txbxCorreo = new System.Windows.Forms.TextBox();
            this.txbxNombreDueño = new System.Windows.Forms.TextBox();
            this.txbxUbi = new System.Windows.Forms.TextBox();
            this.txbxHorarioAtencion = new System.Windows.Forms.TextBox();
            this.txbxCostoServicio = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblNombreSitio = new System.Windows.Forms.Label();
            this.lblUbi = new System.Windows.Forms.Label();
            this.lblNombreDuenño = new System.Windows.Forms.Label();
            this.lblHorarioAtención = new System.Windows.Forms.Label();
            this.lblCostoServicio = new System.Windows.Forms.Label();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.picImagenSitio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenSitio)).BeginInit();
            this.SuspendLayout();
            // 
            // txbxNombreSitio
            // 
            this.txbxNombreSitio.Location = new System.Drawing.Point(122, 148);
            this.txbxNombreSitio.Name = "txbxNombreSitio";
            this.txbxNombreSitio.Size = new System.Drawing.Size(170, 23);
            this.txbxNombreSitio.TabIndex = 0;
            // 
            // txbxNumeroTelefon
            // 
            this.txbxNumeroTelefon.Location = new System.Drawing.Point(122, 269);
            this.txbxNumeroTelefon.Name = "txbxNumeroTelefon";
            this.txbxNumeroTelefon.Size = new System.Drawing.Size(170, 23);
            this.txbxNumeroTelefon.TabIndex = 1;
            this.txbxNumeroTelefon.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbxCorreo
            // 
            this.txbxCorreo.Location = new System.Drawing.Point(122, 310);
            this.txbxCorreo.Name = "txbxCorreo";
            this.txbxCorreo.Size = new System.Drawing.Size(170, 23);
            this.txbxCorreo.TabIndex = 2;
            this.txbxCorreo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txbxNombreDueño
            // 
            this.txbxNombreDueño.Location = new System.Drawing.Point(122, 235);
            this.txbxNombreDueño.Name = "txbxNombreDueño";
            this.txbxNombreDueño.Size = new System.Drawing.Size(170, 23);
            this.txbxNombreDueño.TabIndex = 3;
            // 
            // txbxUbi
            // 
            this.txbxUbi.Location = new System.Drawing.Point(122, 189);
            this.txbxUbi.Name = "txbxUbi";
            this.txbxUbi.Size = new System.Drawing.Size(170, 23);
            this.txbxUbi.TabIndex = 4;
            // 
            // txbxHorarioAtencion
            // 
            this.txbxHorarioAtencion.Location = new System.Drawing.Point(122, 346);
            this.txbxHorarioAtencion.Name = "txbxHorarioAtencion";
            this.txbxHorarioAtencion.Size = new System.Drawing.Size(170, 23);
            this.txbxHorarioAtencion.TabIndex = 5;
            // 
            // txbxCostoServicio
            // 
            this.txbxCostoServicio.Location = new System.Drawing.Point(122, 382);
            this.txbxCostoServicio.Name = "txbxCostoServicio";
            this.txbxCostoServicio.Size = new System.Drawing.Size(170, 23);
            this.txbxCostoServicio.TabIndex = 6;
            this.txbxCostoServicio.TextChanged += new System.EventHandler(this.txbxCostoServicio_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Lime;
            this.btnOk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOk.Location = new System.Drawing.Point(248, 411);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(44, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // lblNombreSitio
            // 
            this.lblNombreSitio.AutoSize = true;
            this.lblNombreSitio.Location = new System.Drawing.Point(13, 152);
            this.lblNombreSitio.Name = "lblNombreSitio";
            this.lblNombreSitio.Size = new System.Drawing.Size(98, 15);
            this.lblNombreSitio.TabIndex = 8;
            this.lblNombreSitio.Text = "Nombre del sitio:";
            // 
            // lblUbi
            // 
            this.lblUbi.AutoSize = true;
            this.lblUbi.Location = new System.Drawing.Point(11, 193);
            this.lblUbi.Name = "lblUbi";
            this.lblUbi.Size = new System.Drawing.Size(107, 15);
            this.lblUbi.TabIndex = 9;
            this.lblUbi.Text = "Ubicación del sitio:";
            // 
            // lblNombreDuenño
            // 
            this.lblNombreDuenño.AutoSize = true;
            this.lblNombreDuenño.Location = new System.Drawing.Point(5, 240);
            this.lblNombreDuenño.Name = "lblNombreDuenño";
            this.lblNombreDuenño.Size = new System.Drawing.Size(110, 15);
            this.lblNombreDuenño.TabIndex = 10;
            this.lblNombreDuenño.Text = "Nombre del dueño:";
            // 
            // lblHorarioAtención
            // 
            this.lblHorarioAtención.AutoSize = true;
            this.lblHorarioAtención.Location = new System.Drawing.Point(1, 350);
            this.lblHorarioAtención.Name = "lblHorarioAtención";
            this.lblHorarioAtención.Size = new System.Drawing.Size(115, 15);
            this.lblHorarioAtención.TabIndex = 11;
            this.lblHorarioAtención.Text = "Horario de atención:";
            // 
            // lblCostoServicio
            // 
            this.lblCostoServicio.AutoSize = true;
            this.lblCostoServicio.Location = new System.Drawing.Point(14, 385);
            this.lblCostoServicio.Name = "lblCostoServicio";
            this.lblCostoServicio.Size = new System.Drawing.Size(100, 15);
            this.lblCostoServicio.TabIndex = 12;
            this.lblCostoServicio.Text = "Costo de servicio:";
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Location = new System.Drawing.Point(2, 274);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(117, 15);
            this.lblNumeroTelefono.TabIndex = 13;
            this.lblNumeroTelefono.Text = "Número de teléfono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(12, 316);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(108, 15);
            this.lblCorreo.TabIndex = 14;
            this.lblCorreo.Text = "Correo eléctronico:";
            // 
            // picImagenSitio
            // 
            this.picImagenSitio.BackColor = System.Drawing.Color.Transparent;
            this.picImagenSitio.Location = new System.Drawing.Point(0, 3);
            this.picImagenSitio.Name = "picImagenSitio";
            this.picImagenSitio.Size = new System.Drawing.Size(303, 130);
            this.picImagenSitio.TabIndex = 15;
            this.picImagenSitio.TabStop = false;
            // 
            // FrmInfoSitio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 439);
            this.Controls.Add(this.picImagenSitio);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNumeroTelefono);
            this.Controls.Add(this.lblCostoServicio);
            this.Controls.Add(this.lblHorarioAtención);
            this.Controls.Add(this.lblNombreDuenño);
            this.Controls.Add(this.lblUbi);
            this.Controls.Add(this.lblNombreSitio);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txbxCostoServicio);
            this.Controls.Add(this.txbxHorarioAtencion);
            this.Controls.Add(this.txbxUbi);
            this.Controls.Add(this.txbxNombreDueño);
            this.Controls.Add(this.txbxCorreo);
            this.Controls.Add(this.txbxNumeroTelefon);
            this.Controls.Add(this.txbxNombreSitio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInfoSitio";
            this.Text = "North Pearl";
            this.Load += new System.EventHandler(this.FrmInfoSitio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenSitio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbxNombreSitio;
        private TextBox txbxNumeroTelefon;
        private TextBox txbxCorreo;
        private TextBox txbxNombreDueño;
        private TextBox txbxUbi;
        private TextBox txbxHorarioAtencion;
        private TextBox txbxCostoServicio;
        private Button btnOk;
        private Label lblNombreSitio;
        private Label lblUbi;
        private Label lblNombreDuenño;
        private Label lblHorarioAtención;
        private Label lblCostoServicio;
        private Label lblNumeroTelefono;
        private Label lblCorreo;
        private PictureBox picImagenSitio;
    }
}