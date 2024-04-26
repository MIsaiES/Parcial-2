using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Clases
{
    internal class Productos
    {
       
        private string[] nombre = new string[10];
        public string[] nom
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string this[int indice]
        {
            get => nombre[indice];
            set => nombre[indice] = value;
        }
    }
}
