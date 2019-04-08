using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cancha
    {
        enum tipoCancha {Paddle, Tennis, Mixta};
        int numeroCancha;
        bool estado;

        public int NumeroCancha { get => numeroCancha; set => numeroCancha = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
