using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Tarea6Db : DbContext
    {
        public Tarea6Db() : base("name=ConStr")
        {
                
        }
        public virtual DbSet<Presupuesto> presupuesto { get; set; }
        public virtual DbSet<DetallePresupuesto> detalle{ get; set; }
        public virtual DbSet<Categorias>categoria { get; set; }
    }
}
