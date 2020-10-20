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
    public partial class VistaContactos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Consultar(Object sender, EventArgs e)
        {

            List<Contacto> contactos = new List<Contacto>();
      
                string dataArchivo = File.ReadAllText(ConfigurationManager.AppSettings.Get("PathAgenda"));

                if (dataArchivo != null)
                {
                    contactos = JsonConvert.DeserializeObject<List<Contacto>>(dataArchivo);

                }
            

            List<Contacto> gridData = new List<Contacto>();

            foreach (Contacto contacto in contactos)
            {

                gridData.Add(contacto);

            }

            GridViewConsulta.DataSource = gridData;
            GridViewConsulta.DataBind();
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
            Contacto contacto = new Contacto { 
                apellidoYNombre = row.Cells[2].Text,
                genero = row.Cells[3].Text,
                pais = row.Cells[4].Text,
                localidad = row.Cells[5].Text,
                contactoInterno = row.Cells[6].Text,
                organizacion = row.Cells[7].Text,
                area = row.Cells[8].Text,
                fechaDeIngreso = DateTime.Now,
                activo = true,
                direccion = row.Cells[11].Text,
                telefono = row.Cells[12].Text,
                celular = row.Cells[13].Text,
                email = row.Cells[14].Text,
                skype = row.Cells[15].Text
            };

            Cache["contacto"] = contacto; 


            Response.Redirect("IngresarArticulo.aspx");
        }
        protected void GridViewConsulta_Accion2(GridViewRow row)
        {
            //Funcionalidad Acción 2
        }



    }
}