using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turnos
    {
        private int turnos_Id;
        private string nombreReserva;
        private string FranjaHoraria;
        private DateTime fecha;
        private string NumCancha;
        private string estado;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string NumCancha1 { get => NumCancha; set => NumCancha = value; }
        public string Estado { get => estado; set => estado = value; }
        public string NombreReserva { get => nombreReserva; set => nombreReserva = value; }
        public string FranjaHoraria1 { get => FranjaHoraria; set => FranjaHoraria = value; }
        public int Turnos_Id { get => turnos_Id; set => turnos_Id = value; }
    }
}
