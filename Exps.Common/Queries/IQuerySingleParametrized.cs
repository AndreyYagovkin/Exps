namespace Exps.Common.Queries
{
    public interface IQuerySingleParametrized<in TParam, out TModel>
    {
        TModel Execute(TParam @params);
    }
}