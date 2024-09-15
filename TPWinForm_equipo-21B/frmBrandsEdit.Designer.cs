namespace GestorStock
{
    partial class frmBrandsEdit
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
            this.lblBrandsEdit = new System.Windows.Forms.Label();
            this.cmbBrandsEdit = new System.Windows.Forms.ComboBox();
            this.lblBrandsNewEdit = new System.Windows.Forms.Label();
            this.txtBrandsEdit = new System.Windows.Forms.TextBox();
            this.btnBrandSaveEdit = new System.Windows.Forms.Button();
            this.btnBrandsEditDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrandsEdit
            // 
            this.lblBrandsEdit.AutoSize = true;
            this.lblBrandsEdit.Location = new System.Drawing.Point(9, 25);
            this.lblBrandsEdit.Name = "lblBrandsEdit";
            this.lblBrandsEdit.Size = new System.Drawing.Size(157, 13);
            this.lblBrandsEdit.TabIndex = 0;
            this.lblBrandsEdit.Text = "Seleccione la marca a modificar";
            // 
            // cmbBrandsEdit
            // 
            this.cmbBrandsEdit.FormattingEnabled = true;
            this.cmbBrandsEdit.Location = new System.Drawing.Point(12, 52);
            this.cmbBrandsEdit.Name = "cmbBrandsEdit";
            this.cmbBrandsEdit.Size = new System.Drawing.Size(347, 21);
            this.cmbBrandsEdit.TabIndex = 1;
            this.cmbBrandsEdit.SelectedIndexChanged += new System.EventHandler(this.cmbBrandsEdit_SelectedIndexChanged);
            // 
            // lblBrandsNewEdit
            // 
            this.lblBrandsNewEdit.AutoSize = true;
            this.lblBrandsNewEdit.Location = new System.Drawing.Point(9, 87);
            this.lblBrandsNewEdit.Name = "lblBrandsNewEdit";
            this.lblBrandsNewEdit.Size = new System.Drawing.Size(135, 13);
            this.lblBrandsNewEdit.TabIndex = 2;
            this.lblBrandsNewEdit.Text = "Ingrese nueva descripción:";
            // 
            // txtBrandsEdit
            // 
            this.txtBrandsEdit.Location = new System.Drawing.Point(12, 113);
            this.txtBrandsEdit.Name = "txtBrandsEdit";
            this.txtBrandsEdit.Size = new System.Drawing.Size(347, 20);
            this.txtBrandsEdit.TabIndex = 3;
            // 
            // btnBrandSaveEdit
            // 
            this.btnBrandSaveEdit.Location = new System.Drawing.Point(12, 156);
            this.btnBrandSaveEdit.Name = "btnBrandSaveEdit";
            this.btnBrandSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBrandSaveEdit.TabIndex = 4;
            this.btnBrandSaveEdit.Text = "Guardar";
            this.btnBrandSaveEdit.UseVisualStyleBackColor = true;
            this.btnBrandSaveEdit.Click += new System.EventHandler(this.btnBrandSaveEdit_Click);
            // 
            // btnBrandsEditDelete
            // 
            this.btnBrandsEditDelete.Location = new System.Drawing.Point(284, 156);
            this.btnBrandsEditDelete.Name = "btnBrandsEditDelete";
            this.btnBrandsEditDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBrandsEditDelete.TabIndex = 5;
            this.btnBrandsEditDelete.Text = "Borrar";
            this.btnBrandsEditDelete.UseVisualStyleBackColor = true;
            this.btnBrandsEditDelete.Click += new System.EventHandler(this.btnBrandsEditDelete_Click);
            // 
            // frmBrandsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 203);
            this.Controls.Add(this.btnBrandsEditDelete);
            this.Controls.Add(this.btnBrandSaveEdit);
            this.Controls.Add(this.txtBrandsEdit);
            this.Controls.Add(this.lblBrandsNewEdit);
            this.Controls.Add(this.cmbBrandsEdit);
            this.Controls.Add(this.lblBrandsEdit);
            this.Name = "frmBrandsEdit";
            this.Text = "Editar una marca";
            this.Load += new System.EventHandler(this.frmBrandsEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrandsEdit;
        private System.Windows.Forms.ComboBox cmbBrandsEdit;
        private System.Windows.Forms.Label lblBrandsNewEdit;
        private System.Windows.Forms.TextBox txtBrandsEdit;
        private System.Windows.Forms.Button btnBrandSaveEdit;
        private System.Windows.Forms.Button btnBrandsEditDelete;
    }
}