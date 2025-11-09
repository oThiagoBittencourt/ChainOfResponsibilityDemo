namespace ChainOfResponsibilityDemo.Handlers
{
    public abstract class Handler
    {
        protected Handler? NextHandler;

        public void SetNext(Handler next)
        {
            NextHandler = next;
        }

        public abstract void HandleRequest(string tipoProblema);
    }
}
