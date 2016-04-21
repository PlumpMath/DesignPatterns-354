using DesignPatterns.BehaviorPatterns.Command.Command.Receiver;
using DesignPatterns.BehaviorPatterns.Command.Interface;

namespace DesignPatterns.BehaviorPatterns.Command.Command.ConcreteCommand
{
    public class TvCommand: ICommand
    {
        private readonly TvSet _tvSet;


        public TvCommand(TvSet tvSet)
        {
            _tvSet = tvSet;
        }


        public void Execute()
        {
            _tvSet.On();
        }

        public void Undo()
        {
            _tvSet.Off();
        }
    }
}