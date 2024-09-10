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

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryBussiness categoryBussiness = new CategoryBussiness();

            List<Categoria> list = categoryBussiness.getAll();

            Categoria cat = categoryBussiness.getOne("1");

            //this.categoriesList.DataSource = list.Select((i) => i.Descripcion).ToList();
            this.categoriesList.DataSource = new List<string> { cat.Descripcion };
        }
    }
}
