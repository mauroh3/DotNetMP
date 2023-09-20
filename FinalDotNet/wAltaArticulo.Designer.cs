namespace FinalDotNet
{
    partial class wAltaArticulo
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
            this.Código = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Categoría = new System.Windows.Forms.Label();
            this.Descripción = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.textCódico = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDescripción = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(40, 128);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(40, 13);
            this.Código.TabIndex = 0;
            this.Código.Text = "Código";
            this.Código.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(40, 213);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // Categoría
            // 
            this.Categoría.AutoSize = true;
            this.Categoría.Location = new System.Drawing.Point(40, 154);
            this.Categoría.Name = "Categoría";
            this.Categoría.Size = new System.Drawing.Size(54, 13);
            this.Categoría.TabIndex = 2;
            this.Categoría.Text = "Categoría";
            // 
            // Descripción
            // 
            this.Descripción.AutoSize = true;
            this.Descripción.Location = new System.Drawing.Point(40, 240);
            this.Descripción.Name = "Descripción";
            this.Descripción.Size = new System.Drawing.Size(63, 13);
            this.Descripción.TabIndex = 3;
            this.Descripción.Text = "Descripción";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(40, 185);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 4;
            this.Marca.Text = "Marca";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(40, 273);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 5;
            this.Precio.Text = "Precio";
            // 
            // textCódico
            // 
            this.textCódico.Location = new System.Drawing.Point(154, 120);
            this.textCódico.Name = "textCódico";
            this.textCódico.Size = new System.Drawing.Size(121, 20);
            this.textCódico.TabIndex = 6;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(154, 182);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(121, 20);
            this.textMarca.TabIndex = 8;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(154, 213);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(121, 20);
            this.textNombre.TabIndex = 9;
            // 
            // textDescripción
            // 
            this.textDescripción.Location = new System.Drawing.Point(154, 240);
            this.textDescripción.Name = "textDescripción";
            this.textDescripción.Size = new System.Drawing.Size(121, 20);
            this.textDescripción.TabIndex = 10;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(154, 266);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(121, 20);
            this.textPrecio.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(43, 351);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(179, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.AccessibleName = "cboCategoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(154, 154);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 14;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.Categorias_SelectedIndexChanged);
            // 
            // wAltaArticulo
            // 
            this.AccessibleName = "wAltaArticulo";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 503);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textDescripción);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textCódico);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.Descripción);
            this.Controls.Add(this.Categoría);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Código);
            this.Name = "wAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.wAltaArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Código;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Categoría;
        private System.Windows.Forms.Label Descripción;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.TextBox textCódico;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDescripción;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboCategoria;
    }
}