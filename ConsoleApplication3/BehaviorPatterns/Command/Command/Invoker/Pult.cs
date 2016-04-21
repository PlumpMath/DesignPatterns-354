using DesignPatterns.BehaviorPatterns.Command.Interface;

namespace DesignPatterns.BehaviorPatterns.Command.Command.Invoker
{
    public class Pult
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }

        public void PressCancel()
        {
            _command.Undo();
        }
    }
}