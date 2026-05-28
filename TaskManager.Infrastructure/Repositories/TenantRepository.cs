using TaskManager.Application.Interfaces;
using TaskManager.Infrastructure.Persistence;
using TaskManager.Application.Entities;
namespace TaskManager.Infrastructure.Repositories
{
  public class TenantRepository : Repository<Tenant>, ITenantRepository
    {
        public TenantRepository(AppDbContext context) : base(context)
        {
        }
    }
}