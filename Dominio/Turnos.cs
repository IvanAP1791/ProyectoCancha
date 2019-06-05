using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turnos
    {
        string nombreReserva;
        string FranjaHoraria;
        DateTime fecha;
        int NumCancha;
        string estado;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int NumCancha1 { get => NumCancha; set => NumCancha = value; }
        public string Estado { get => estado; set => estado = value; }
        public string NombreReserva { get => nombreReserva; set => nombreReserva = value; }
        public string FranjaHoraria1 { get => FranjaHoraria; set => FranjaHoraria = value; }
    }
}
