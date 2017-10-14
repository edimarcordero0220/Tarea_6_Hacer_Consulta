using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



namespace Tarea_6.Registros
{
    public partial class Presupuesto : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            cargarCombo();

        }

               public void SeleccionarCombo()
             {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ToString());
            SqlCommand cmd = new SqlCommand("select * from Categorias");
           
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            
            DataSet ds = new DataSet();
        
            sda.Fill(ds);
                    DropDownList1.DataSource = ds;
                   DropDownList1.DataTextField = "Categorias";                            // FieldName of Table in DataBase
                    DropDownList1.DataValueField = "Categorias";
                  DropDownList1.DataBind();
          

            // Agregue los parámetros para SelectCommand.
            
        }
        public void cargarCombo()
        {
            //DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ToString()))
            {
               // string query = "";

                SqlCommand cmd = new SqlCommand("select Descripcion from Categorias", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DropDownList1.DataSource = conn;
               DropDownList1.DataTextField = "CategoriaId";                            // FieldName of Table in DataBase
                DropDownList1.DataValueField = "Descripcion";
                DropDownList1.DataBind();
            }

        }

            protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            //SeleccionarCombo();
        }
    }
}
