namespace Exps.Common.Queries
{
    public interface IQuerySingle<out T>
    {
        T Execute();
    }
}