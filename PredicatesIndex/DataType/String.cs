namespace PredicatesIndex.DataType
{
    public class String
        : IDataType
    {
       public string Value { get; }

        public String(string value)
        {
            this.Value = value;
        }
    }
}