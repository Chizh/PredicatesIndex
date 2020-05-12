namespace PredicatesIndex.DataType.DataStructure
 {
     using System.Collections.Generic;

     public class ValueObject
        : Dictionary<string, IDataType>, IValueObject<IDataType>
     {
         public int CompareTo(
             object obj)
         {
             throw new System.NotImplementedException();
         }
     }
 }