namespace GestorStock
{
    partial class frmImageLoader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.dvgUrls = new System.Windows.Forms.DataGridView();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUrls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(464, 22);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Por favor elige las images que quieras agregar al articulo";
            // 
            // dvgUrls
            // 
            this.dvgUrls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgUrls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUrls.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgUrls.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dvgUrls.Location = new System.Drawing.Point(16, 66);
            this.dvgUrls.MultiSelect = false;
            this.dvgUrls.Name = "dvgUrls";
            this.dvgUrls.ReadOnly = true;
            this.dvgUrls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgUrls.Size = new System.Drawing.Size(295, 246);
            this.dvgUrls.TabIndex = 1;
            this.dvgUrls.SelectionChanged += new System.EventHandler(this.dvgUrls_SelectionChanged);
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddUrl.Location = new System.Drawing.Point(428, 34);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(135, 27);
            this.btnAddUrl.TabIndex = 2;
            this.btnAddUrl.Text = "Agregar URL";
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbUrl.Location = new System.Drawing.Point(16, 34);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(406, 26);
            this.tbUrl.TabIndex = 3;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(317, 87);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(246, 225);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLoadImage.Location = new System.Drawing.Point(15, 318);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(135, 26);
            this.btnLoadImage.TabIndex = 5;
            this.btnLoadImage.Text = "Cargar imagen";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Location = new System.Drawing.Point(157, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 26);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(317, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Preview";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(428, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 26);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmImageLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 351);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.btnAddUrl);
            this.Controls.Add(this.dvgUrls);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmImageLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar imagenes";
            this.Load += new System.EventHandler(this.frmImageLoader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUrls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dvgUrls;
        private System.Windows.Forms.Button btnAddUrl;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}