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
              if (Cache["contacto"] != null)
                {
                    Contacto contacto = (Contacto)Cache["contacto"];

                    ApellidoYNombre.Text = contacto.apellidoYNombre;
                    ApellidoYNombre.Enabled = false;
                BtnFilter.Enabled = false;
                BtnFilter.Visible = false;

                }
            if (!IsPostBack)
            {
                string dataArchivo = File.ReadAllText(ConfigurationManager.AppSettings.Get("PathAgenda"));

                Session["contactos"] = JsonConvert.DeserializeObject<List<Contacto>>(dataArchivo);
            }

        }

        protected void btnSalir(object sender, EventArgs e)
        {
            Response.Redirect("VistaContactos.aspx");
        }

        protected void btnGuardar(object sender, EventArgs e)
        {
            contactos = (List<Contacto>)Session["contactos"];

            Contacto contacto = new Contacto();

            contacto.apellidoYNombre = ApellidoYNombre.Text;
            contacto.area = Area.Text;
            contacto.activo = true;
            contacto.celular = cel.Text;
            contacto.direccion = direccion.Text;
            contacto.email = email.Text;
            contacto.fechaDeIngreso = DateTime.Now;
            contacto.localidad = Localidad.Text;
            contacto.skype = skype.Text;
            contacto.telefono = tel.Text;
            contacto.genero = Genero.Text;
            contacto.contactoInterno = CI.Text;
            contacto.organizacion = Org.Text;

            contactos.Add(contacto);

            string pathContactos = ConfigurationManager.AppSettings.Get("PathAgenda");

            if (File.Exists(pathContactos))
            {
                File.WriteAllText(pathContactos, JsonConvert.SerializeObject(contactos));
            }

            Response.Redirect("VistaContactos.aspx");
        }

    
    }
}