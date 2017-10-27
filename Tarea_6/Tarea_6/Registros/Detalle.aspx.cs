using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entidades;



namespace Tarea_6.Registros
{
    public partial class Detalle : System.Web.UI.Page
    {
        public Detalles detalle = null;
        System.Data.DataTable table;
        System.Data.DataRow row;
        protected void Page_Load(object sender, EventArgs e)
        {
            
         
                this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
                SqlConnection conetar = new SqlConnection("Data Source=DESKTOP-19EANE5;Initial Catalog=Tarea6Db;Integrated Security=True");
                SqlCommand c = new SqlCommand("select * from Categorias", conetar);
                SqlDataAdapter s = new SqlDataAdapter(c);
                DataSet ds = new DataSet();
                s.Fill(ds);
                CategoriaDropDownList.DataSource = ds;
                CategoriaDropDownList.DataTextField = "Descripcion";
                CategoriaDropDownList.DataValueField = "CategoriaId";
                CategoriaDropDownList.DataBind();


                table = new System.Data.DataTable();
                table.Columns.Add("Monto", typeof(System.String));
                table.Columns.Add("Categoria", typeof(System.String));

            if (!Page.IsPostBack)
            {
               
            }

        }
        

        private void filldatalist()
        {
            SqlConnection conetar = new SqlConnection("Data Source=DESKTOP-19EANE5;Initial Catalog=Tarea6Db;Integrated Security=True");
            SqlCommand c = new SqlCommand("select * from Categorias", conetar);
            SqlDataAdapter s = new SqlDataAdapter(c);
            DataSet ds = new DataSet();
        }

        public void Llenar(Detalles p)
        {


            p.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            p.Descripcion = DescripcionTextBox.Text;
            p.Monto = Convert.ToInt32(MontoTextBox.Text);
            p.Categoria = CategoriaDropDownList.Text;




        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Detalles pre = new Detalles();
            Llenar(pre);
            MasterDetailBLL.Guardar(pre);
            Label1.Text = "Registro con exito";
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            row = table.NewRow();
            row["Monto"] = MontoTextBox.Text;
            row["Categoria"] = CategoriaDropDownList.Text;
            table.Rows.Add(row);
            GridView1.DataSource = table;
            GridView1.DataBind();
        }

        private void cargarGrilla()
        {
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void CategoriaDataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            filldatalist();
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        protected void AgregarButton_Click1(object sender, EventArgs e)
        {
            row = table.NewRow();
            row["Monto"] = MontoTextBox.Text;
            row["Categoria"] = CategoriaDropDownList.Text;
            table.Rows.Add(row);
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}