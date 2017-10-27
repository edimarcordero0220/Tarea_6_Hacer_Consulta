using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BLL;
using DAL;
using System.Data;


namespace Tarea_6
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public bool ValidarUsuario()
        {
            if (UsuarioBLL.GetListaNombre(NombreTextBox.Text).Count() == 0)
            {
                //Label1.Text = "Usuario No Registrado";
                Validar.ShowToastr(this, "Maldito animal", "Debes llenar ambos campos", "warning");


                return false;
            }
            return true;
        }
        public bool ValidarContrasena()
        {
            if (UsuarioBLL.GetContrasena(ClaveTextBox.Text).Count() == 0)
            {
                //Label1.Text="Contrasena Invalida";
                // || NombreTextBox.Text == "" || ClaveTextBox.Text == ""
                Validar.ShowToastr(this, "Maldito animal", "Debes llenar ambos campos", "warning");


                return false;
            }
            return true;
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
         
            if (ValidarUsuario() && ValidarContrasena() == true )
            {
                
                Response.Redirect("Default.aspx");
                Validar.ShowToastr(this, "Muy bien sicario", "Correcto", "Success");



            }
            else
            {

                
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }


}