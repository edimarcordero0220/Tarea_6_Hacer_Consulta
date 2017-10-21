using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuariosId { get; set; }
        public string  NombreUsuario { get; set; }
        public string Clave { get; set; }
    }
}
