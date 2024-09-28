using acceso_datos;
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
    public partial class frmItemEdit : Form
    {
        public Articulo artEdit { get; set; }
        public Articulo artAux { get; set; }
        private List<Imagen> localImages = new List<Imagen>();
        public frmItemEdit()
        {
            InitializeComponent();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmItemEdit_Load(object sender, EventArgs e)
        {
            // Inicializo el artículo auxiliar
            this.artAux = new Articulo();
            this.artAux = artEdit;

            // Inicializo combobox de categorías con la categoría seleccionada del artículo a modificar
            CategoryBussiness categoryBussiness = new CategoryBussiness();
            this.cmbCatEdit.DataSource = categoryBussiness.getAll();
            this.cmbCatEdit.SelectedIndex = this.artEdit.Categoria.Id -1;
            this.cmbCatEdit.DisplayMember = "Descripcion";
            this.cmbCatEdit.ValueMember = "Id";

            // Inicializo combobox de marcas con la marca seleccionada del artículo a modificar
            BrandBussiness brandBussiness = new BrandBussiness();
            this.cmbMarEdit.DataSource = brandBussiness.getAll();
            this.cmbMarEdit.SelectedIndex = this.artEdit.Marca.Id -1;
            this.cmbMarEdit.DisplayMember = "Descripcion";
            this.cmbMarEdit.ValueMember = "Id";

            // Inicializo el resto del form con los datos del artículo a modificar
            this.txtCodEdit.Text = this.artEdit.Codigo.ToString();
            this.txtNomEdit.Text = this.artEdit.Nombre.ToString();
            this.txtDescEdit.Text = this.artEdit.Descripcion.ToString();
            this.txtPrecioEdit.Text = this.artEdit.Precio.ToString();
        }

        private void cmbMarEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.artAux.Marca = this.cmbMarEdit.SelectedItem as Marca;
        }

        private void cmbCatEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.artAux.Categoria = this.cmbCatEdit.SelectedItem as Categoria;
        }

        private void txtPrecioEdit_TextChanged(object sender, EventArgs e)
        {
            //this.artAux.Precio = Decimal.Parse(this.txtPrecioEdit.Text);
        }

        private void txtDescEdit_TextChanged(object sender, EventArgs e)
        {
            //this.artAux.Descripcion = this.txtDescEdit.Text;
        }

        private void txtNomEdit_TextChanged(object sender, EventArgs e)
        {
            //this.artAux.Nombre = this.txtNomEdit.Text;
        }

        private void txtCodEdit_TextChanged(object sender, EventArgs e)
        {
            //this.artAux.Codigo = this.txtCodEdit.Text;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizo los valores en mi articulo
                this.artAux.Nombre = this.txtNomEdit.Text;
                this.artAux.Descripcion = this.txtDescEdit.Text;
                this.artAux.Codigo = this.txtCodEdit.Text;
                this.artAux.Precio = Decimal.Parse(this.txtPrecioEdit.Text);
                this.artAux.Categoria = this.cmbCatEdit.SelectedItem as Categoria;
                this.artAux.Marca = this.cmbMarEdit.SelectedItem as Marca;
                ItemBussiness itemBussiness = new ItemBussiness();
                itemBussiness.updateOne(artAux);

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnItemImagenEdit_Click(object sender, EventArgs e)
        {
            frmImageLoader frmImageLoader = new frmImageLoader(this.artAux.Nombre, this.artAux.Urls, this.localImages);
            if (frmImageLoader.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            this.artAux.Urls = frmImageLoader.Urls;
        }
    }
}
