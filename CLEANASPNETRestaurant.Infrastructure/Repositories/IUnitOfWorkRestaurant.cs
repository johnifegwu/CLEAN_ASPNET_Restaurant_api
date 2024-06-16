

using Microsoft.EntityFrameworkCore;

namespace CLEANASPNETRestaurant.Infrastructure.Repositories
{
    internal interface IUnitOfWorkRestaurant : IDisposable
    {
        DbContext GetContext();
        IRepository<T> Repository<T>() where T : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
