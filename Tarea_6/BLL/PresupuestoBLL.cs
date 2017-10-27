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
        public static Presupuestos Guardar(Presupuestos n)
        {
         Presupuestos retorno = null;
        using (var conn = new DAL.Repositorio<Presupuestos>())
        {
         retorno = conn.Guardar(n);
        }
            return retorno;
       }

        
        public static Presupuestos Buscar(Expression<Func<Presupuestos, bool>> tipo)
        {
            Presupuestos Result = null;
            using (var repositorio = new DAL.Repositorio<Presupuestos>())
            {
                Result = repositorio.Buscar(tipo);



            }
            return Result;
        }
        public static bool Modificar(Presupuestos criterio)
        {
            bool mod = false;
            using (var db = new DAL.Repositorio<Presupuestos>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(Presupuestos existente)
        {
            bool eliminado = false;
            using (var repositorio = new DAL.Repositorio<Presupuestos>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }
        public static List<Presupuestos> GetList(Expression<Func<Presupuestos, bool>> criterio)
        {
            List<Presupuestos> retorno = null;
            using (var conn = new DAL.Repositorio<Presupuestos>())
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
        public static List<Presupuestos> GetListTodo()
        {
            List<Presupuestos> retorno = null;
            using (var conn = new DAL.Repositorio<Presupuestos>())
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
