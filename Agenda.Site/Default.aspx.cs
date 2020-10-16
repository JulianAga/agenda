using Agenda.BLL;
using Agenda.Entity;
using Agenda.Entity.Objetos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda.Site
{
    public partial class _Default : Page
    {
        private void print(List<Example> listado)
        {
            //foreach (Example example in listado)
            //{
            //    Response.Write(string.Concat("Id: ", example.id.ToString(), " Value: ", example.value));
            //    Response.Write("<BR/>");
            //}
        }

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


            foreach (Contacto contacto in contactos)
            {
                TableCell apellido = new TableCell();
                TableCell genero = new TableCell();
                TableCell pais = new TableCell();
                TableCell localidad = new TableCell();
                TableCell contInt = new TableCell();
                TableCell organizacion = new TableCell();
                TableCell area = new TableCell();
                TableCell fecha = new TableCell();
                TableCell activo = new TableCell();
                TableCell direccion = new TableCell();
                TableCell tel = new TableCell();
                TableCell cel = new TableCell();
                TableCell email = new TableCell();
                TableCell skype = new TableCell();

                TableRow row = new TableRow();


                apellido.Text = contacto.apellidoYNombre;
                genero.Text = contacto.genero;
                pais.Text = contacto.pais;
                localidad.Text = contacto.localidad;
                contInt.Text = contacto.contactoInterno;
                organizacion.Text = contacto.organizacion;
                area.Text = contacto.area;
                fecha.Text = contacto.fechaDeIngreso.ToString();
                activo.Text = contacto.activo.ToString();
                direccion.Text = contacto.direccion;
                tel.Text = contacto.telefono;
                cel.Text = contacto.celular;
                email.Text = contacto.email;
                skype.Text = contacto.skype;

                row.Cells.Add(apellido);
                row.Cells.Add(genero);
                row.Cells.Add(pais);
                row.Cells.Add(localidad);
                row.Cells.Add(contInt);
                row.Cells.Add(organizacion);
                row.Cells.Add(area);
                row.Cells.Add(fecha);
                row.Cells.Add(activo);
                row.Cells.Add(direccion);
                row.Cells.Add(tel);
                row.Cells.Add(cel);
                row.Cells.Add(email);
                row.Cells.Add(skype);

                myTable.Rows.Add(row);

            }
            if (Session["user"] != null && Cache["date"] != null) { 
            String User = (string)Session["user"];
            DateTime date = (DateTime)Cache["date"];

            Response.Write(User);
            Response.Write(date);
        }

        }

        protected void BtnFilter_Click(object sender, EventArgs e)
        {

        }


    }
}