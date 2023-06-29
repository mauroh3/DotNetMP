using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalDotNet
{
    public partial class VPrincipal : Form
    {
        public VPrincipal()
        {
            InitializeComponent();
        }

        private void DgbArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void VPrincipal_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            DgbArticulos.DataSource = negocio.listar();

        }
    }
}
