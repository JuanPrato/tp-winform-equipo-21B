using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GestorStock
{
    public partial class frmImageLoader : Form
    {

        public List<Imagen> Urls { get; }
        public List<Imagen> LocalFiles { get; }

        public frmImageLoader(string articleName, List<Imagen> defaultUrls, List<Imagen> defaultLocalFiles)
        {
            InitializeComponent();

            this.lbTitle.Text = this.lbTitle.Text + $" {articleName}";
            this.Urls = defaultUrls;
            this.LocalFiles = defaultLocalFiles;
        }

        private void frmImageLoader_Load(object sender, EventArgs e)
        {
            this.dvgUrls.DataSource = Urls;
        }

        private int getTotalImgs()
        {
            return this.Urls.Count + this.LocalFiles.Count;
        }

        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            string text = this.tbUrl.Text.Trim();

            if (string.IsNullOrEmpty(text)) {
                return;
            }

            this.loadNewImage(text);
        }

        private void dvgUrls_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dvgUrls.CurrentRow == null) return;

            if (this.dvgUrls.CurrentRow.Index >= this.dvgUrls.RowCount) return;

            Imagen img = (Imagen)this.dvgUrls.CurrentRow.DataBoundItem;
            
            this.btnDelete.Enabled = true;

            try
            {
                this.pbImage.Load(img.Url);
            } catch(Exception)
            {
                MessageBox.Show("Error al cargar la imagen. Se recomienda no usar esa imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                //loadNewImage(openFileDialog.FileName);
                addNewLocalFile(openFileDialog.FileName);
            }
        }

        private void reloadUrls()
        {
            List<Imagen> list = new List<Imagen>();

            list.AddRange(this.Urls);
            list.AddRange(this.LocalFiles);

            this.dvgUrls.DataSource = list;
        }

        private void loadNewImage(string url)
        {
            Imagen imagen = new Imagen();
            imagen.Url = url;

            this.Urls.Add(imagen);

            reloadUrls();

            this.tbUrl.Text = null;

            this.dvgUrls.CurrentCell = this.dvgUrls.Rows[getTotalImgs() - 1].Cells[0];

        }

        private void addNewLocalFile(string url)
        {
            Imagen imagen = new Imagen();
            imagen.Url = url;

            this.LocalFiles.Add(imagen);

            reloadUrls();

            this.dvgUrls.CurrentCell = this.dvgUrls.Rows[getTotalImgs() - 1].Cells[0];

            this.pbImage.Load(imagen.Url);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dvgUrls.CurrentRow == null) return;

            Imagen img = (Imagen)this.dvgUrls.CurrentRow.DataBoundItem;

            this.Urls.Remove(img);
            this.LocalFiles.Remove(img);

            reloadUrls();
        }
    }
}
