namespace PredicatesIndex.Conditions.StringConditions
{
    public abstract class StringCondition
        : ICondition
    {
        protected StringCondition(
            string value)
        {
            this.Value = value;
        }

        public string Value { get; }
    }
}