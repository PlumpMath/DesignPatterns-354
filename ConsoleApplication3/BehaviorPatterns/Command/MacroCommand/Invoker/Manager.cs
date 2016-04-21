using DesignPatterns.BehaviorPatterns.Command.Interface;

namespace DesignPatterns.BehaviorPatterns.Command.MacroCommand.Invoker
{
    public class Manager
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void StartDevelopment()
        {
            _command.Execute();
        }

        public void StopDevelopment()
        {
            _command.Undo();
        }
    }
}