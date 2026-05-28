using TaskManager.Application.Entities;

namespace TaskManager.Application.Interfaces
{
  public interface IUserRepository : IRepository<User>
  {
    Task<User?> GetByEmailAsync (string email);
  }}