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
    public class DetalleBLL
    {
        public static DetallePresupuesto Guardar(DetallePresupuesto nuevo)
        {
            DetallePresupuesto retorno = null;
            using (var conn = new DAL.Repositorio<DetallePresupuesto>())
            {
                retorno = conn.Guardar(nuevo);
            }
            return retorno;
        }

        public static DetallePresupuesto Buscar(Expression<Func<DetallePresupuesto, bool>> tipo)
        {
            DetallePresupuesto Result = null;
            using (var repositorio = new DAL.Repositorio<DetallePresupuesto>())
            {
                Result = repositorio.Buscar(tipo);



            }
            return Result;
        }
        public static bool Modificar(DetallePresupuesto criterio)
        {
            bool mod = false;
            using (var db = new DAL.Repositorio<DetallePresupuesto>())
            {
                mod = db.Modificar(criterio);
            }

            return mod;

        }

        public static bool Eliminar(DetallePresupuesto existente)
        {
            bool eliminado = false;
            using (var repositorio = new DAL.Repositorio<DetallePresupuesto>())
            {
                eliminado = repositorio.Eliminar(existente);
            }

            return eliminado;

        }
        public static List<DetallePresupuesto> GetList(Expression<Func<DetallePresupuesto, bool>> criterio)
        {
            List<DetallePresupuesto> retorno = null;
            using (var conn = new DAL.Repositorio<DetallePresupuesto>())
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
        public static List<DetallePresupuesto> GetListTodo()
        {
            List<DetallePresupuesto> retorno = null;
            using (var conn = new DAL.Repositorio<DetallePresupuesto>())
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
