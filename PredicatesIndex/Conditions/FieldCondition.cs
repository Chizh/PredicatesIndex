namespace PredicatesIndex.Conditions
{
    public class FieldCondition
    {
        public FieldCondition(
            string fieldName,
            ICondition condition)
        {
            this.FieldName = fieldName;
            this.Condition = condition;
        }

        public string FieldName { get; set; }

        public ICondition Condition { get; set; }
    }
}