
namespace Ejercicio_polimorfismo_2
{
    public class Circulo : Forma
    {
        public double Radio { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
