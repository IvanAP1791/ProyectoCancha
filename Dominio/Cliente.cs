using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Persona
    {
        private int idCliente;
        private bool socio;

        public bool Socio { get => socio; set => socio = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

       
    }
}
