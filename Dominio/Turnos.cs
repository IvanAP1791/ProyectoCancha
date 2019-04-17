using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turnos
    {
        enum FranjaHoraria {Matutino, Tarde, Noche};
        DateTime fecha;
        int NumCancha;
        bool estado;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int NumCancha1 { get => NumCancha; set => NumCancha = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
