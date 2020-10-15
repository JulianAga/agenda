using Ingresar;
using Agenda.Entity.Objetos;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace Agenda.Site
{
    public class Global : HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            //List<Entity.Example> lstExample = new List<Entity.Example>();
            //for (int i = 1; i < 11; i++)
            //{
            //    lstExample.Add
            //    (
            //        new Entity.Example
            //        {
            //            id = i,
            //            value = string.Concat("example", i.ToString())
            //        }
            //    );
            //}
            //Application["lstExample"] = lstExample;

            List<Usuario> listCredenciales = new List<Usuario>();
            listCredenciales.Add(new Usuario() { User = "Ezequiel", Contraseña = "11221" });
            listCredenciales.Add(new Usuario() { User = "Juan", Contraseña = "2311" });

            Application["Credenciales"] = listCredenciales;

            List<Contacto> listContacto = new List<Contacto>();
            listContacto.Add(new Contacto()
            {
                apellidoYNombre = "Flor excoffon",
                genero = "Femenino",
                pais = "Argentina",
                localidad = "chascomus",
                contactoInterno = "si",
                organizacion = "asd",
                area = "Higiene",
                fechaDeIngreso = DateTime.Now,
                activo = true,
                direccion = "asdf",
                telefono = "223161654",
                celular = "2231651",
                email = "florchiexco@gmail.com",
                skype = "flor.sk"

            });
            listContacto.Add(new Contacto()
            {
                apellidoYNombre = "Julian Aga",
                genero = "Masculino",
                pais = "Argentina",
                localidad = "chascomus",
                contactoInterno = "si",
                organizacion = "asd",
                area = "Informatica",
                fechaDeIngreso = DateTime.Now,
                activo = true,
                direccion = "asdf",
                telefono = "223161654",
                celular = "2231651",
                email = "julianaga@gmail.com",
                skype = "juli.sk"

            });


            Application["listContacto"] = listContacto;
        }
    }
}