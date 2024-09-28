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
    public partial class frmBrandsAdd : Form
    {
        public frmBrandsAdd()
        {
            InitializeComponent();
        }

        private void btnSaveBrand_Click(object sender, EventArgs e)
        {
            try
            {
                string text = this.txtDescripcionMarca.Text;

                if (text.Trim().Length == 0)
                {
                    this.lblError.Text = "Descripción invalida";
                    return;
                }

                BrandBussiness brandBussiness = new BrandBussiness();

                Marca marca = new Marca();

                marca.Descripcion = text.Trim();

                brandBussiness.saveOne(marca);

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
