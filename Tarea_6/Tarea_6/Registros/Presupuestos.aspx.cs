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
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
            SqlConnection conetar = new SqlConnection("Data Source=DESKTOP-19EANE5;Initial Catalog=Tarea6Db;Integrated Security=True");
            SqlCommand c = new SqlCommand("select * from Categorias", conetar);
            SqlDataAdapter s = new SqlDataAdapter(c);
            DataSet ds = new DataSet();
            s.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField ="CategoriaId";            
            DropDownList1.DataValueField = "Descripcion";
            DropDownList1.DataBind();
           }


        public void Llenar(Presu p)
        {

            
            p.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            p.Descripcion = DescripcionTextBox.Text;
            p.Monto = Convert.ToInt32(MontoTextBox.Text);
            p.CantidadId = Utilidades.TOINT(DropDownList1.Text);




        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (DescripcionTextBox.Text == "" || MontoTextBox.Text=="")
            {
                Label1.Text = "Llena el campo Nombre de Categorias";
            }
            else
            {
               Entidades.Presu pre = new Entidades.Presu();
                Llenar(pre);
                PresupuestoBLL.Guardar(pre);
                Label1.Text = "Registro con exito";
            }
        }
    }
    }


