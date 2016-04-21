using DesignPatterns.BehaviorPatterns.Command.Interface;
using DesignPatterns.BehaviorPatterns.Command.MacroCommand.Receiver;

namespace DesignPatterns.BehaviorPatterns.Command.MacroCommand.ConcreteCommand
{
    public class ProgrammerCommand : ICommand
    {
        private readonly Programmer _programmer;


        public ProgrammerCommand(Programmer programmer)
        {
            _programmer = programmer;
        }


        public void Execute()
        {
            _programmer.StartCoding();
        }

        public void Undo()
        {
            _programmer.StopCoding();
        }
    }
}