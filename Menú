using System;
using System.Linq;
using System.Collections.Generic;


class Menu
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Sacar la potencia");
            Console.WriteLine("2. Km a m");
            Console.WriteLine("3. Pesos a dolar");
            Console.WriteLine("4. °C a °F");
            Console.WriteLine("5. Ordenar numeros");
            Console.WriteLine("6. FizzBuzz");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Base: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Exponente: ");
                    double e = double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado: " + Math.Pow(b, e));
                    break;

                case 2:
                    Console.Write("Kilometros: ");
                    double km = double.Parse(Console.ReadLine());
                    Console.WriteLine("Metros: " + (km * 1000));
                    break;

                case 3:
                    Console.Write("Pesos: ");
                    double pesos = double.Parse(Console.ReadLine());
                    double dolar = 17.0; // puedes cambiar el valor
                    Console.WriteLine("Dolares: " + (pesos / dolar));
                    break;

                case 4:
                    Console.Write("Grados Celsius: ");
                    double c = double.Parse(Console.ReadLine());
                    double f = (c * 9 / 5) + 32;
                    Console.WriteLine("Fahrenheit: " + f);
                    break;

                case 5:
                    Console.WriteLine("Ingresa 3 numeros:");
                    int n1 = int.Parse(Console.ReadLine());
                    int n2 = int.Parse(Console.ReadLine());
                    int n3 = int.Parse(Console.ReadLine());

                    int[] numeros = { n1, n2, n3 };
                    Array.Sort(numeros);

                    Console.WriteLine("Ordenados:");
                    foreach (int n in numeros)
                    {
                        Console.Write(n + " ");
                    }
                    Console.WriteLine();
                    break;

                case 6:
                    for (int i = 1; i <= 50; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                            Console.WriteLine("FizzBuzz");
                        else if (i % 3 == 0)
                            Console.WriteLine("Fizz");
                        else if (i % 5 == 0)
                            Console.WriteLine("Buzz");
                        else
                            Console.WriteLine(i);
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

        } while (opcion != 0);
    }
}
