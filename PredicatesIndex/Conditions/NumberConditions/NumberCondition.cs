namespace PredicatesIndex.Conditions.NumberConditions
{
    using PredicatesIndex.DataType;

    public abstract class NumberCondition
        : ICondition
    {
        protected NumberCondition(
            Number value)
        {
            this.Value = value;
        }

        public Number Value { get; }
    }
}