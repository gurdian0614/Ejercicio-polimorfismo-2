
using Ejercicio_polimorfismo_2;

Triangulo triangulo = new Triangulo();
Rectangulo rectangulo = new Rectangulo();
Circulo circulo = new Circulo();

int menu()
{
    int opcion;
    Console.WriteLine("********************************************************");
    Console.WriteLine("*                          MENU                        *");
    Console.WriteLine("* 1. Area del Triangulo                                *");
    Console.WriteLine("* 2. Perímetro del Triangulo Equilátero o Isósceles    *");
    Console.WriteLine("* 3. Area del Rectangulo                               *");
    Console.WriteLine("* 4. Perímetro del Rectangulo                          *");
    Console.WriteLine("* 5. Area del Circulo                                  *");
    Console.WriteLine("* 6. Perímetro del Circulo                             *");
    Console.WriteLine("* 7. Salir                                             *");
    Console.WriteLine("********************************************************");
    Console.WriteLine("Escoja la opción:");
    opcion = int.Parse(Console.ReadLine());
    return opcion;
}

void AreaTriangulo()
{
    Console.WriteLine("********************************************************");
    Console.WriteLine("*                  AREA DEL TRIANGULO                  *");
    Console.WriteLine("********************************************************");
    Console.WriteLine("Ingrese la base:");
    triangulo.Base = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la altura:");
    triangulo.Altura = double.Parse(Console.ReadLine());
    Console.WriteLine($"El área del triángulo es: {triangulo.Area()}");
}

void PerimetroTriangulo()
{
    Console.WriteLine("********************************************************");
    Console.WriteLine("*                PERIMETRO DEL TRIANGULO               *");
    Console.WriteLine("********************************************************");
    Console.WriteLine("Ingrese la base:");
    triangulo.Base = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el lado:");
    triangulo.Lado = double.Parse(Console.ReadLine());
    Console.WriteLine($"El perímetro del triángulo es: {triangulo.Perimetro()}");
}

void AreaRectangulo()
{
    Console.WriteLine("********************************************************");
    Console.WriteLine("*                  AREA DEL RECTANGULO                 *");
    Console.WriteLine("********************************************************");
    Console.WriteLine("Ingrese la base:");
    rectangulo.Base = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la altura:");
    rectangulo.Altura = double.Parse(Console.ReadLine());
    Console.WriteLine($"El área del rectángulo es: {rectangulo.Area()}");
}

void PerimetroRectangulo()
{
    Console.WriteLine("********************************************************");
    Console.WriteLine("*               PERIMETRO DEL RECTANGULO               *");
    Console.WriteLine("********************************************************");
    Console.WriteLine("Ingrese la base:");
    rectangulo.Base = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el lado:");
    rectangulo.Altura = double.Parse(Console.ReadLine());
    Console.WriteLine($"El perímetro del triángulo es: {rectangulo.Perimetro()}");
}

void AreaCirculo()
{
    Console.WriteLine("********************************************************");
    Console.WriteLine("*                    AREA DEL CIRCULO                  *");
    Console.WriteLine("********************************************************");
    Console.WriteLine("Ingrese el radio:");
    circulo.Radio = double.Parse(Console.ReadLine());
    Console.WriteLine($"El área del círculo es: {circulo.Area()}");
}

void PerimetroCirculo()
{
    Console.WriteLine("********************************************************");
    Console.WriteLine("*                 PERIMETRO DEL CIRCULO                *");
    Console.WriteLine("********************************************************");
    Console.WriteLine("Ingrese el radio:");
    circulo.Radio = double.Parse(Console.ReadLine());
    Console.WriteLine($"El perímetro del círculo es: {circulo.Perimetro()}");
}

int opcion = menu();
do
{
    switch (opcion)
    {
        case 1:
            AreaTriangulo();
            break;
        case 2:
            PerimetroTriangulo();
            break;
        case 3:
            AreaRectangulo();
            break;
        case 4:
            PerimetroRectangulo();
            break;
        case 5:
            AreaCirculo();
            break;
        case 6:
            PerimetroCirculo();
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

    opcion = menu();

} while (opcion != 7);
