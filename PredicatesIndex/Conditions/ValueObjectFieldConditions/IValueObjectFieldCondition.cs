namespace PredicatesIndex.Conditions.ValueObjectFieldConditions
{
    public interface IValueObjectFieldCondition
        : ICondition
    {
        string Name { get; }
    }
}