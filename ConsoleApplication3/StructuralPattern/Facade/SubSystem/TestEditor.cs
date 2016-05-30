using System;

namespace DesignPatterns.StructuralPattern.Facade.SubSystem
{
    public class TestEditor
    {
        public void WriteText()
        {
            Console.WriteLine("Написание текста");
        }

        public void SaveText()
        {
            Console.WriteLine("Сохранение текста");
        }
    }
}