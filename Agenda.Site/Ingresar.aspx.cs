using Ingresar;
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
    public partial class Ingresar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string dataArchivo = File.ReadAllText(ConfigurationManager.AppSettings.Get("PathContactos"));

                if (dataArchivo != null)
                {
                    List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(dataArchivo);

                    Session["users"] = usuarios;
                }
            }

        }

        protected void AutenticarLogin(object sender, AuthenticateEventArgs e)
        {
            Usuario usuario = new Usuario { User = IDControlLogin.UserName, Contraseña = IDControlLogin.Password };

            //List<Usuario> credenciales = (List<Usuario>)Application["Credenciales"];
            List<Usuario> credenciales = (List<Usuario>)Session["users"];

            foreach (Usuario credencial in credenciales)
            {
                if (credencial.User.Equals(usuario.User) && credencial.Contraseña.Equals(usuario.Contraseña))
                {
                    Response.Cookies["LoginCookieVar"]["User"] = IDControlLogin.UserName;
                    Response.Cookies["LoginCookieVar"]["Password"] = IDControlLogin.Password;
                    Response.Cookies["LoginCookieVar"]["UltimoAcceso"] = Convert.ToString(DateTime.Now);
                    Session["user"] = IDControlLogin.UserName;
                    Cache["date"] = DateTime.Now;
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}