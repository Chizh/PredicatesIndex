namespace PredicatesIndex.Conditions.NumberConditions
{
    using PredicatesIndex.DataType;

    public class NumberGreaterThan
        : NumberCondition
    {
        public NumberGreaterThan(
            Number value)
            : base(value: value)
        {
        }
    }
}