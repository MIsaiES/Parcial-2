using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Clases
{
    public interface Carreras
    {
        int Carnet();
        string Carrera();
    }

    public class IngenieriaSistemas : Carreras
    {
        public int Carnet()
        {
            return 905;
        }
        public string Carrera()
        {
            return "Ingenieria en sistemas";
        }
    }

    public class Psicologia: Carreras
    {
        public int Carnet()
        {
            return 3013; 
        }
        public string Carrera()
        {
            return "Psicología Clinica";
        }

    }

    public class AdministracionDeEmpresas: Carreras
    {
        public int Carnet()
        {
            return 2111;
        }
        public string Carrera()
        {
            return "Administracion de Empresas";
        }
    }
}

