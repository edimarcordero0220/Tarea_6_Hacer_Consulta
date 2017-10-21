using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;
using DAL;

namespace Tarea_6.Registros
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Llenar(Entidades.Usuarios u)
        {
            u.NombreUsuario = NombreTextBox.Text;
            u.Clave = ClaveTextBox.Text;


        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {

            if (NombreTextBox.Text == "" || ClaveTextBox.Text=="")
            {
                Label1.Text = "Llena los campos señalados con '*'";
            }
            else
            {
               Entidades.Usuarios usu = new Entidades.Usuarios();
                Llenar(usu);
                UsuarioBLL.Guardar(usu);
                Label1.Text = "Registro con exito";
            }
        }
    }
}