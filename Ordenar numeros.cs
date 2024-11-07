using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un año: ");
        int añoInicial = int.Parse(Console.ReadLine());
        int añoActual = DateTime.Now.Year;
        int contador = 0;

        for (int año = añoInicial; año <= añoActual; año++)
        {
            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                contador++;
        }

        Console.WriteLine($"Número de años bisiestos desde {añoInicial} hasta {añoActual}: {contador}");
    }
}



