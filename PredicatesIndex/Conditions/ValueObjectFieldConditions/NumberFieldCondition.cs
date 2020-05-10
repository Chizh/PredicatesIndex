namespace PredicatesIndex.Conditions.ValueObjectFieldConditions
{
    using PredicatesIndex.Conditions.NumberConditions;

    public class NumberFieldCondition
        : IValueObjectFieldCondition
    {
        public NumberFieldCondition(
            NumberCondition condition,
            string name)
        {
            this.Condition = condition;
            this.Name = name;
        }

        public NumberCondition Condition { get; set; }

        public string Name { get; }
    }
}