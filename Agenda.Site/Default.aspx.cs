using Agenda.BLL;
using Agenda.Entity;
using Agenda.Entity.Objetos;
using System;
using System.Collections.Generic;
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
            List<Contacto> contactos = (List<Contacto>)Application["listContacto"];

       

           

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


            //Instancio mi business
            //IExampleBusiness business = new MemoryExampleBusiness((List<Example>)Application["lstExample"]);

            //Response.Write("Obtengo el registro con Id=3 y lo imprimio en pantalla:");
            //Response.Write("<BR/>");
            //Example example = business.GetExampleByID(new Example { id = 3 });
            //Response.Write(string.Concat("Id: ", example.id.ToString(), " Value: ", example.value));
            //Response.Write("<BR/>");
            //Response.Write("--------------------------------------");
            //Response.Write("<BR/>");



            //Response.Write("Actualizo el registro obtenido, lo recupero y lo imprimo en pantalla:");
            //Response.Write("<BR/>");
            //example.value = "test update Registro example3";
            //business.Update(example);
            //Example exampleUpdate = business.GetExampleByID(new Example { id = 3 });
            //Response.Write(string.Concat("Id: ", exampleUpdate.id.ToString(), " Value: ", exampleUpdate.value));
            //Response.Write("<BR/>");
            //Response.Write("--------------------------------------");
            //Response.Write("<BR/>");


            //Response.Write("Elimino el registro con Id=7:");
            //Response.Write("<BR/>");
            //business.Delete(new Example() { id = 7 });
            //Response.Write("--------------------------------------");
            //Response.Write("<BR/>");


            //Response.Write("Inserto un nuevo registro y lo imprimo en pantalla:");
            //Response.Write("<BR/>");
            //Example exampleInsert = business.Insert(new Example() { value = " Registro Nuevo" });
            //Response.Write(string.Concat("Id: ", exampleInsert.id.ToString(), " Value: ", exampleInsert.value));
            //Response.Write("<BR/>");
            //Response.Write("--------------------------------------");
            //Response.Write("<BR/>");



            //Response.Write("Imprimo en pantalla el listado de registros:");
            //Response.Write("<BR/>");
            //print(business.GetListExampleByFilter(new ExampleFilter()));
            //Response.Write("--------------------------------------");
            //Response.Write("<BR/>");

            //Response.Write("Imprimo en pantalla el listado de registros filtrados con el value Registro:");
            //Response.Write("<BR/>");
            //print(business.GetListExampleByFilter(new ExampleFilter() { value = "Registro" }));
        }
    }
}