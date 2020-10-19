using Agenda.Entity.Objetos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda.Site
{
    public partial class IngresarArticulo : System.Web.UI.Page
    {

        List<Contacto> contactos = new List<Contacto>();

        protected void Page_Load(object sender, EventArgs e)
        {
  

            if (!IsPostBack)
            {
                string dataArchivo = File.ReadAllText(ConfigurationManager.AppSettings.Get("PathAgenda"));

                Session["contactos"] = JsonConvert.DeserializeObject<List<Contacto>>(dataArchivo);
            }


        }
        protected void btnGuardar(object sender, EventArgs e)
        {
            contactos = (List<Contacto>)Session["contactos"];

            Contacto contacto = new Contacto();

            contacto.apellidoYNombre = ApellidoYNombre.Text;

            contactos.Add(contacto);

            string pathContactos = ConfigurationManager.AppSettings.Get("PathAgenda");

            if (File.Exists(pathContactos))
            {
                File.WriteAllText(pathContactos, JsonConvert.SerializeObject(contactos));
            }

            Response.Redirect("Default.aspx");
        }
    }
}