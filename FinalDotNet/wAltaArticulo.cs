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
        private void wAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriasNegocio Categoria = new CategoriasNegocio();
            MarcasNegocio Marca = new MarcasNegocio();

            try
            {
                cboCategoria.DataSource = Categoria.listar();
                cboMarcas.DataSource = Marca.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
