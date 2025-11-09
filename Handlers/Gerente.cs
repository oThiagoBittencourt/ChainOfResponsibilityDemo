using System;

namespace ChainOfResponsibilityDemo.Handlers
{
    public class Gerente : Handler
    {
        public override void HandleRequest(string tipoProblema)
        {
            if (tipoProblema == "Crítico")
            {
                Console.WriteLine("Gerente resolveu o problema crítico!");
            }
            else
            {
                Console.WriteLine("Nenhum nível conseguiu resolver o problema.");
            }
        }
    }
}
