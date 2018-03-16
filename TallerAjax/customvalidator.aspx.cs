using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerAjax.modelocustomvalidator;
namespace TallerAjax
{
    public partial class customvalidator : System.Web.UI.Page
    {
        List<Persona> lista_personas = new List<Persona>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Application["ListaPersonas"] = lista_personas;
                lista_personas.Add(new Persona { Rut = "1-1", Nombre = "test", Contraseña = "pass", Ocupacion = "vago" });
                GridView1.DataSource = lista_personas;
                GridView1.DataBind();
            }
        }
        

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs ae)
        {
            try
            {
                if (txtcontraseña.Text.Equals(txtconfirmarcontraseña.Text))
                {
                    ae.IsValid = true;
                }
                else
                {
                    ae.IsValid = false;
                }
            }
            catch (Exception)
            {
                ae.IsValid = false;
                throw;
            }
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                lista_personas = (List<Persona>)Application["ListaPersonas"];
                lista_personas.Add(new Persona { Rut = txtrut.Text, Nombre = txtnombre.Text, Contraseña = txtcontraseña.Text,
                    Ocupacion = txtocupacion.Text });
                GridView1.DataSource = lista_personas;
                GridView1.DataBind();
                Application["ListaPersonas"] = lista_personas;
                lbregistro.Text = "Registrado";
            }
        }
    }
}