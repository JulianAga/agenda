using Ingresar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Agenda.Entity.Objetos;
using Newtonsoft.Json;

namespace Agenda.Site
{
    public class Global : HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            //Serializacion de contactos-------------------------------------------------

            //List<Contacto> listContacto = new List<Contacto>();
            //listContacto.Add(new Contacto()
            //{
            //    apellidoYNombre = "Flor excoffon",
            //    genero = "Femenino",
            //    pais = "Argentina",
            //    localidad = "chascomus",
            //    contactoInterno = "si",
            //    organizacion = "asd",
            //    area = "Higiene",
            //    fechaDeIngreso = DateTime.Now,
            //    activo = true,
            //    direccion = "asdf",
            //    telefono = "223161654",
            //    celular = "2231651",
            //    email = "florchiexco@gmail.com",
            //    skype = "flor.sk"

            //});
            //listContacto.Add(new Contacto()
            //{
            //    apellidoYNombre = "Julian Aga",
            //    genero = "Masculino",
            //    pais = "Argentina",
            //    localidad = "chascomus",
            //    contactoInterno = "si",
            //    organizacion = "asd",
            //    area = "Informatica",
            //    fechaDeIngreso = DateTime.Now,
            //    activo = true,
            //    direccion = "asdf",
            //    telefono = "223161654",
            //    celular = "2231651",
            //    email = "julianaga@gmail.com",
            //    skype = "juli.sk"

            //});

            //string pathAgenda = ConfigurationManager.AppSettings.Get("PathAgenda");

            //if (File.Exists(pathAgenda))
            //{
            //    File.WriteAllText(pathAgenda, JsonConvert.SerializeObject(listContacto));
            //}

            //Serializacion de la lista de usuarios--------------------------------------------------

            List<Usuario> usuarios = new List<Usuario>();

            usuarios.Add(new Usuario { User = "Ezequiel", Contraseña = "1111" });
            usuarios.Add(new Usuario { User = "Juan", Contraseña = "1111"});
            usuarios.Add(new Usuario { User = "Dieguez", Contraseña = "1111" });

            string pathContactos = ConfigurationManager.AppSettings.Get("PathContactos");

            if (File.Exists(pathContactos))
            {
                File.WriteAllText(pathContactos, JsonConvert.SerializeObject(usuarios));
            }

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}