using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class CanchaNego
    {
        CanchaRepo canchaRepo = new CanchaRepo();

        public void GuardarCliente(Persona persona)
        {
            canchaRepo.GuardarCliente(persona);
        }

        public void GuardarCancha(Cancha cancha)
        {
            canchaRepo.GuardarCancha(cancha);
        }
        public void GuardarEncargado(Encargado encargado)
        {
            canchaRepo.GuardarEncargado(encargado);
        }
        public void BorrarPersona(Persona persona)
        {
            canchaRepo.BorrarPersona(persona);
        }
    }
}
