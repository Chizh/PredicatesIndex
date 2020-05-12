namespace PredicatesIndex.Conditions.NumberConditions
{
    using PredicatesIndex.DataType;

    public class NumberEqTo
        : NumberCondition
    {
        public NumberEqTo(
            Number value)
            : base(value: value)
        {
        }
    }
}