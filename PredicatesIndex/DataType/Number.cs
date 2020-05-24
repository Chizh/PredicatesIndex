namespace PredicatesIndex.DataType
{
    public class Number
        : IDataType
    {
        public int Value { get; }

        public static Number MaxValue = new Number(int.MaxValue);

        public static Number MinValue = new Number(int.MinValue);

        public Number(
            int value)
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
            return obj is Number key && this.Equals(key);
        }

        public bool Equals(
            Number other)
        {
            return this.Value == other.Value;
        }
    }
}