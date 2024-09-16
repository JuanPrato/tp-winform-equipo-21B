namespace GestorStock
{
    partial class frmItemImages
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
            this.pcbImagenes = new System.Windows.Forms.PictureBox();
            this.dgvUrls = new System.Windows.Forms.DataGridView();
            this.lblVerImagenes = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrls)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbImagenes
            // 
            this.pcbImagenes.Location = new System.Drawing.Point(276, 51);
            this.pcbImagenes.Name = "pcbImagenes";
            this.pcbImagenes.Size = new System.Drawing.Size(256, 192);
            this.pcbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagenes.TabIndex = 0;
            this.pcbImagenes.TabStop = false;
            // 
            // dgvUrls
            // 
            this.dgvUrls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrls.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUrls.Location = new System.Drawing.Point(12, 51);
            this.dgvUrls.MultiSelect = false;
            this.dgvUrls.Name = "dgvUrls";
            this.dgvUrls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrls.Size = new System.Drawing.Size(248, 192);
            this.dgvUrls.TabIndex = 1;
            this.dgvUrls.SelectionChanged += new System.EventHandler(this.dgvUrls_SelectionChanged);
            // 
            // lblVerImagenes
            // 
            this.lblVerImagenes.AutoSize = true;
            this.lblVerImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVerImagenes.Location = new System.Drawing.Point(12, 18);
            this.lblVerImagenes.Name = "lblVerImagenes";
            this.lblVerImagenes.Size = new System.Drawing.Size(142, 17);
            this.lblVerImagenes.TabIndex = 2;
            this.lblVerImagenes.Text = "Imagenes del artículo";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(428, 259);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmItemImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 294);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblVerImagenes);
            this.Controls.Add(this.dgvUrls);
            this.Controls.Add(this.pcbImagenes);
            this.Name = "frmItemImages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver imágenes";
            this.Load += new System.EventHandler(this.frmItemImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImagenes;
        private System.Windows.Forms.DataGridView dgvUrls;
        private System.Windows.Forms.Label lblVerImagenes;
        private System.Windows.Forms.Button btnVolver;
    }
}