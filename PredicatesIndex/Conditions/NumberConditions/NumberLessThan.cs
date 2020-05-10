namespace PredicatesIndex.Conditions.NumberConditions
{
    using PredicatesIndex.DataType;

    public class NumberLessThan
         : NumberCondition
    {
        public NumberLessThan(
            Number value)
            : base(value: value)
        {
        }
    }
}