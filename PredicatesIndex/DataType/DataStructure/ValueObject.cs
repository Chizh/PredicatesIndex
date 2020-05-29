namespace PredicatesIndex.DataType.DataStructure
 {
     using System.Collections.Generic;

     public class ValueObject
        : Dictionary<string, IDataType>, IValueObject<IDataType>
     {
     }
 }