﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        private int idCliente;
        private string nombre;
        private string apellido;
        private int edad;
        private string documento;
        private string direccion;
        private string correoElectronico;
        private int telefono;
        private bool socio;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public bool Socio { get => socio; set => socio = value; }
    }
}
