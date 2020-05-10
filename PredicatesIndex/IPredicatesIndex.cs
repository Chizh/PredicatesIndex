namespace PredicatesIndex
{
    using System.Collections.Generic;
    using BoolExpressions.DisjunctiveNormalForm;
    using PredicatesIndex.Conditions;
    using PredicatesIndex.DataType.DataStructure;

    public interface IPredicatesIndex<TLeafValue>
    {
        void Add(
            DnfExpression<FieldCondition> dnfExpression,
            TLeafValue leafValue);

        HashSet<TLeafValue> Query(
            ValueObject valueObject);
    }
}