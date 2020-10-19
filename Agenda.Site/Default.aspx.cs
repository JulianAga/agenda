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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Contacto> contactos = new List<Contacto>();


            if (!IsPostBack)
            {
                string dataArchivo = File.ReadAllText(ConfigurationManager.AppSettings.Get("PathAgenda"));

                if (dataArchivo != null)
                {
                    contactos = JsonConvert.DeserializeObject<List<Contacto>>(dataArchivo);

                }
            }



            List<Contacto> gridData = new List<Contacto>();

            foreach (Contacto est in contactos)
            {
                gridData.Add(est);
            }

            GridViewConsulta.DataSource = gridData;
            GridViewConsulta.DataBind();

        }

        protected void Consultar(Object sender, EventArgs e)
        {

          
        }

        protected void GridViewConsulta_RowCommand(Object sender, GridViewCommandEventArgs e)
        {

         
            switch (e.CommandName)
            {
                case "Accion1":
                    //Obtenemos el índice del registro seleccionado
                    int indiceBuscar = Convert.ToInt32(e.CommandArgument);
                    //Obtenemos la fila del registro
                    GridViewRow rowBuscar = GridViewConsulta.Rows[indiceBuscar];

                    GridViewConsulta_Accion1(rowBuscar);
                    break;

                case "Accion2":
                    int indiceEditar = Convert.ToInt32(e.CommandArgument);
                    GridViewRow rowEditar = GridViewConsulta.Rows[indiceEditar];

                    GridViewConsulta_Accion2(rowEditar);
                    break;
            }
        }

        protected void GridViewConsulta_Accion1(GridViewRow row)
        {
            Contacto est = new Contacto { apellidoYNombre = row.Cells[0].Text };


            Response.Redirect("IngresarArticulo.aspx");
        }
        protected void GridViewConsulta_Accion2(GridViewRow row)
        {
            //Funcionalidad Acción 2
        }

      

}
}