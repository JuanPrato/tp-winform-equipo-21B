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
            this.dgvUrls.ClearSelection();
        }

        private void frmItemImages_Load(object sender, EventArgs e)
        {
            this.dgvUrls.DataSource = this.imagenes;
            this.dgvUrls.ClearSelection();
        }

        private void dgvUrls_SelectionChanged(object sender, EventArgs e)
        {
            if (!this.dgvUrls.Focused) return;

            if (this.dgvUrls.CurrentRow == null) return;

            if (this.dgvUrls.CurrentRow.Index >= this.dgvUrls.RowCount) return;

            Imagen img = (Imagen)this.dgvUrls.CurrentRow.DataBoundItem;

            try
            {
                this.pcbImagenes.Load(img.Url);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                MessageBox.Show("Error al cargar la imagen. Se recomienda no usar esa imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
