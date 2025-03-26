using Blog.Core.Entities;
using Blog.DataLayer.Repositories.Abstract;

namespace Blog.DataLayer.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();

        Task<int> SaveChangesAsync();
        int Save();

    }
}
