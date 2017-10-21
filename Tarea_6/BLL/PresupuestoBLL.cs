using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Linq.Expressions;

namespace BLL
{
    public class PresupuestoBLL
    {
        public static Presu Guardar(Presu n)
        {
         Presu retorno = null;
        using (var conn = new DAL.Repositorio<Presu>())
        {
         retorno = conn.Guardar(n);
        }
            return retorno;
       }

        
        public static Presu Buscar(Expression<Func<Presu, bool>> tipo)
        {
            Presu Result = null;
            using (var repositorio = new DAL.Repositorio<Presu>())
            {
                Result = repositorio.Buscar(tipo);



            }
            return Result;
        }
        public static bool Modificar(Presu criterio)
        {
            bool mod = false;
            using (var db = new DAL.Repositorio<Presu>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(Presu existente)
        {
            bool eliminado = false;
            using (var repositorio = new DAL.Repositorio<Presu>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }
        public static List<Presu> GetList(Expression<Func<Presu, bool>> criterio)
        {
            List<Presu> retorno = null;
            using (var conn = new DAL.Repositorio<Presu>())
            {
                try
                {
                    retorno = conn.GetList(criterio).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }

        }
        public static List<Presu> GetListTodo()
        {
            List<Presu> retorno = null;
            using (var conn = new DAL.Repositorio<Presu>())
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
