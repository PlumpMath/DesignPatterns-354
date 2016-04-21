using System.Collections.Generic;
using DesignPatterns.BehaviorPatterns.Command.Interface;

namespace DesignPatterns.BehaviorPatterns.Command.MacroCommand.ConcreteCommand
{
    public class ManagerCommand : ICommand
    {
        private readonly List<ICommand> _commands;


        public ManagerCommand(List<ICommand> commands)
        {
            _commands = commands;
        }


        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }
}