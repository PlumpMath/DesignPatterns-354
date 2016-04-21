using DesignPatterns.BehaviorPatterns.Command.Interface;
using DesignPatterns.BehaviorPatterns.Command.MacroCommand.Receiver;

namespace DesignPatterns.BehaviorPatterns.Command.MacroCommand.ConcreteCommand
{
    public class TesterCommand : ICommand
    {
        private readonly Tester _tester;


        public TesterCommand(Tester tester)
        {
            _tester = tester;
        }


        public void Execute()
        {
            _tester.StartTesting();
        }

        public void Undo()
        {
            _tester.StopTesting();
        }
    }
}