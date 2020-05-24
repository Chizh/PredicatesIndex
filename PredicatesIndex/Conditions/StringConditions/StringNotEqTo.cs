namespace PredicatesIndex.Conditions.StringConditions
{
    using PredicatesIndex.DataType;

    public class StringNotEqTo
        : StringCondition
    {
        public StringNotEqTo(
            String value)
            : base(value: value)
        {
        }
    }
}