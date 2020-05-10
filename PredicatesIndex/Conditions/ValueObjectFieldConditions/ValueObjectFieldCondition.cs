namespace PredicatesIndex.Conditions.ValueObjectFieldConditions
{
    public class ValueObjectFieldCondition
        : IValueObjectFieldCondition
    {
        public ValueObjectFieldCondition(
            string name,
            ICondition condition)
        {
            this.Name = name;
            this.Condition = condition;
        }

        public string Name { get; set; }

        public ICondition Condition { get;  }
    }
}