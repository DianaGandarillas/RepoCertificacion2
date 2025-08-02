using System;

class Program
{
    static void Main()
    {
        double ladoA = LeerLado("A");
        double ladoB = LeerLado("B");
        double ladoC = LeerLado("C");

        // Determinar el tipo de triángulo
        if (ladoA == ladoB && ladoB == ladoC)
        {
            Console.WriteLine("EL TRIANGULO ES EQUILATERO");
        }
        else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
        {
            Console.WriteLine("EL TRIANGULO ES ISOSCELES");
        }
        else
        {
            Console.WriteLine("EL TRIANGULO ES ESCALENO");
        }
    }

    static double LeerLado(string nombreLado)
    {
        double lado;
        bool esNumeroValido;

        do
        {
            Console.Write($"INGRESE EL LADO {nombreLado} DEL TRIANGULO: ");
            string input = Console.ReadLine();

            // Verificar si es número
            if (!double.TryParse(input, out lado))
            {
                Console.WriteLine("Por Favor Ingrese un número");
                esNumeroValido = false;
            }
            // Verificar si es positivo
            else if (lado <= 0)
            {
                Console.WriteLine("Por Favor ingrese un número positivo");
                esNumeroValido = false;
            }
            else
            {
                esNumeroValido = true;
            }

        } while (!esNumeroValido);

        return lado;
    }
}
