using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace FinalDotNet
{
    public partial class wAltaArticulo : Form
    {
        public wAltaArticulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   
            Articulo art = new Articulo();
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                art.Codigo = textCódico.Text;
                //art.Categoria = textCategoría.Text;
                art.Marca = textMarca.Text;
                art.Nombre = textNombre.Text;
                art.Descripcion = textDescripción.Text;
                art.Precio = int.Parse(textPrecio.Text);

                negocio.agregar(art);
                MessageBox.Show("Agregado ;)");
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriasNegocio Categoria = new CategoriasNegocio();

            try
            {
                cboCategoria.DataSource = Categoria.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
