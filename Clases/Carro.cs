using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Clases
{
    public class Carro
    {
        private string Marca;
        private string Propietario;
        private string Placa;
        public virtual string Combustible {  get; set; }

        public string marca
        {
            get { return Marca; }
            set { Marca = value; }
        }
        public string propietario
        {
            get { return Propietario; }
            set { Propietario = value; }
        }
        public string placa
        {
            get { return Placa; }
            set { Placa = value; }
        }

        
        public void Mostrar()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Propietario: {propietario}");
            Console.WriteLine("Placa: "+ Placa);
            Console.WriteLine($"Combustible: {Combustible}");
        }
    }
}
