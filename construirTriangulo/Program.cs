using System;

namespace construirTriangulo
{
    public class Triangulo
{
    public static bool esTriangulo(int a, int b, int c)
    {
        // Se comprueba que los lados sean positivos y mayores que cero
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return false;
        }
        // Se comprueba que la suma de dos lados sea mayor que el tercero o desigualdad triangular
        return a + b > c && a + c > b && b + c > a;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor del lado 1: ");
        int lado1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el valor del lado 2: ");
        int lado2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el valor del lado 3: ");
        int lado3 = Convert.ToInt32(Console.ReadLine());

        bool resultado = esTriangulo(lado1, lado2, lado3);
        Console.WriteLine("¿Se puede formar un triangulo? " + (resultado ? "Si" : "No"));
    }
}
}
