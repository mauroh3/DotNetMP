﻿
namespace FinalDotNet
{
    partial class VPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.agregarArticulo = new System.Windows.Forms.Button();
            this.DgbArticulos = new System.Windows.Forms.DataGridView();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgbArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarArticulo
            // 
            this.agregarArticulo.AccessibleName = "btnAgregar";
            this.agregarArticulo.Location = new System.Drawing.Point(271, 684);
            this.agregarArticulo.Name = "agregarArticulo";
            this.agregarArticulo.Size = new System.Drawing.Size(130, 27);
            this.agregarArticulo.TabIndex = 0;
            this.agregarArticulo.Tag = "btnAgregar";
            this.agregarArticulo.Text = "Agregar Articulo";
            this.agregarArticulo.UseVisualStyleBackColor = true;
            this.agregarArticulo.Click += new System.EventHandler(this.ListaCompleta_Click);
            // 
            // DgbArticulos
            // 
            this.DgbArticulos.AccessibleName = "DgbArticulos";
            this.DgbArticulos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgbArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgbArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgbArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgbArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgbArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgbArticulos.Location = new System.Drawing.Point(12, 465);
            this.DgbArticulos.MultiSelect = false;
            this.DgbArticulos.Name = "DgbArticulos";
            this.DgbArticulos.RowHeadersWidth = 43;
            this.DgbArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgbArticulos.Size = new System.Drawing.Size(702, 213);
            this.DgbArticulos.TabIndex = 1;
            this.DgbArticulos.SelectionChanged += new System.EventHandler(this.DgbArticulos_SelectionChanged);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(12, 2);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(702, 446);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArticulo.TabIndex = 2;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // VPrincipal
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "DgbArticulos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(725, 716);
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.DgbArticulos);
            this.Controls.Add(this.agregarArticulo);
            this.Name = "VPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPrincipal";
            this.Load += new System.EventHandler(this.VPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgbArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agregarArticulo;
        private System.Windows.Forms.DataGridView DgbArticulos;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
    }
}