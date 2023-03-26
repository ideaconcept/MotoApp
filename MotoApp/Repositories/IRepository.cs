using MotoApp.Entities;

namespace MotoApp.Repositories
{
    public interface IRepository<T> : IWriteRepository<T>, IReadRepository<T>
        where T : class, IEntity
    {
    }
}
