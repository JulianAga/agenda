using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entity.Objetos
{
    public class Contacto
    {

        public string apellidoYNombre { get; set; }
        public string genero { get; set; }
        public string pais { get; set; }
        public string localidad { get; set; }
        public string contactoInterno { get; set; }
        public string organizacion { get; set; }
        public string area { get; set; }
        public DateTime fechaDeIngreso { get; set; }
        public Boolean activo { get; set; }
        public string direccion { get; set; }
        public string telefono{ get; set; }
        public string celular { get; set; }
        public string email{ get; set; }
        public string skype{ get; set; }

        public Contacto()
        {

        }

    }
}
