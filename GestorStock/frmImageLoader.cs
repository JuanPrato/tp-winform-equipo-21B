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
using System.IO;

namespace GestorStock
{
    public partial class frmImageLoader : Form
    {

        public List<Imagen> Urls { get; }

        public frmImageLoader(string articleName, List<Imagen> defaultUrls)
        {
            InitializeComponent();

            this.lbTitle.Text = this.lbTitle.Text + $" {articleName}";
            this.Urls = defaultUrls;
        }

        private void frmImageLoader_Load(object sender, EventArgs e)
        {
            this.dvgUrls.DataSource = Urls;
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

            Imagen img = (Imagen)this.dvgUrls.CurrentRow.DataBoundItem;

            this.pbImage.Load(img.Url);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {

                string fileRoute = Environment.CurrentDirectory + ConfigurationManager.AppSettings["images-folder"] + openFileDialog.SafeFileName;

                File.Copy(openFileDialog.FileName, fileRoute);

                loadNewImage(fileRoute);
            }
        }

        private void loadNewImage(string url)
        {
            Imagen imagen = new Imagen();
            imagen.Url = url;

            this.Urls.Add(imagen);

            // Se usa una lista nueva para que se haga una refresh de lo pintado
            List<Imagen> list = new List<Imagen>();

            list.AddRange(this.Urls);

            this.dvgUrls.DataSource = list;

            this.tbUrl.Text = null;

            this.dvgUrls.CurrentCell = this.dvgUrls.Rows[list.Count - 1].Cells[0];

            this.pbImage.Load(imagen.Url);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
