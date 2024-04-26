using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Clases.Combustibles
{
    internal class Gasolina:Carro
    {
        public override string Combustible { get => base.Combustible="Gasolina"; set => base.Combustible = value; }
    }
}
