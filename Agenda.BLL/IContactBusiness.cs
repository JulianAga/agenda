using Agenda.Entity.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.BLL
{
    interface IContactBusiness
    {
        Contacto GetContactByID(Contacto contacto);
        List<Contacto> GetListContactByFilter(ContactoDTO contactoDTO);

    }
}
