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
    public partial class frmCategoriesEdit : Form
    {

        List<Categoria> categorias;
        bool deleteConfirm = false;

        public frmCategoriesEdit()
        {
            InitializeComponent();
        }

        private void frmCategoriesEdit_Load(object sender, EventArgs e)
        {
            CategoryBussiness categoryBussiness = new CategoryBussiness();

            this.categorias = categoryBussiness.getAll();

            this.cbCategories.Items.AddRange(categorias.ToArray());

            this.tbDescription.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = false;
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbDescription.Enabled = true;
            this.btnSave.Enabled = true;
            //this.btnDelete.Enabled = true;

            //this.deleteConfirm = false;

            //this.btnDelete.Text = "Borrar";

            Categoria selectedCat = (Categoria)this.cbCategories.SelectedItem;

            this.tbDescription.Text = selectedCat.Descripcion;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string text = this.tbDescription.Text.Trim();

            if (text.Equals(""))
            {
                lbError.Text = "Descripción invalida";
                return;
            }

            CategoryBussiness categoryBussiness = new CategoryBussiness();

            Categoria selectedCat = (Categoria)this.cbCategories.SelectedItem;

            Categoria updatedCat = new Categoria();

            updatedCat.Id = selectedCat.Id;
            updatedCat.Descripcion = text;

            categoryBussiness.updateOne(updatedCat);

            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // TODO: Ver si vale la pena ya que los items tienen una FK a Categorias;
            if (!this.deleteConfirm) {
                this.deleteConfirm = true;
                this.btnDelete.Text = "Seguro?";
                
                return;
            }

            CategoryBussiness categoryBussiness = new CategoryBussiness();

            Categoria selectedCat = (Categoria)this.cbCategories.SelectedItem;

            categoryBussiness.deleteOne(selectedCat.Id.ToString());

            MessageBox.Show($"Se borro con exito la categoria {selectedCat.Descripcion}");
        }
    }
}
