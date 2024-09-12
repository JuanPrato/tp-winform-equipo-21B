﻿using acceso_datos;
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
    public partial class frmAgregarArticulos : Form
    {
        public frmAgregarArticulos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Crear una instancia de ItemBussiness
                ItemBussiness itemBusiness = new ItemBussiness();

                // 2. Crear un nuevo objeto Articulo
                Articulo art = new Articulo
                {
                    Codigo = tbCodigo.Text,
                    Nombre = tbNombre.Text,
                    Descripcion = tbDescripcion.Text,
                    Marca = new Marca { Id = int.Parse(tbIdMarca.Text) }, // Crear instancia de Marca
                    Categoria = new Categoria { Id = int.Parse(tbIdCat.Text) }, // Crear instancia de Categoria
                    Precio = decimal.Parse(tbPrecio.Text)
                };

                // 3. Guardar el nuevo objeto en la base de datos
                bool result = itemBusiness.saveOne(art);

                // 4. Verificar si se guardó con éxito
                if (result)
                {
                    MessageBox.Show("El artículo se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
