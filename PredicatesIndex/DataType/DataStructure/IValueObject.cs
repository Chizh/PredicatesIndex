namespace PredicatesIndex.DataType.DataStructure
{
    public interface IValueObject<TValue>
        : IDataType
    {
        TValue this[string key] { get; }
    }
}