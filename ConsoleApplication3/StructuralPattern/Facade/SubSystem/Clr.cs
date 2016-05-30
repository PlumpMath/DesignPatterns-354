using System;

namespace DesignPatterns.StructuralPattern.Facade.SubSystem
{
    public class Clr
    {
        public void Execute()
        {
            Console.WriteLine("Выполнить");
        }

        public void Finish()
        {
            Console.WriteLine("Остановить");
        }
    }
}