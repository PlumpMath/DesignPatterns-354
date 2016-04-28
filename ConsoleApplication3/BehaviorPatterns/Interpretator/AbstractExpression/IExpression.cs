namespace DesignPatterns.BehaviorPatterns.Interpretator.AbstractExpression
{
    public interface IExpression
    {
        int Interpret(Context context);
    }
}