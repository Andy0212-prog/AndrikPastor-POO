using System;
using System.Linq;
using System.Collections.Generic;

namespace Segundo_Parcial;

public class Ahorcado
{
    public static void Main()
    {
        // Colección de palabras
        string[] palabras = { "programacion", "computadora", "algoritmo", "variable", "arreglo", "metodo", "ciclo" };

        // Elegir palabra al azar
        Random rnd = new Random();
        string palabra = palabras[rnd.Next(palabras.Length)];

        // Preparar letras ocultas y control
        char[] descubiertas = new string('_', palabra.Length).ToCharArray();
        List<char> usadas = new List<char>();
        int vidas = 6;

        // Bucle principal del juego
        while (vidas > 0 && new string(descubiertas).Contains('_'))
        {
            Console.Clear();
            Console.WriteLine($"Vidas: {vidas}");
            Console.WriteLine("Palabra: " + string.Join(" ", descubiertas));
            Console.WriteLine("Letras usadas: " + (usadas.Count == 0 ? "Ninguna" : string.Join(", ", usadas)));
            Console.Write("Ingresa una letra: ");
            string entrada = Console.ReadLine();

            // Validar entrada
            if (string.IsNullOrWhiteSpace(entrada) || entrada.Length != 1 || !char.IsLetter(entrada[0]))
            {
                Console.WriteLine("⚠ Ingresa solo una letra.");
                Console.ReadLine();
                continue;
            }

            char letra = char.ToLower(entrada[0]);

            // Validar letra repetida
            if (usadas.Contains(letra))
            {
                Console.WriteLine($"⚠ Ya usaste '{letra}', intenta otra.");
                Console.ReadLine();
                continue;
            }

            usadas.Add(letra);

            // Verificar si la letra está en la palabra
            if (palabra.Contains(letra))
            {
                for (int i = 0; i < palabra.Length; i++)
                    if (palabra[i] == letra) descubiertas[i] = letra;

                Console.WriteLine("¡CORRECTO!");
            }
            else
            {
                vidas--;
                Console.WriteLine("¡INCORRECTO!");
            }

            // Después de mostrar Correcto o Incorrecto el código hace un Console.ReadLine() que espera a que presiones Enter antes de volver al inicio del bucle
            Console.ReadLine();
        }
        // Mensaje final
        Console.Clear();
        if (!new string(descubiertas).Contains('_'))
            Console.WriteLine($"¡GANASTE! La palabra era: {palabra.ToUpper()}");
        else
            Console.WriteLine($"¡PERDISTE! La palabra era: {palabra.ToUpper()}");

        Console.ReadLine();
    }
}
