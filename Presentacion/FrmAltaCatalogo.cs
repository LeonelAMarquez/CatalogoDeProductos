
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace WindowsFormsApp1
{
    public partial class FrmAltaCatalogo : Form
    {
        private Articulos articulo = null;
        
        public FrmAltaCatalogo()
        {
            InitializeComponent();
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            lstImagenes.SelectedIndexChanged += lstImagenes_SelectedIndexChanged;
            Text = "Agregar Articulo";
        }

        public FrmAltaCatalogo(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
           Close();
        }

        private bool ValidarCampos()
        {
            bool esValido = true;

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                NombreLBL.ForeColor = Color.Red;
                esValido = false;
            }
            else
            {
                NombreLBL.ForeColor = Color.Black;
            }

            // Validar Precio
            if (string.IsNullOrWhiteSpace(TxtPrecio.Text) || !float.TryParse(TxtPrecio.Text, out _))
            {
                PrecioLBL.ForeColor = Color.Red;
                esValido = false;
            }
            else
            {
                PrecioLBL.ForeColor = Color.Black;
            }

            if (CboCategoria.SelectedIndex == -1)
            {
                CategoriaLBL.ForeColor = Color.Red;
                esValido = false;
            }
            else
            {
                CategoriaLBL.ForeColor = Color.Black;
            }

            if (CboMarcas.SelectedIndex == -1)
            {
                MarcaLBL.ForeColor = Color.Red;
                esValido = false;
            }
            else
            {
                MarcaLBL.ForeColor = Color.Black;
            }

            return esValido;
        }



        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale y no continúa si hay error
            }

            //Articulos articulo = new Articulos();
            ListaArticulos articulos = new ListaArticulos();

            try
            {
                if (articulo == null)
                    articulo = new Articulos();
                articulo.Nombre = TxtNombre.Text;
                articulo.Codigo = TxtCodigoArticulo.Text;
                articulo.Descripcion = TxtDescripcion.Text;
                articulo.Precio = float.Parse(TxtPrecio.Text);
                articulo.categoria = (Categorias)CboCategoria.SelectedItem;
                articulo.marcas = (Marcas)CboMarcas.SelectedItem;

                // Limpiamos la lista de imágenes para evitar duplicados si se vuelve a usar
                articulo.Imagenes.Clear();

                // Agregamos todas las imágenes que están en lstImagenes
                foreach (string url in lstImagenes.Items)
                {
                    articulo.Imagenes.Add(new Imagenes { ImagenUrl = url });
                }

                if (articulo.Id != 0)
                {
                    articulos.modificarArticulo(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                { 
                    articulos.agregarArticulo(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                }
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAltaCatalogo_Load(object sender, EventArgs e)
        {
            ListaArticulos lista = new ListaArticulos();
            try
            {
                ListaMarcas listaMarcas = new ListaMarcas();
                ListaCategorias listaCategorias = new ListaCategorias();

                CboMarcas.DataSource = listaMarcas.ListarMarcas();
                CboMarcas.DisplayMember = "Descripcion";
                CboMarcas.ValueMember = "id";

                CboCategoria.DataSource = listaCategorias.ListarCategorias();
                CboCategoria.DisplayMember = "Descripcion";
                CboCategoria.ValueMember = "id";

                if (articulo != null) 
                {
                    TxtNombre.Text = articulo.Nombre;
                    TxtCodigoArticulo.Text = articulo.Codigo;
                    TxtDescripcion.Text = articulo.Descripcion;
                    TxtPrecio.Text = articulo.Precio.ToString();
                    
                    CboCategoria.SelectedValue = articulo.categoria.id;
                    CboMarcas.SelectedValue = articulo.marcas.id;
                    lstImagenes.Items.Clear();
                    foreach (var img in articulo.Imagenes)
                        lstImagenes.Items.Add(img.ImagenUrl);
                    if (lstImagenes.Items.Count > 0) 
                    {
                        string url = lstImagenes.Items[0].ToString();
                        CargarImagenConFallback(url);
                    }
                }


            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void LblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void TxtImagen_Leave(object sender, EventArgs e)
        {
            CargarImagenConFallback(TxtImagen.Text);
        }

        private void CargarImagenConFallback(string url)
        {
            try
            {
                pbvArticulos.Load(url);
            }
            catch
            {
                // Imagen por defecto online
                string urlDefault = "https://media.istockphoto.com/id/1180410208/vector/landscape-image-gallery-with-the-photos-stack-up.jpg?s=612x612&w=0&k=20&c=G21-jgMQruADLPDBk7Sf1vVvCEtPiJD3Rf39AeB95yI=";
                try
                {
                    pbvArticulos.Load(urlDefault);
                }
                catch
                {
                    // Si tampoco carga la imagen online, limpiar la imagen
                    pbvArticulos.Image = null;
                }
            }
        }
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            string url = TxtImagen.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {
                lstImagenes.Items.Add(url);
                TxtImagen.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese una URL válida.");
            }
        }

        private void btnAgregarImagen_Click_1(object sender, EventArgs e)
        {
            string url = TxtImagen.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {
                lstImagenes.Items.Add(url);
                TxtImagen.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese una URL válida (Solo PNG).");
            }
        }

        private void lstImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImagenes.SelectedItem != null)
            {
                string urlSeleccionada = lstImagenes.SelectedItem.ToString();
                CargarImagenConFallback(urlSeleccionada);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbvArticulos_Click(object sender, EventArgs e)
        {

        }
    }
 }

   
