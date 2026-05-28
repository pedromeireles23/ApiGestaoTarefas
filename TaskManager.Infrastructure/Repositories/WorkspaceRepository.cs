using TaskManager.Application.Interfaces;
using TaskManager.Infrastructure.Persistence;
using TaskManager.Application.Entities;
namespace TaskManager.Infrastructure.Repositories
{
  public class WorkspaceRepository : Repository<Workspace>, IWorkspaceRepository
    {
        public WorkspaceRepository(AppDbContext context) : base(context)
        {
        }
    }
}