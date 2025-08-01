class Program
{
    static void Main()
    {
        // Solicitar los lados del triángulo
        Console.Write("INGRESE EL LADO A DEL TRIANGULO: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());

        Console.Write("INGRESE EL LADO B DEL TRIANGULO: ");
        double ladoB = Convert.ToDouble(Console.ReadLine());

        Console.Write("INGRESE EL LADO C DEL TRIANGULO: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        // Determinar el tipo de triángulo
        if (ladoA == ladoB && ladoB == ladoC)
        {
            Console.WriteLine("EL TRIANGULO ES EQUILATERO");
        }
        else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
        {
            Console.WriteLine("EL TRIANGULO ES ISOSCELES");
        }
        else if (ladoA != ladoB || ladoA != ladoC || ladoB != ladoC)
        {
            Console.WriteLine("EL TRIANGULO ES ESCALENO");
        }
        else
        {
            Console.WriteLine("TRIANGULO NO ACEPTADO");
        }
    }
}