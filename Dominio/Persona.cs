using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected string documento;
        protected string direccion;
        protected string correoElectronico;
        enum tipoDocumento { DNI, LE, Pasaporte}
        protected int telefono;

    

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
