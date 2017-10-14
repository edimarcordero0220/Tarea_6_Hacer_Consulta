using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using DAL;
using BLL;

namespace Tarea_6.Registros
{
    public partial class Categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Llenar(Entidades.Categorias c)
        {
            c.Descripcion = CategoriaTextBox.Text;
           

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (CategoriaTextBox.Text == "")
            {
                Label1.Text = "Llena el campo Nombre de Categorias";
            }
            else
            {
                Categorias categoria = new Categorias();
                Llenar(categoria);
                CategoriaBLL.Guardar(categoria);
                Label1.Text = "Registro con exito";
            }
           

        }

     
    }
}