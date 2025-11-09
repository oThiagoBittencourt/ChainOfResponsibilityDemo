using System;

namespace ChainOfResponsibilityDemo
{
    class Program
    {
        static void Main()
        {
            // O programador só precisa conhecer esta fábrica e o primeiro manipulador
            var suporte = SuporteHandlerFactory.CriarCadeiaDeSuporte();

            Console.WriteLine("=== Teste 1: Problema simples ===");
            suporte.HandleRequest("Simples");

            Console.WriteLine("\n=== Teste 2: Problema moderado ===");
            suporte.HandleRequest("Moderado");

            Console.WriteLine("\n=== Teste 3: Problema crítico ===");
            suporte.HandleRequest("Crítico");

            Console.WriteLine("\n=== Teste 4: Tipo desconhecido ===");
            suporte.HandleRequest("Outro");
        }
    }
}
