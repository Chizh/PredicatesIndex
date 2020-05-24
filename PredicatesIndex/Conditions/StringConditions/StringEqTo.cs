namespace PredicatesIndex.Conditions.StringConditions
{
    using PredicatesIndex.DataType;

    public class StringEqTo
        : StringCondition
    {
        public StringEqTo(
            String value)
            : base(value: value)
        {
        }
    }
}