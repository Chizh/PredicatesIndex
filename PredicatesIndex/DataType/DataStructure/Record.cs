namespace PredicatesIndex.DataType.DataStructure
{
    public class Record<TValue>
            where TValue: IDataType
    {
        public Record(
            string name,
            TValue value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get; }

        public TValue Value { get; }
    }
}