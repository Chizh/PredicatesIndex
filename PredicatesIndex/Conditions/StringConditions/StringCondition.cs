namespace PredicatesIndex.Conditions.StringConditions
{
    using PredicatesIndex.DataType;

    public abstract class StringCondition
        : ICondition
    {
        protected StringCondition(
            String value)
        {
            this.Value = value;
        }

        public String Value { get; }
    }
}