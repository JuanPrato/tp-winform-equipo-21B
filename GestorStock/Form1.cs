using acceso_datos;
using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GestorStock
{
    public partial class Form1 : Form
    {

        SqlConnection sQLConnection = null;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
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
    }
}
