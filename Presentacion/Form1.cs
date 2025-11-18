using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        private List<Articulos> listaArticulos;

        private List<string> _imgUrls = new List<string>();
        private int _imgIndex = 0;
        private const string PLACEHOLDER =
            "https://media.istockphoto.com/id/1180410208/vector/landscape-image-gallery-with-the-photos-stack-up.jpg?s=612x612&w=0&k=20&c=G21-jgMQruADLPDBk7Sf1vVvCEtPiJD3Rf39AeB95yI=";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            if (cboCampo.Items.Count == 0)
            {
                cboCampo.Items.Add("Precio");
                cboCampo.Items.Add("Nombre");
                cboCampo.Items.Add("Descripcion");
            }
        }

        public void cargar()
        {
            ListaArticulos lista = new ListaArticulos();
            listaArticulos = lista.ArticulosListar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Refresh();

            if (dgvArticulos.Columns.Contains("ImagenUrl"))
                dgvArticulos.Columns["ImagenUrl"].Visible = false;

            if (dgvArticulos.Columns.Contains("Codigo"))
                dgvArticulos.Columns["Codigo"].Visible = false;

            if (dgvArticulos.Columns.Contains("Precio"))
                dgvArticulos.Columns["Precio"].Visible = true;

            if (dgvArticulos.Columns.Contains("id"))
                dgvArticulos.Columns["id"].Visible = false;

            if (dgvArticulos.Rows.Count > 0)
                dgvArticulos.Rows[0].Selected = true;

            RefrescarImagenSegunSeleccion(); 
        }

        private void CargarImagenConFallback(string url)
        {
            try
            {
                pictureBoxArticulos.Load(url);
            }
            catch
            {
                string urlDefault = PLACEHOLDER; // === CAMBIO: usar constante
                try
                {
                    pictureBoxArticulos.Load(urlDefault);
                }
                catch
                {
                    pictureBoxArticulos.Image = null;
                }
            }
        }

        private bool EsUrlValida(string url)
        {
            try
            {
                var request = System.Net.WebRequest.Create(url);
                request.Method = "HEAD";
                using (var response = request.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            RefrescarImagenSegunSeleccion();
        }

        private void RefrescarImagenSegunSeleccion()
        {
            _imgUrls.Clear();
            _imgIndex = 0;

            if (dgvArticulos.CurrentRow == null)
            {
                CargarImagenConFallback(PLACEHOLDER);
                ActualizarBotonesImagen();
                return;
            }

            var articuloSeleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            if (articuloSeleccionado?.Imagenes == null || articuloSeleccionado.Imagenes.Count == 0)
            {
                CargarImagenConFallback(PLACEHOLDER);
                ActualizarBotonesImagen();
                return;
            }

            _imgUrls = articuloSeleccionado.Imagenes
                .Select(i => i?.ImagenUrl?.Trim())
                .Where(u => !string.IsNullOrWhiteSpace(u))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            if (_imgUrls.Count == 0)
                CargarImagenConFallback(PLACEHOLDER);
            else
                CargarImagenConFallback(_imgUrls[_imgIndex]);

            ActualizarBotonesImagen();
        }

        private void ActualizarBotonesImagen()
        {
            btnAnterior.Enabled = _imgUrls.Count > 1;
            btnSiguiente.Enabled = _imgUrls.Count > 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaCatalogo alta = new FrmAltaCatalogo();
            alta.ShowDialog();
            cargar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ListaArticulos lista = new ListaArticulos();
            Articulos seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿De verdad querés eliminar este artículo?",
                    "Eliminando",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    lista.Eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (_imgUrls.Count == 0) return;
            _imgIndex = (_imgIndex + 1) % _imgUrls.Count;
            CargarImagenConFallback(_imgUrls[_imgIndex]);
            ActualizarBotonesImagen();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_imgUrls.Count == 0) return;
            _imgIndex = (_imgIndex - 1 + _imgUrls.Count) % _imgUrls.Count;
            CargarImagenConFallback(_imgUrls[_imgIndex]);
            ActualizarBotonesImagen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCampo.SelectedItem == null || cboCriterio.SelectedItem == null)
                {
                    MessageBox.Show("Elegí Campo y Criterio."); return;
                }

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = tbFiltro.Text.Trim();   

                if (campo == "Precio")
                {
                    var esAR = CultureInfo.GetCultureInfo("es-AR");
                    decimal _; 
                    if (!decimal.TryParse(filtro, NumberStyles.Number, esAR, out _)
                     && !decimal.TryParse(filtro, NumberStyles.Number, CultureInfo.InvariantCulture, out _))
                    {
                        MessageBox.Show("Ingrese un número válido (ej: 10000 o 10.000,50).");
                        return;
                    }
                }

                var negocio = new Negocio.ListaArticulos();
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                if (dgvArticulos.Rows.Count > 0) dgvArticulos.Rows[0].Selected = true;
                RefrescarImagenSegunSeleccion();
            }
            catch
            {
                MessageBox.Show("Por favor, seleccione un campo y criterio, e ingrese un filtro válido.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null) return;
            var art = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            using (var f = new FrmDetalleArticulo(art))
                f.ShowDialog();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            
            FrmAltaCatalogo modificar = new FrmAltaCatalogo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void pictureBoxArticulos_Click(object sender, EventArgs e)
        {

        }

        private void lblCriterio_Click(object sender, EventArgs e)
        {

        }
        // comentario para probar main 
    }
}
