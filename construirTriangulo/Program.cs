public class Triangulo
{
    public static bool PuedeFormarTriangulo(int a, int b, int c)
    {
        // Comprobar si los lados son mayores que cero
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return false;
        }
        // Comprobar la desigualdad triangular
        return a + b > c && a + c > b && b + c > a;
    }

    static void Main(string[] args)
    {
        int lado1 = 3;
        int lado2 = 4;
        int lado3 = 5;

        // Llamada al método
        bool resultado = Triangulo.PuedeFormarTriangulo(lado1, lado2, lado3);
        Console.WriteLine("¿Se puede formar un triángulo? " + resultado);
    }
}