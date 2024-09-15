namespace GestorStock
{
    partial class frmItemEdit
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
            this.txtNomEdit = new System.Windows.Forms.TextBox();
            this.txtCodEdit = new System.Windows.Forms.TextBox();
            this.txtDescEdit = new System.Windows.Forms.TextBox();
            this.cmbCatEdit = new System.Windows.Forms.ComboBox();
            this.cmbMarEdit = new System.Windows.Forms.ComboBox();
            this.txtPrecioEdit = new System.Windows.Forms.TextBox();
            this.lblCodEdit = new System.Windows.Forms.Label();
            this.lblNomEdit = new System.Windows.Forms.Label();
            this.lblDescEdit = new System.Windows.Forms.Label();
            this.lblMarEdit = new System.Windows.Forms.Label();
            this.lblCatEdit = new System.Windows.Forms.Label();
            this.lblPrecioEdit = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.lstImagenesEdit = new System.Windows.Forms.ListBox();
            this.lblEditImag = new System.Windows.Forms.Label();
            this.lblLeyendaEdit = new System.Windows.Forms.Label();
            this.btnItemImagenEdit = new System.Windows.Forms.Button();
            this.btnItemImagenAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomEdit
            // 
            this.txtNomEdit.Location = new System.Drawing.Point(129, 110);
            this.txtNomEdit.Name = "txtNomEdit";
            this.txtNomEdit.Size = new System.Drawing.Size(176, 20);
            this.txtNomEdit.TabIndex = 0;
            this.txtNomEdit.TextChanged += new System.EventHandler(this.txtNomEdit_TextChanged);
            // 
            // txtCodEdit
            // 
            this.txtCodEdit.Location = new System.Drawing.Point(129, 64);
            this.txtCodEdit.Name = "txtCodEdit";
            this.txtCodEdit.Size = new System.Drawing.Size(176, 20);
            this.txtCodEdit.TabIndex = 1;
            this.txtCodEdit.TextChanged += new System.EventHandler(this.txtCodEdit_TextChanged);
            // 
            // txtDescEdit
            // 
            this.txtDescEdit.Location = new System.Drawing.Point(129, 158);
            this.txtDescEdit.Name = "txtDescEdit";
            this.txtDescEdit.Size = new System.Drawing.Size(176, 20);
            this.txtDescEdit.TabIndex = 2;
            this.txtDescEdit.TextChanged += new System.EventHandler(this.txtDescEdit_TextChanged);
            // 
            // cmbCatEdit
            // 
            this.cmbCatEdit.FormattingEnabled = true;
            this.cmbCatEdit.Location = new System.Drawing.Point(129, 260);
            this.cmbCatEdit.Name = "cmbCatEdit";
            this.cmbCatEdit.Size = new System.Drawing.Size(176, 21);
            this.cmbCatEdit.TabIndex = 3;
            this.cmbCatEdit.SelectedIndexChanged += new System.EventHandler(this.cmbCatEdit_SelectedIndexChanged);
            // 
            // cmbMarEdit
            // 
            this.cmbMarEdit.FormattingEnabled = true;
            this.cmbMarEdit.Location = new System.Drawing.Point(129, 205);
            this.cmbMarEdit.Name = "cmbMarEdit";
            this.cmbMarEdit.Size = new System.Drawing.Size(176, 21);
            this.cmbMarEdit.TabIndex = 4;
            this.cmbMarEdit.SelectedIndexChanged += new System.EventHandler(this.cmbMarEdit_SelectedIndexChanged);
            // 
            // txtPrecioEdit
            // 
            this.txtPrecioEdit.Location = new System.Drawing.Point(129, 312);
            this.txtPrecioEdit.Name = "txtPrecioEdit";
            this.txtPrecioEdit.Size = new System.Drawing.Size(176, 20);
            this.txtPrecioEdit.TabIndex = 5;
            this.txtPrecioEdit.TextChanged += new System.EventHandler(this.txtPrecioEdit_TextChanged);
            // 
            // lblCodEdit
            // 
            this.lblCodEdit.AutoSize = true;
            this.lblCodEdit.Location = new System.Drawing.Point(12, 67);
            this.lblCodEdit.Name = "lblCodEdit";
            this.lblCodEdit.Size = new System.Drawing.Size(40, 13);
            this.lblCodEdit.TabIndex = 6;
            this.lblCodEdit.Text = "Código";
            // 
            // lblNomEdit
            // 
            this.lblNomEdit.AutoSize = true;
            this.lblNomEdit.Location = new System.Drawing.Point(12, 113);
            this.lblNomEdit.Name = "lblNomEdit";
            this.lblNomEdit.Size = new System.Drawing.Size(44, 13);
            this.lblNomEdit.TabIndex = 7;
            this.lblNomEdit.Text = "Nombre";
            // 
            // lblDescEdit
            // 
            this.lblDescEdit.AutoSize = true;
            this.lblDescEdit.Location = new System.Drawing.Point(12, 161);
            this.lblDescEdit.Name = "lblDescEdit";
            this.lblDescEdit.Size = new System.Drawing.Size(63, 13);
            this.lblDescEdit.TabIndex = 8;
            this.lblDescEdit.Text = "Descripción";
            // 
            // lblMarEdit
            // 
            this.lblMarEdit.AutoSize = true;
            this.lblMarEdit.Location = new System.Drawing.Point(12, 208);
            this.lblMarEdit.Name = "lblMarEdit";
            this.lblMarEdit.Size = new System.Drawing.Size(37, 13);
            this.lblMarEdit.TabIndex = 9;
            this.lblMarEdit.Text = "Marca";
            // 
            // lblCatEdit
            // 
            this.lblCatEdit.AutoSize = true;
            this.lblCatEdit.Location = new System.Drawing.Point(12, 263);
            this.lblCatEdit.Name = "lblCatEdit";
            this.lblCatEdit.Size = new System.Drawing.Size(54, 13);
            this.lblCatEdit.TabIndex = 10;
            this.lblCatEdit.Text = "Categoría";
            // 
            // lblPrecioEdit
            // 
            this.lblPrecioEdit.AutoSize = true;
            this.lblPrecioEdit.Location = new System.Drawing.Point(12, 315);
            this.lblPrecioEdit.Name = "lblPrecioEdit";
            this.lblPrecioEdit.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioEdit.TabIndex = 11;
            this.lblPrecioEdit.Text = "Precio";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(15, 514);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(101, 23);
            this.btnSaveEdit.TabIndex = 12;
            this.btnSaveEdit.Text = "Guardar";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(197, 514);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(108, 23);
            this.btnCancelEdit.TabIndex = 13;
            this.btnCancelEdit.Text = "Cancelar";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // lstImagenesEdit
            // 
            this.lstImagenesEdit.FormattingEnabled = true;
            this.lstImagenesEdit.Location = new System.Drawing.Point(129, 355);
            this.lstImagenesEdit.Name = "lstImagenesEdit";
            this.lstImagenesEdit.Size = new System.Drawing.Size(176, 108);
            this.lstImagenesEdit.TabIndex = 14;
            this.lstImagenesEdit.SelectedIndexChanged += new System.EventHandler(this.lstImagenesEdit_SelectedIndexChanged);
            // 
            // lblEditImag
            // 
            this.lblEditImag.AutoSize = true;
            this.lblEditImag.Location = new System.Drawing.Point(12, 375);
            this.lblEditImag.Name = "lblEditImag";
            this.lblEditImag.Size = new System.Drawing.Size(53, 13);
            this.lblEditImag.TabIndex = 15;
            this.lblEditImag.Text = "Imágenes";
            // 
            // lblLeyendaEdit
            // 
            this.lblLeyendaEdit.AutoSize = true;
            this.lblLeyendaEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLeyendaEdit.Location = new System.Drawing.Point(12, 19);
            this.lblLeyendaEdit.Name = "lblLeyendaEdit";
            this.lblLeyendaEdit.Size = new System.Drawing.Size(281, 13);
            this.lblLeyendaEdit.TabIndex = 16;
            this.lblLeyendaEdit.Text = "Modifique los campos deseados y luego guarde el artículo";
            // 
            // btnItemImagenEdit
            // 
            this.btnItemImagenEdit.Location = new System.Drawing.Point(129, 469);
            this.btnItemImagenEdit.Name = "btnItemImagenEdit";
            this.btnItemImagenEdit.Size = new System.Drawing.Size(95, 23);
            this.btnItemImagenEdit.TabIndex = 17;
            this.btnItemImagenEdit.Text = "Editar/Eliminar";
            this.btnItemImagenEdit.UseVisualStyleBackColor = true;
            // 
            // btnItemImagenAdd
            // 
            this.btnItemImagenAdd.Location = new System.Drawing.Point(225, 469);
            this.btnItemImagenAdd.Name = "btnItemImagenAdd";
            this.btnItemImagenAdd.Size = new System.Drawing.Size(80, 23);
            this.btnItemImagenAdd.TabIndex = 18;
            this.btnItemImagenAdd.Text = "Agregar";
            this.btnItemImagenAdd.UseVisualStyleBackColor = true;
            // 
            // frmItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 549);
            this.Controls.Add(this.btnItemImagenAdd);
            this.Controls.Add(this.btnItemImagenEdit);
            this.Controls.Add(this.lblLeyendaEdit);
            this.Controls.Add(this.lblEditImag);
            this.Controls.Add(this.lstImagenesEdit);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.lblPrecioEdit);
            this.Controls.Add(this.lblCatEdit);
            this.Controls.Add(this.lblMarEdit);
            this.Controls.Add(this.lblDescEdit);
            this.Controls.Add(this.lblNomEdit);
            this.Controls.Add(this.lblCodEdit);
            this.Controls.Add(this.txtPrecioEdit);
            this.Controls.Add(this.cmbMarEdit);
            this.Controls.Add(this.cmbCatEdit);
            this.Controls.Add(this.txtDescEdit);
            this.Controls.Add(this.txtCodEdit);
            this.Controls.Add(this.txtNomEdit);
            this.Name = "frmItemEdit";
            this.Text = "Modificar artículo";
            this.Load += new System.EventHandler(this.frmItemEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomEdit;
        private System.Windows.Forms.TextBox txtCodEdit;
        private System.Windows.Forms.TextBox txtDescEdit;
        private System.Windows.Forms.ComboBox cmbCatEdit;
        private System.Windows.Forms.ComboBox cmbMarEdit;
        private System.Windows.Forms.TextBox txtPrecioEdit;
        private System.Windows.Forms.Label lblCodEdit;
        private System.Windows.Forms.Label lblNomEdit;
        private System.Windows.Forms.Label lblDescEdit;
        private System.Windows.Forms.Label lblMarEdit;
        private System.Windows.Forms.Label lblCatEdit;
        private System.Windows.Forms.Label lblPrecioEdit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.ListBox lstImagenesEdit;
        private System.Windows.Forms.Label lblEditImag;
        private System.Windows.Forms.Label lblLeyendaEdit;
        private System.Windows.Forms.Button btnItemImagenEdit;
        private System.Windows.Forms.Button btnItemImagenAdd;
    }
}