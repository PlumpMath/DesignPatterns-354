using System;

namespace DesignPatterns.BehaviorPatterns.Command.Command.Receiver
{
    public class TvSet
    {
        public void On()
        {
            Console.WriteLine("TV is ON");
        }

        public void Off()
        {
            Console.WriteLine("TV is OFF");
        }
    }
}