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
using System.IO;
using System.Configuration;

namespace GestorStock
{
    public partial class frmAgregarArticulos : Form
    {

        private List<Imagen> images = new List<Imagen>();
        private List<Imagen> localImages = new List<Imagen>();

        public frmAgregarArticulos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // 0. Guardo los archivos subidos localmente
                saveLocalImages();

                // 1. Crear una instancia de ItemBussiness
                ItemBussiness itemBusiness = new ItemBussiness();

                // 2. Crear un nuevo objeto Articulo
                Articulo art = new Articulo
                {
                    Codigo = tbCodigo.Text,
                    Nombre = tbNombre.Text,
                    Descripcion = tbDescripcion.Text,
                    Marca = new Marca { Id = int.Parse(cmbMarca.SelectedValue.ToString()) }, // Crear instancia de Marca
                    Categoria = new Categoria { Id = int.Parse(cmbCategoria.SelectedValue.ToString()) }, // Crear instancia de Categoria
                    Precio = decimal.Parse(tbPrecio.Text),
                    Urls = this.images
                };

                // 3. Guardar el nuevo objeto en la base de datos
                int result = itemBusiness.saveOne(art);

                // 4. Verificar si se guardó con éxito
                if (result != -1)
                {
                    MessageBox.Show("El artículo se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Hubo un problema al agregar el artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de entrada incorrecto. Por favor, verifica los campos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                // Inicializamos el comboBox de categorías
                CategoryBussiness catBussiness = new CategoryBussiness();
                this.cmbCategoria.DataSource = catBussiness.getAll();
                if(this.cmbCategoria.DataSource != null)
                {
                    this.cmbCategoria.DisplayMember = "Descripcion";
                    this.cmbCategoria.ValueMember = "Id";
                }else
                {
                    this.cmbCategoria.Enabled = false;
                }

                // Inicializamos el comboBox de marcas
                BrandBussiness marBussiness = new BrandBussiness();
                this.cmbMarca.DataSource = marBussiness.getAll();
                if(this.cmbMarca.DataSource != null)
                {
                    this.cmbMarca.DisplayMember = "Descripcion";
                    this.cmbMarca.ValueMember = "Id";
                }
                else
                {
                    this.cmbMarca.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            frmCategoriesAdd modalAddCategory = new frmCategoriesAdd();

            modalAddCategory.ShowDialog();
        }

        private void btnAgregarMar_Click(object sender, EventArgs e)
        {
            frmBrandsAdd modalAddBrand = new frmBrandsAdd();
            modalAddBrand.ShowDialog();
        }

        private void btnAddImages_Click(object sender, EventArgs e)
        {
            frmImageLoader imageLoader = new frmImageLoader(this.tbNombre.Text, this.images, this.localImages);

            if (imageLoader.ShowDialog() != DialogResult.OK) {
                return;
            }

            this.images = imageLoader.Urls;
            this.localImages = imageLoader.LocalFiles;

            this.lvUrls.Items.Clear();

            this.lvUrls.Items.AddRange(this.images.Select(parseImageToItem).ToArray());

            this.lvUrls.Items.AddRange(this.localImages.Select(parseImageToItem).ToArray());

        }
    
        private ListViewItem parseImageToItem(Imagen image)
        {
            ListViewItem item = new ListViewItem();
            item.Text = image.Url;

            return item;
        } 

        private void saveLocalImages()
        {
            string path = Environment.CurrentDirectory + ConfigurationManager.AppSettings["images-folder"];

            foreach (Imagen img in this.localImages)
            {

                string extension = img.Url.Split('.').Last();

                File.Copy(img.Url, path + $"image-{this.tbCodigo.Text.Trim()}-{this.images.Count}.{extension}");
                img.Url = path + $"image-{this.tbCodigo}-{this.images.Count}";
                this.images.Add(img);
            }
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
