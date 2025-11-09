using System;

namespace ChainOfResponsibilityDemo.Handlers
{
    public class Supervisor : Handler
    {
        public override void HandleRequest(string tipoProblema)
        {
            if (tipoProblema == "Moderado")
            {
                Console.WriteLine("Supervisor resolveu o problema moderado.");
            }
            else
            {
                Console.WriteLine("Supervisor não conseguiu resolver, encaminhando ao Gerente...");
                NextHandler?.HandleRequest(tipoProblema);
            }
        }
    }
}
