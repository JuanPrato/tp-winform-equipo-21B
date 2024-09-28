using acceso_datos;
using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace GestorStock
{
    public partial class frmPrincipal : Form
    {

        SqlConnection sQLConnection = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Check if images folder exists
            if (!File.Exists(ConfigurationManager.AppSettings["images-folder"]))
            {
                Directory.CreateDirectory(ConfigurationManager.AppSettings["images-folder-name"]);
            }

            this.loadItems();

            this.dgvArticles.ClearSelection();

            this.btnDelete.Enabled = false;
            this.btnModify.Enabled = false;
            this.btnVerImagenes.Enabled = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.loadItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos ventana = new frmAgregarArticulos();
            DialogResult res = ventana.ShowDialog();
            if(res == DialogResult.OK)
                loadItems();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoriesAdd modalAddCategory = new frmCategoriesAdd();

            modalAddCategory.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriesEdit modalEditCategory = new frmCategoriesEdit();
            
            modalEditCategory.ShowDialog();

            ItemBussiness itemBussiness = new ItemBussiness();

            this.dgvArticles.DataSource = itemBussiness.getAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.dgvArticles.CurrentRow != null)
            {
                ItemBussiness itemBus = new ItemBussiness();
                Articulo item = new Articulo();
                item = this.dgvArticles.SelectedRows[0].DataBoundItem as Articulo;
                DialogResult res = MessageBox.Show("¿Estás seguro de eliminar el artículo " + item.Id.ToString());
                if (res == DialogResult.OK)
                {
                    itemBus.deleteOne(item);
                    MessageBox.Show("Artículo " + item.Id.ToString() + " eliminado con éxito.");
                } else
                {
                    return;
                }
            } else
            {
                MessageBox.Show("Debe seleccionar un artículo");
            }
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBrandsAdd modalAddBrand = new frmBrandsAdd();
            modalAddBrand.ShowDialog();
        }

        private void modificarOEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrandsEdit modalEditBrand = new frmBrandsEdit();
            modalEditBrand.ShowDialog();
        }

        private void dgvArticles_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            this.btnDelete.Enabled = true;
            this.btnModify.Enabled = true;
            this.btnVerImagenes.Enabled = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmItemEdit modalEditItem = new frmItemEdit();
            modalEditItem.artEdit = this.dgvArticles.SelectedRows[0].DataBoundItem as Articulo;
            DialogResult res = modalEditItem.ShowDialog();

            if(res == DialogResult.OK)
            {
                this.loadItems();
            }
        }

        private void loadItems()
        {
            string text = this.tbSearch.Text.Trim();
            ItemBussiness itemBussiness = new ItemBussiness();
            List<Articulo> articulos;

            if (text.Length > 0)
            {
                articulos = itemBussiness.getAllFilterByName(this.tbSearch.Text.Trim());

            } else
            {
                articulos = itemBussiness.getAll();
            }

            this.dgvArticles.DataSource = articulos;

            var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
            format.CurrencySymbol = "AR$ ";

            this.dgvArticles.Columns["Precio"].DefaultCellStyle.FormatProvider = format;
            this.dgvArticles.Columns["Precio"].DefaultCellStyle.Format = "C2";
        }

        private void btnVerImagenes_Click(object sender, EventArgs e)
        {
            Articulo ar = this.dgvArticles.SelectedRows[0].DataBoundItem as Articulo;
            frmItemImages itemImages = new frmItemImages(ar.Nombre, ar.Urls);
            itemImages.ShowDialog();
        }
    }
}
