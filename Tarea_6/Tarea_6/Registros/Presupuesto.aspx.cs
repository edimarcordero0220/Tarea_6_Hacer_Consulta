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
            
          


        }

        public void SeleccionarCombo()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ToString());
            SqlCommand cmd = new SqlCommand("select Descripcion from Categorias");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            sda.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "FieldName";                            // FieldName of Table in DataBase
            DropDownList1.DataValueField = "FieldName";
            DropDownList1.DataBind();








        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeleccionarCombo();
        }
    }
}
