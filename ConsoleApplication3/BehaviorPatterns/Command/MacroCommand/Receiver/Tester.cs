using System;

namespace DesignPatterns.BehaviorPatterns.Command.MacroCommand.Receiver
{
    public class Tester
    {
        public void StartTesting()
        {
            Console.WriteLine("Start Testing");
        }

        public void StopTesting()
        {
            Console.WriteLine("Stop Testing");
        }
    }
}