using System;

namespace ChainOfResponsibilityDemo.Handlers
{
    public class Atendente : Handler
    {
        public override void HandleRequest(string tipoProblema)
        {
            if (tipoProblema == "Simples")
            {
                Console.WriteLine("Atendente resolveu o problema simples.");
            }
            else
            {
                Console.WriteLine("Atendente não conseguiu resolver, encaminhando ao Supervisor...");
                NextHandler?.HandleRequest(tipoProblema);
            }
        }
    }
}
