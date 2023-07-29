using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace FinalDotNet
{
    public partial class VPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        public VPrincipal()
        {
            InitializeComponent();
        }

        private void VPrincipal_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            listaArticulos = negocio.listar();
            DgbArticulos.DataSource = listaArticulos;
            DgbArticulos.Columns["ImagenUrl"].Visible = false;
            cargarImagen(listaArticulos[0].ImagenUrl);

        }

        private void DgbArticulos_SelectionChanged(object sender, EventArgs e)
        {

            Articulo seleccionado = (Articulo)DgbArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen) 
        {
            try
            {

                pictureBoxArticulo.Load(imagen);

            }
            catch (Exception ex)
            {

                pictureBoxArticulo.Load("https://media.tenor.com/PXOXwsJKbSYAAAAM/where-you.gif");
            }
        }
    }
}
