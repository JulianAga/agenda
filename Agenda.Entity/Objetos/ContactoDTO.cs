using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entity.Objetos
{
    public class ContactoDTO
    {
        public ContactoDTO(string apellidoYNombre, string genero, string pais, string localidad, string contactoInterno, string organizacion, string area, DateTime? fechaDeIngreso, bool? activo, string direccion, string telefono, string celular, string email, string skype)
       
       {
            this.apellidoYNombre = apellidoYNombre;
            this.genero = genero;
            this.pais = pais;
            this.localidad = localidad;
            this.contactoInterno = contactoInterno;
            this.organizacion = organizacion;
            this.area = area;
            this.fechaDeIngreso = fechaDeIngreso;
            this.activo = activo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.celular = celular;
            this.email = email;
            this.skype = skype;
        }

        public ContactoDTO()
        {

        }

        public string? apellidoYNombre { get; set; }
        public string ? genero { get; set; }
        public string ? pais { get; set; }
        public string ? localidad { get; set; }
        public string ? contactoInterno { get; set; }
        public string ? organizacion { get; set; }
        public string ? area { get; set; }
        public DateTime ? fechaDeIngreso { get; set; }
        public Boolean ? activo { get; set; }
        public string ? direccion { get; set; }
        public string ? telefono { get; set; }
        public string ? celular { get; set; }
        public string ? email { get; set; }
        public string ? skype { get; set; }

    }
}
