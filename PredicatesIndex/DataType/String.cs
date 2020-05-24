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

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public override bool Equals(
            object? obj)
        {
            return obj is String key && this.Equals(key);
        }

        public bool Equals(
            String other)
        {
            return this.Value == other.Value;
        }
    }
}