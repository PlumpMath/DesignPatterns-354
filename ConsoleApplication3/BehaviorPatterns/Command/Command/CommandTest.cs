using DesignPatterns.BehaviorPatterns.Command.Command.ConcreteCommand;
using DesignPatterns.BehaviorPatterns.Command.Command.Invoker;
using DesignPatterns.BehaviorPatterns.Command.Command.Receiver;

namespace DesignPatterns.BehaviorPatterns.Command.Command
{
    public class CommandTest : PatternTest
    {
        public CommandTest() : base("Command")
        {
        }

        public override void Run()
        {
            var tvSet = new TvSet();
            var tvCommand = new TvCommand(tvSet);
            var pult = new Pult();
            pult.SetCommand(tvCommand);
            pult.PressButton();
            pult.PressCancel();
        }
    }
}