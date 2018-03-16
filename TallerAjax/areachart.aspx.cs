using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerAjax.modeloareachart;

namespace TallerAjax
{
    public partial class areachart : System.Web.UI.Page
    {
        List<Producto> lista_productos = new List<Producto>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                Application["ListaProductos"] = lista_productos;
                lista_productos.Add(new Producto { Nombre = "pepsi", Categoria = "BEBIDA", Cantidad = 100 });
                lista_productos.Add(new Producto { Nombre = "dulces", Categoria = "DULCES", Cantidad = 50 });
                lista_productos.Add(new Producto { Nombre = "jugete", Categoria = "JUGETE", Cantidad = 50 });
                lista_productos.Add(new Producto { Nombre = "mouse", Categoria = "ELECTRONICA", Cantidad = 50 });
                GridView1.DataSource = lista_productos;
                GridView1.DataBind();
            }
        }

        protected void btnformulario_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnreporte_Click(object sender, EventArgs e)
        {

            lista_productos = (List<Producto>)Application["ListaProductos"];
            Application["ListaProductos"] = lista_productos;

            MultiView1.ActiveViewIndex = 2;

            


            string categoria = "";
            decimal[] values = new decimal[lista_productos.Count];
            int i = 0;
            foreach (var item in lista_productos)
            {

                categoria = categoria + "," + item.Categoria.ToString();
                values[i] = Convert.ToDecimal(item.Cantidad);
                i++;
            }



            AreaChart1.CategoriesAxis = categoria.Remove(0, 1);
            AreaChart1.Series.Add(new AjaxControlToolkit.AreaChartSeries { Data = values, AreaColor = "#3dc0f4", Name = "Categorias" });

            

        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            lista_productos = (List < Producto >) Application["ListaProductos"];
            lista_productos.Add(new Producto { Nombre = txtnombre.Text, Categoria = txtcategoria.Text, Cantidad = Convert.ToInt32(txtcantidad.Text) });
            Application["ListaProductos"] = lista_productos;

            GridView1.DataSource = lista_productos;
            GridView1.DataBind();
        }
    }
}