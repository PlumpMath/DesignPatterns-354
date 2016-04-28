namespace DesignPatterns.BehaviorPatterns.Mediator.Mediator
{
    public abstract class AbstractMediator
    {
        public abstract void Send(string msg, Collegue.Collegue collegue);
    }
}