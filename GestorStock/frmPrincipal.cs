using acceso_datos;
using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

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
            ItemBussiness itemBussiness = new ItemBussiness();

            List<Articulo> articulos = itemBussiness.getAll();
            

            this.dgvArticles.DataSource = articulos;

            this.dgvArticles.ClearSelection();

            this.btnDelete.Enabled = false;
            this.btnModify.Enabled = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ItemBussiness itemBussiness = new ItemBussiness();

            List<Articulo> articulos = itemBussiness.getAllFilterByName(this.tbSearch.Text.Trim());

            this.dgvArticles.DataSource = articulos;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAgregarArticulos ventana = new frmAgregarArticulos();
            ventana.ShowDialog();
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
                item = (Articulo)this.dgvArticles.CurrentRow.DataBoundItem;
                DialogResult res = MessageBox.Show("¿Estás seguro de eliminar el artículo " + item.Id.ToString());
                if (res == DialogResult.OK)
                {
                    itemBus.deleteOne(item.Id.ToString());
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
    }
}
