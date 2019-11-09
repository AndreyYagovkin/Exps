namespace Exps.Common.Queries
{
    public interface IQuerySingleParametrized<in TParam, out T>
    {
        T Execute(TParam @params);
    }
}