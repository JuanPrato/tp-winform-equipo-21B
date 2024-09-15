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
    public partial class frmBrandsEdit : Form
    {
        public frmBrandsEdit()
        {
            InitializeComponent();
        }

        private void frmBrandsEdit_Load(object sender, EventArgs e)
        {
            try
            {
                // Inicializamos el comboBox de marcas
                BrandBussiness brBussiness = new BrandBussiness();
                this.cmbBrandsEdit.DataSource = brBussiness.getAll();
                if (this.cmbBrandsEdit.DataSource != null)
                {
                    this.cmbBrandsEdit.DisplayMember = "Descripcion";
                    this.cmbBrandsEdit.ValueMember = "Id";
                }
                else
                {
                    this.cmbBrandsEdit.Enabled = false;
                    this.txtBrandsEdit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBrandsEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBrandsEdit.Enabled = true;
        }

        private void btnBrandSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Crear una instancia de BrandBussiness
                BrandBussiness brandBusiness = new BrandBussiness();

                // 2. Crear un nuevo objeto Marca
                Marca mar = new Marca
                {
                    Id = int.Parse(this.cmbBrandsEdit.ValueMember),
                    Descripcion = this.txtBrandsEdit.Text
                };

                // 3. Guardar el nuevo objeto en la base de datos
                brandBusiness.updateOne(mar);

                MessageBox.Show("Marca modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de entrada incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrandsEditDelete_Click(object sender, EventArgs e)
        {
            if (this.cmbBrandsEdit.SelectedIndex < 0)
            {
                BrandBussiness brandBus = new BrandBussiness();
                Marca marca = new Marca();
                marca = this.cmbBrandsEdit.SelectedItem as Marca;

                ItemBussiness itemBus = new ItemBussiness();
                List<Articulo> articulos = itemBus.getAll();

                if(articulos.Any(a => a.Marca.Id == marca.Id))
                {
                    MessageBox.Show("No se puede eliminar la marca ya que hay artículos asociados.");
                    return;

                } else
                {
                    DialogResult res = MessageBox.Show("¿Estás seguro de eliminar la marca " + marca.Descripcion.ToString());
                    if (res == DialogResult.OK)
                    {
                        brandBus.deleteOne(marca.Id.ToString());
                        MessageBox.Show("Marca " + marca.Descripcion.ToString() + " eliminada con éxito.");
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una marca");
            }
        }
    }
}
