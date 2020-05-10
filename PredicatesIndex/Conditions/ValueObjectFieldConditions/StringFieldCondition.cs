namespace PredicatesIndex.Conditions.ValueObjectFieldConditions
{
    using PredicatesIndex.Conditions.StringConditions;

    public class StringFieldCondition
        : IValueObjectFieldCondition
    {
        public StringFieldCondition(
            StringCondition condition,
            string name)
        {
            this.Condition = condition;
            this.Name = name;
        }

        public StringCondition Condition { get; }

        public string Name { get; }
    }
}