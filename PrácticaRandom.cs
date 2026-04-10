using System;
using System.Linq;
using System.Collections.Generic;

namespace Cuadrado_For;

public class Practica_Random
{
    public static void Main()
    {
        Random rd = new Random();
        int n1, n2, n3;
        string input;

        while (true)
        {
            Console.WriteLine(" GENERADOR DE SUMA 100: ");
            Console.WriteLine("Ingresa un número positivo para comenzar (o '0' para salir):");
            input = Console.ReadLine();

            int valorEntrada;

            if (!int.TryParse(input, out valorEntrada) || valorEntrada < 0)
            {
                Console.WriteLine("!!! pon un valor permitido !!!\n");
                continue;
            }

            if (valorEntrada == 0) break;


            n1 = rd.Next(1, 98);
            n2 = rd.Next(1, 100 - n1);
            n3 = 100 - (n1 + n2);


            Console.WriteLine($"\nNúmero 1: {n1}");
            for (int i = 0; i < n1; i++)
            {
                Console.Write("😜");
            }


            Console.WriteLine($"\n\nNúmero 2: {n2}");
            int j = 0;
            while (j < n2)
            {
                Console.Write("😁");
                j++;
            }


            Console.WriteLine($"\n\nNúmero 3: {n3}");
            int k = 0;
            do
            {
                Console.Write("😎");
                k++;
            } while (k < n3);

            Console.WriteLine("\n\n------------------------------");
            Console.WriteLine($"RESULTADO: {n1} + {n2} + {n3} = {n1 + n2 + n3}");
            Console.WriteLine("------------------------------\n");
        }
    }
}
