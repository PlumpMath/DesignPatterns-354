using System.Collections.Generic;
using DesignPatterns.BehaviorPatterns.Command.Interface;
using DesignPatterns.BehaviorPatterns.Command.MacroCommand.ConcreteCommand;
using DesignPatterns.BehaviorPatterns.Command.MacroCommand.Invoker;
using DesignPatterns.BehaviorPatterns.Command.MacroCommand.Receiver;

namespace DesignPatterns.BehaviorPatterns.Command.MacroCommand
{
    public class MacroCommandTest : PatternTest
    {
        public MacroCommandTest() : base("MacroCommand")
        {
        }

        public override void Run()
        {
            var programmer = new Programmer();
            var tester = new Tester();

            var commands = new List<ICommand>
            {
                new ProgrammerCommand(programmer),
                new TesterCommand(tester)
            };


            var managerCommand = new ManagerCommand(commands);
            var manager = new Manager();
            manager.SetCommand(managerCommand);
            manager.StartDevelopment();
            manager.StopDevelopment();
        }
    }
}