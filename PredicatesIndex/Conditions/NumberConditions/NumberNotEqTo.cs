namespace PredicatesIndex.Conditions.NumberConditions
{
    using PredicatesIndex.DataType;

    public class NumberNotEqTo
        : NumberCondition
    {
        public NumberNotEqTo(
            Number value)
            : base(value: value)
        {
        }
    }
}