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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-19EANE5;Initial Catalog=Tarea6Db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Categorias", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "Descripcion";                            // FieldName of Table in DataBase
            DropDownList1.DataValueField = "CategoriaId";
            DropDownList1.DataBind();
            // FieldName of Table in DataBase
             CategoriaIdTextBox.Text = DropDownList1.SelectedItem.Value;
            




        }


        private void Llenar()
        {
            

        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        protected void CategoriaIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

