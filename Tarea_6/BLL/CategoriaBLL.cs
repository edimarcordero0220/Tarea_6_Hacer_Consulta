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
   public  class CategoriaBLL
    {
        public static Categorias Guardar(Categorias nuevo)
        {
            Categorias retorno = null;
            using (var conn = new DAL.Repositorio<Categorias>())
            {
                retorno = conn.Guardar(nuevo);
            }
            return retorno;
        }

        public static Categorias Buscar(Expression<Func<Categorias, bool>> tipo)
        {
            Categorias Result = null;
            using (var repositorio = new DAL.Repositorio<Categorias>())
            {
                Result = repositorio.Buscar(tipo);



            }
            return Result;
        }
        public static bool Modificar(Categorias criterio)
        {
            bool mod = false;
            using (var db = new DAL.Repositorio<Categorias>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(Categorias existente)
        {
            bool eliminado = false;
            using (var repositorio = new DAL.Repositorio<Categorias>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }
        public static List<Categorias> GetList(Expression<Func<Categorias, bool>> criterio)
        {
            List<Categorias> retorno = null;
            using (var conn = new DAL.Repositorio<Categorias>())
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
        public static List<Categorias> GetListTodo()
        {
            List<Categorias> retorno = null;
            using (var conn = new DAL.Repositorio<Categorias>())
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
