namespace PredicatesIndex.Conditions.NumberConditions
{
    using PredicatesIndex.DataType;

    public class NumberGreaterThanEq
        : NumberCondition
    {
        public NumberGreaterThanEq(
            Number value)
            : base(value: value)
        {
        }
    }
}