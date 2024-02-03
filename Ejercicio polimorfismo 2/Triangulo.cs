using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_polimorfismo_2
{
    internal class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado { get; set; }
        
        public override double Area()
        {
            return 0.5 * Base * Altura;
        }

        public override double Perimetro()
        {
            return Base + Lado + Lado;
        }
    }
}
