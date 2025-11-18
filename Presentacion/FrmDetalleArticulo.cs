using Dominio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmDetalleArticulo : Form
    {
        private readonly Articulos _articulo;
        private List<string> _imgUrls = new List<string>();
        private int _idx = 0;

        private const string PLACEHOLDER =
            "https://media.istockphoto.com/id/1180410208/vector/landscape-image-gallery-with-the-photos-stack-up.jpg?s=612x612&w=0&k=20&c=G21-jgMQruADLPDBk7Sf1vVvCEtPiJD3Rf39AeB95yI=";

        public FrmDetalleArticulo(Articulos articulo)
        {
            InitializeComponent();
            _articulo = articulo ?? throw new ArgumentNullException(nameof(articulo));

            Load += FrmDetalleArticulo_Load;
            btnAntDetalle.Click += btnPrevDetalle_Click;
            btnSigDetalle.Click += btnNextDetalle_Click;

            KeyPreview = true;
            KeyDown += FrmDetalleArticulo_KeyDown;

            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;

            // TextBox de descripción solo lectura (estético opcional)
            tbDescripcion.ReadOnly = true;
            tbDescripcion.Multiline = true;
            tbDescripcion.ScrollBars = ScrollBars.Vertical;
            // tbDescripcion.BorderStyle = BorderStyle.None;   // opcional
            // tbDescripcion.TabStop = false;                  // opcional
        }

        // === NUEVO: helper para armar "Etiqueta: valor" de forma prolija
        private static void SetCapValue(Label lbl, string caption, string value)
        {
            lbl.AutoSize = true;
            lbl.UseMnemonic = false;
            lbl.Text = $"{caption}: {(!string.IsNullOrWhiteSpace(value) ? value : "-")}";
        }

        private void FrmDetalleArticulo_Load(object sender, EventArgs e)
        {
            var esAR = CultureInfo.GetCultureInfo("es-AR");

            // === CAMBIO: ahora mostramos "Etiqueta: valor"
            SetCapValue(lblNombre, "Nombre", _articulo.Nombre);
            SetCapValue(lblCodigo, "Código", _articulo.Codigo);
            SetCapValue(lblMarca, "Marca", _articulo.marcas?.Descripcion);
            SetCapValue(lblCategoria, "Categoría", _articulo.categoria?.Descripcion);
            SetCapValue(lblPrecio, "Precio", _articulo.Precio.ToString("N2", esAR));

            // Descripción (solo texto, en el TextBox)
            tbDescripcion.Text = _articulo.Descripcion ?? "-";

            // Imágenes
            _imgUrls = _articulo.Imagenes?
                .Select(i => (i?.ImagenUrl ?? "").Trim())
                .Where(u => !string.IsNullOrWhiteSpace(u))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList()
                ?? new List<string>();

            _idx = 0;
            MostrarImagenActual();
        }

        private void MostrarImagenActual()
        {
            if (_imgUrls.Count == 0)
                CargarImagenConFallback(PLACEHOLDER);
            else
                CargarImagenConFallback(_imgUrls[_idx]);

            ActualizarBotonesImagenDetalle();
        }

        private void ActualizarBotonesImagenDetalle()
        {
            bool hayMasDeUna = _imgUrls.Count > 1;
            btnAntDetalle.Enabled = hayMasDeUna;
            btnSigDetalle.Enabled = hayMasDeUna;
        }

        private void btnNextDetalle_Click(object sender, EventArgs e)
        {
            if (_imgUrls.Count == 0) return;
            _idx = (_idx + 1) % _imgUrls.Count;
            MostrarImagenActual();
        }

        private void btnPrevDetalle_Click(object sender, EventArgs e)
        {
            if (_imgUrls.Count == 0) return;
            _idx = (_idx - 1 + _imgUrls.Count) % _imgUrls.Count;
            MostrarImagenActual();
        }

        private void FrmDetalleArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (_imgUrls.Count <= 1) return;
            if (e.KeyCode == Keys.Right) btnNextDetalle_Click(sender, e);
            if (e.KeyCode == Keys.Left) btnPrevDetalle_Click(sender, e);
        }

        private void CargarImagenConFallback(string url)
        {
            try { pbImagen.Load(url); }
            catch
            {
                try { pbImagen.Load(PLACEHOLDER); }
                catch { pbImagen.Image = null; }
            }
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e) { }
    }
}
