using System;
using System.Linq;

namespace Segundo_Parcial;

public class Program
{
    public static void Main()
    {
        int sumaAcumulada = 1;

        Console.WriteLine("Empezando la suma hasta el 5050:\n");

        for (int siguienteNumero = 2; siguienteNumero <= 100; siguienteNumero++)
        {
            int resultadoAnterior = sumaAcumulada;
            sumaAcumulada += siguienteNumero;

            Console.WriteLine($"{resultadoAnterior} + {siguienteNumero} = {sumaAcumulada}");
        }

        Console.WriteLine("\n¡Llegamos al final!");
    }
}
