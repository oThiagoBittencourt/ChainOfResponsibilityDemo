using ChainOfResponsibilityDemo.Handlers;

namespace ChainOfResponsibilityDemo
{
    public static class SuporteHandlerFactory
    {
        public static Handler CriarCadeiaDeSuporte()
        {
            var atendente = new Atendente();
            var supervisor = new Supervisor();
            var gerente = new Gerente();

            atendente.SetNext(supervisor);
            supervisor.SetNext(gerente);

            return atendente;
        }
    }
}
