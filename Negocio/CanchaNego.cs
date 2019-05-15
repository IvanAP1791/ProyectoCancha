using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;
using System.Configuration;


namespace Negocio
{
    public class CanchaNego
    {
        CanchaRepo canchaRepo = new CanchaRepo();

        

        public void GuardarCancha(Cancha cancha)
        {
            canchaRepo.GuardarCancha(cancha);
        }
        public void GuardarEncargado(Encargado encargado)
        {
            canchaRepo.GuardarEncargado(encargado);
        }
       
        public DataSet LlenarGrilla()
        {
            return canchaRepo.LlenarGrilla();
        }
    }
}
