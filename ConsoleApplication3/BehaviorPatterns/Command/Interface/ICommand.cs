namespace DesignPatterns.BehaviorPatterns.Command.Interface
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}