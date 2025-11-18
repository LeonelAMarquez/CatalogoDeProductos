namespace Presentacion
{
    partial class FrmDetalleArticulo
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAntDetalle = new System.Windows.Forms.Button();
            this.btnSigDetalle = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lbTitutloDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(663, 33);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(361, 374);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 60);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(33, 108);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "label2";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(33, 159);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(44, 16);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "label3";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(33, 209);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(44, 16);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "label4";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(33, 258);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(44, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "label5";
            // 
            // btnAntDetalle
            // 
            this.btnAntDetalle.Location = new System.Drawing.Point(719, 439);
            this.btnAntDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAntDetalle.Name = "btnAntDetalle";
            this.btnAntDetalle.Size = new System.Drawing.Size(100, 28);
            this.btnAntDetalle.TabIndex = 6;
            this.btnAntDetalle.Text = "Anterior";
            this.btnAntDetalle.UseVisualStyleBackColor = true;
            // 
            // btnSigDetalle
            // 
            this.btnSigDetalle.Location = new System.Drawing.Point(889, 439);
            this.btnSigDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSigDetalle.Name = "btnSigDetalle";
            this.btnSigDetalle.Size = new System.Drawing.Size(100, 28);
            this.btnSigDetalle.TabIndex = 7;
            this.btnSigDetalle.Text = "Siguiente";
            this.btnSigDetalle.UseVisualStyleBackColor = true;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(149, 297);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.Size = new System.Drawing.Size(392, 24);
            this.tbDescripcion.TabIndex = 9;
            this.tbDescripcion.TabStop = false;
            // 
            // lbTitutloDescripcion
            // 
            this.lbTitutloDescripcion.AutoSize = true;
            this.lbTitutloDescripcion.Location = new System.Drawing.Point(33, 300);
            this.lbTitutloDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitutloDescripcion.Name = "lbTitutloDescripcion";
            this.lbTitutloDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lbTitutloDescripcion.TabIndex = 10;
            this.lbTitutloDescripcion.Text = "Descripcion:";
            // 
            // FrmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 492);
            this.Controls.Add(this.lbTitutloDescripcion);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.btnSigDetalle);
            this.Controls.Add(this.btnAntDetalle);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbImagen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDetalleArticulo";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAntDetalle;
        private System.Windows.Forms.Button btnSigDetalle;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lbTitutloDescripcion;
    }
}