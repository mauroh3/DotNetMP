
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListaCompleta = new System.Windows.Forms.Button();
            this.DgbArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaCompleta
            // 
            this.ListaCompleta.Location = new System.Drawing.Point(12, 12);
            this.ListaCompleta.Name = "ListaCompleta";
            this.ListaCompleta.Size = new System.Drawing.Size(130, 27);
            this.ListaCompleta.TabIndex = 0;
            this.ListaCompleta.Text = "Lista de productos";
            this.ListaCompleta.UseVisualStyleBackColor = true;
            // 
            // DgbArticulos
            // 
            this.DgbArticulos.AccessibleName = "DgbArticulos";
            this.DgbArticulos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgbArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgbArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.DgbArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgbArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgbArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbArticulos.Location = new System.Drawing.Point(83, 97);
            this.DgbArticulos.Name = "DgbArticulos";
            this.DgbArticulos.Size = new System.Drawing.Size(886, 392);
            this.DgbArticulos.TabIndex = 1;
            this.DgbArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgbArticulos_CellContentClick);
            // 
            // VPrincipal
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "DgbArticulos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1102, 686);
            this.Controls.Add(this.DgbArticulos);
            this.Controls.Add(this.ListaCompleta);
            this.Name = "VPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPrincipal";
            this.Load += new System.EventHandler(this.VPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgbArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListaCompleta;
        private System.Windows.Forms.DataGridView DgbArticulos;
    }
}