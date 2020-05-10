namespace PredicatesIndex.Conditions.StringConditions
{
    using PredicatesIndex.DataType;

    public class StringEqTo
        : StringCondition
    {
        public StringEqTo(
            string value)
            : base(value: value)
        {
        }
    }
}