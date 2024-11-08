using System.Drawing;

namespace validarCores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dicionário com cores traduzidas do português para ConsoleColor
            var coresEmPortugues = new Dictionary<string, ConsoleColor>(StringComparer.OrdinalIgnoreCase)
        {
            { "preto", ConsoleColor.Black },
            { "preta", ConsoleColor.Black },
            { "azul", ConsoleColor.Blue },
            { "verde", ConsoleColor.Green },
            { "ciano", ConsoleColor.Cyan },
            { "vermelho", ConsoleColor.Red },
            { "magenta", ConsoleColor.Magenta },
            { "amarelo", ConsoleColor.Yellow },
            { "branco", ConsoleColor.White },
            { "cinza", ConsoleColor.Gray },
            { "cinza escuro", ConsoleColor.DarkGray },
            { "azul escuro", ConsoleColor.DarkBlue },
            { "verde escuro", ConsoleColor.DarkGreen },
            { "ciano escuro", ConsoleColor.DarkCyan },
            { "vermelho escuro", ConsoleColor.DarkRed },
            { "magenta escuro", ConsoleColor.DarkMagenta },
            { "amarelo escuro", ConsoleColor.DarkYellow }
        };

            Console.WriteLine("Digite o nome de uma cor em português:");
            string inputCor = Console.ReadLine();

            if (coresEmPortugues.TryGetValue(inputCor, out ConsoleColor corValida))
            {
                Console.WriteLine($"A cor '{inputCor}' é válida e corresponde a '{corValida}'.");
            }
            else
            {
                Console.WriteLine($"A cor '{inputCor}' não é válida.");
            }
        }
    }
}