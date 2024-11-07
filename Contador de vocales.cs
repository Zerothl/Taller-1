using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa tres números:");
        float[] numeros = new float[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = float.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);
        Console.WriteLine("Números en orden ascendente: " + string.Join(", ", numeros));
    }
}


