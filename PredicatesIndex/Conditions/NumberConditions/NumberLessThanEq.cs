namespace PredicatesIndex.Conditions.NumberConditions
{
    using PredicatesIndex.DataType;

    public class NumberLessThanEq
         : NumberCondition
    {
        public NumberLessThanEq(
            Number value)
            : base(value: value)
        {
        }
    }
}