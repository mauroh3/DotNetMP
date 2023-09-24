using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcasNegocio
    {
        public List <Marcas> listar()
        {
            List <Marcas> lista = new List <Marcas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Descripcion as Marcas from MARCAS");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.Descripcion = (string)datos.Lector["MARCAS"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); } 
        }
    }
}
