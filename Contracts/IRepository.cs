using System.Data;

namespace Contracts
{
    public interface IRepository<T>
    {
        IDbConnection Open();
    }
}
