﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallePresupuesto
    {
        [Key]
        public int DetalleId { get; set; }
        public string Categoria { get; set; }
        public float Monto { get; set; }
    }
}
