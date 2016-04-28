namespace DesignPatterns.BehaviorPatterns.Interpretator.AbstractExpression.Terminal
{
    public class NumberExpression : IExpression
    {
        private readonly string _key;

        public NumberExpression(string key)
        {
            _key = key;
        }

        public int Interpret(Context context)
        {
            return context.GetValue(_key);
        }
    }
}