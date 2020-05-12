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
    }
}