using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Encargado : Persona
    {
        private string idEncargado;

        public string IdEncargado { get => idEncargado; set => idEncargado = value; }
    }

}
