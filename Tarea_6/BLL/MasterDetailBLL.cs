using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class MasterDetailBLL
    {
        public static Detalles Guardar(Detalles nuevo)
        {
            Detalles retorno = null;
            using (var conn = new DAL.Repositorio<Detalles>())
            {
                retorno = conn.Guardar(nuevo);
            }
            return retorno;
        }
        public static List<Detalles> GetListTodo()
        {
            List<Detalles> retorno = null;
            using (var conn = new DAL.Repositorio<Detalles>())
            {
                try
                {
                    retorno = conn.GetListTodo().ToList();

                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }

        }
    }
}
