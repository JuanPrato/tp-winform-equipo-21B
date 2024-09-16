using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorStock
{
    public partial class frmItemImages : Form
    {
        List<Imagen> imagenes { get; set; }
        public frmItemImages(string articleName, List<Imagen> urls)
        {
            InitializeComponent();

            this.lblVerImagenes.Text = "Imagenes del artículo " + articleName;
            this.imagenes = urls;
        }

        private void frmItemImages_Load(object sender, EventArgs e)
        {
            this.dgvUrls.DataSource = this.imagenes;
        }

        private void dgvUrls_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvUrls.CurrentRow == null) return;

            if (this.dgvUrls.CurrentRow.Index >= this.dgvUrls.RowCount) return;

            Imagen img = (Imagen)this.dgvUrls.CurrentRow.DataBoundItem;

            try
            {
                this.pcbImagenes.Load(img.Url);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la imagen. Se recomienda no usar esa imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
