using System;

namespace DesignPatterns
{
    public class PatternDecorator : PatternTest
    {
        private readonly PatternTest _patternTest;

        private PatternDecorator(PatternTest patternTest) : base("")
        {
            _patternTest = patternTest;
        }

        public static void RunTest(PatternTest patternTest)
        {
            new PatternDecorator(patternTest).Run();
        }

        public override void Run()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("* {0} *", _patternTest.PatternName);
            Console.WriteLine(Environment.NewLine);
            _patternTest.Run();
            Console.WriteLine(Environment.NewLine);
        }
    }
}