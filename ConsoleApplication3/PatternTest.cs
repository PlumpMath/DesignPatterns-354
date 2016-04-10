namespace DesignPatterns
{
    public abstract class PatternTest
    {
        public string PatternName { get; private set; }

        protected PatternTest(string patternName)
        {
            PatternName = patternName;
        }

        public abstract void Run();
    }
}