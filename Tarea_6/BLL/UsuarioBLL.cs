using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class UsuarioBLL
    {
        public static Usuarios Guardar(Usuarios nuevo)
        {
            Usuarios retorno = null;
            using (var conn = new DAL.Repositorio<Usuarios>())
            {
                retorno = conn.Guardar(nuevo);
            }
            return retorno;
        }

        public static List<Usuarios> GetListTodo()
        {
            List<Usuarios> retorno = null;
            using (var conn = new DAL.Repositorio<Usuarios>())
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
        public static List<Usuarios> GetListaNombre(string tmp)
        {
            List<Usuarios> retorno = null;
            Tarea6Db db = new Tarea6Db();
            using (var conn = new DAL.Repositorio<Usuarios>())
            {
                try
                {
                    retorno = db.usuario.Where(p => p.NombreUsuario == tmp).ToList();

                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }

        }
        public static List<Usuarios> GetContrasena(string tmp)
        {
            List<Usuarios> retorno = null;
            Tarea6Db db = new Tarea6Db();
            using (var conn = new DAL.Repositorio<Usuarios>())
            {
                try
                {
                    retorno = db.usuario.Where(p => p.Clave == tmp).ToList();

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
