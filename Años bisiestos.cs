using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        bool adivinado = false;

        Console.WriteLine("Adivina el número entre 1 y 100.");

        while (!adivinado)
        {
            Console.Write("Ingresa tu intento: ");
            int intento = int.Parse(Console.ReadLine());

            if (intento < numeroAleatorio)
                Console.WriteLine("El número es mayor.");
            else if (intento > numeroAleatorio)
                Console.WriteLine("El número es menor.");
            else
            {
                Console.WriteLine("¡Felicidades, adivinaste el número!");
                adivinado = true;
            }
        }
    }
}
