using System;

namespace DesignPatterns.BehaviorPatterns.Command.MacroCommand.Receiver
{
    public class Programmer
    {
        public void StartCoding()
        {
            Console.WriteLine("Start writing code");
        }

        public void StopCoding()
        {
            Console.WriteLine("Stop writing code");
        }
    }
}