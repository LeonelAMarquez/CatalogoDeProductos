namespace WindowsFormsApp1
{
    partial class FrmAltaCatalogo
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
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_CodigoArticulo = new System.Windows.Forms.Label();
            this.Txt_Descripcion = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.CboMarcas = new System.Windows.Forms.ComboBox();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.LblMarcas = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblImagen = new System.Windows.Forms.Label();
            this.pbvArticulos = new System.Windows.Forms.PictureBox();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lstImagenes = new System.Windows.Forms.ListBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.NombreLBL = new System.Windows.Forms.Label();
            this.PrecioLBL = new System.Windows.Forms.Label();
            this.CategoriaLBL = new System.Windows.Forms.Label();
            this.MarcaLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(60, 52);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(56, 16);
            this.Lbl_Nombre.TabIndex = 0;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Lbl_CodigoArticulo
            // 
            this.Lbl_CodigoArticulo.AutoSize = true;
            this.Lbl_CodigoArticulo.Location = new System.Drawing.Point(60, 113);
            this.Lbl_CodigoArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_CodigoArticulo.Name = "Lbl_CodigoArticulo";
            this.Lbl_CodigoArticulo.Size = new System.Drawing.Size(95, 16);
            this.Lbl_CodigoArticulo.TabIndex = 1;
            this.Lbl_CodigoArticulo.Text = "CodigoArticulo";
            this.Lbl_CodigoArticulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.AutoSize = true;
            this.Txt_Descripcion.Location = new System.Drawing.Point(60, 171);
            this.Txt_Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(79, 16);
            this.Txt_Descripcion.TabIndex = 2;
            this.Txt_Descripcion.Text = "Descripcion";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(167, 52);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(160, 22);
            this.TxtNombre.TabIndex = 0;
            // 
            // TxtCodigoArticulo
            // 
            this.TxtCodigoArticulo.Location = new System.Drawing.Point(167, 113);
            this.TxtCodigoArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCodigoArticulo.Name = "TxtCodigoArticulo";
            this.TxtCodigoArticulo.Size = new System.Drawing.Size(160, 22);
            this.TxtCodigoArticulo.TabIndex = 1;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(167, 171);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(160, 22);
            this.TxtDescripcion.TabIndex = 2;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(128, 476);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(100, 28);
            this.BtnAceptar.TabIndex = 7;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(279, 476);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 28);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(167, 279);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(160, 22);
            this.TxtPrecio.TabIndex = 4;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(60, 279);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(46, 16);
            this.LblPrecio.TabIndex = 9;
            this.LblPrecio.Text = "Precio";
            this.LblPrecio.Click += new System.EventHandler(this.LblPrecio_Click);
            // 
            // CboMarcas
            // 
            this.CboMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMarcas.FormattingEnabled = true;
            this.CboMarcas.Location = new System.Drawing.Point(167, 396);
            this.CboMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboMarcas.Name = "CboMarcas";
            this.CboMarcas.Size = new System.Drawing.Size(160, 24);
            this.CboMarcas.TabIndex = 6;
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(167, 332);
            this.CboCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(160, 24);
            this.CboCategoria.TabIndex = 5;
            // 
            // LblMarcas
            // 
            this.LblMarcas.AutoSize = true;
            this.LblMarcas.Location = new System.Drawing.Point(60, 396);
            this.LblMarcas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarcas.Name = "LblMarcas";
            this.LblMarcas.Size = new System.Drawing.Size(52, 16);
            this.LblMarcas.TabIndex = 12;
            this.LblMarcas.Text = "Marcas";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(60, 332);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(66, 16);
            this.LblDescripcion.TabIndex = 13;
            this.LblDescripcion.Text = "Categoria";
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Location = new System.Drawing.Point(60, 225);
            this.LblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(52, 16);
            this.LblImagen.TabIndex = 14;
            this.LblImagen.Text = "Imagen";
            // 
            // pbvArticulos
            // 
            this.pbvArticulos.Location = new System.Drawing.Point(586, 52);
            this.pbvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbvArticulos.Name = "pbvArticulos";
            this.pbvArticulos.Size = new System.Drawing.Size(421, 367);
            this.pbvArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbvArticulos.TabIndex = 16;
            this.pbvArticulos.TabStop = false;
            // 
            // TxtImagen
            // 
            this.TxtImagen.Location = new System.Drawing.Point(167, 225);
            this.TxtImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(160, 22);
            this.TxtImagen.TabIndex = 17;
            this.TxtImagen.Leave += new System.EventHandler(this.TxtImagen_Leave);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(415, 229);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(149, 38);
            this.btnAgregarImagen.TabIndex = 18;
            this.btnAgregarImagen.Text = "Agregar_Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click_1);
            // 
            // lstImagenes
            // 
            this.lstImagenes.FormattingEnabled = true;
            this.lstImagenes.ItemHeight = 16;
            this.lstImagenes.Location = new System.Drawing.Point(586, 441);
            this.lstImagenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstImagenes.Name = "lstImagenes";
            this.lstImagenes.Size = new System.Drawing.Size(421, 84);
            this.lstImagenes.TabIndex = 19;
            this.lstImagenes.SelectedIndexChanged += new System.EventHandler(this.lstImagenes_SelectedIndexChanged);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(452, 60);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(0, 16);
            this.LblNombre.TabIndex = 20;
            // 
            // NombreLBL
            // 
            this.NombreLBL.AutoSize = true;
            this.NombreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLBL.Location = new System.Drawing.Point(351, 52);
            this.NombreLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreLBL.Name = "NombreLBL";
            this.NombreLBL.Size = new System.Drawing.Size(28, 36);
            this.NombreLBL.TabIndex = 21;
            this.NombreLBL.Text = "*";
            this.NombreLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrecioLBL
            // 
            this.PrecioLBL.AutoSize = true;
            this.PrecioLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLBL.Location = new System.Drawing.Point(351, 279);
            this.PrecioLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrecioLBL.Name = "PrecioLBL";
            this.PrecioLBL.Size = new System.Drawing.Size(28, 36);
            this.PrecioLBL.TabIndex = 22;
            this.PrecioLBL.Text = "*";
            // 
            // CategoriaLBL
            // 
            this.CategoriaLBL.AutoSize = true;
            this.CategoriaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLBL.Location = new System.Drawing.Point(351, 332);
            this.CategoriaLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriaLBL.Name = "CategoriaLBL";
            this.CategoriaLBL.Size = new System.Drawing.Size(28, 36);
            this.CategoriaLBL.TabIndex = 23;
            this.CategoriaLBL.Text = "*";
            // 
            // MarcaLBL
            // 
            this.MarcaLBL.AutoSize = true;
            this.MarcaLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaLBL.Location = new System.Drawing.Point(351, 396);
            this.MarcaLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MarcaLBL.Name = "MarcaLBL";
            this.MarcaLBL.Size = new System.Drawing.Size(28, 36);
            this.MarcaLBL.TabIndex = 24;
            this.MarcaLBL.Text = "*";
            // 
            // FrmAltaCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 551);
            this.Controls.Add(this.MarcaLBL);
            this.Controls.Add(this.CategoriaLBL);
            this.Controls.Add(this.PrecioLBL);
            this.Controls.Add(this.NombreLBL);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.lstImagenes);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.TxtImagen);
            this.Controls.Add(this.pbvArticulos);
            this.Controls.Add(this.LblImagen);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblMarcas);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.CboMarcas);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCodigoArticulo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Lbl_CodigoArticulo);
            this.Controls.Add(this.Lbl_Nombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAltaCatalogo";
            this.Text = "FrmAltaCatalogo";
            this.Load += new System.EventHandler(this.FrmAltaCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_CodigoArticulo;
        private System.Windows.Forms.Label Txt_Descripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigoArticulo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.ComboBox CboMarcas;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.Label LblMarcas;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblImagen;
        private System.Windows.Forms.PictureBox pbvArticulos;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.ListBox lstImagenes;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label NombreLBL;
        private System.Windows.Forms.Label PrecioLBL;
        private System.Windows.Forms.Label CategoriaLBL;
        private System.Windows.Forms.Label MarcaLBL;
    }
}