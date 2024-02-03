
namespace Ejercicio_polimorfismo_2
{
    public class Rectangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Base * Altura;
        }

        public override double Perimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
