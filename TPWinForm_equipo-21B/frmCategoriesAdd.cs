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
    public partial class frmCategoriesAdd : Form
    {
        public frmCategoriesAdd()
        {
            InitializeComponent();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string text = this.tbDescription.Text;

                if (text.Trim().Length == 0)
                {
                    this.lbError.Text = "Descripción invalida";
                    return;
                }

                CategoryBussiness categoryBussiness = new CategoryBussiness();

                Categoria categoria = new Categoria();

                categoria.Descripcion = text.Trim();

                categoryBussiness.saveOne(categoria);

                this.DialogResult = DialogResult.OK;
                this.Close();
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
    }
}
