using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    internal class CategoriasNegocio
    {
        public List <Categorias> listar ()
        {
            List <Categorias>lista = new List <Categorias> ();
            AccesoDatos datos = new AccesoDatos ();

            try
            {
                datos.setearConsulta("select Descripcion as CATEGORIA from CATEGORIAS");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Categorias aux = new Categorias ();
                    aux.Descripcion = (string )datos.Lector["CATEGORIA"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex) {

                throw ex;
            }
            finally { datos.cerrarConexion (); }
        }
    }
}
