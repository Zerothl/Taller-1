using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa una cadena de texto:");
        string texto = Console.ReadLine();
        int contador = 0;

        foreach (char c in texto)
        {
            if ("aeiouAEIOU".Contains(c))
                contador++;
        }

        Console.WriteLine($"Número de vocales: {contador}");
    }
}
