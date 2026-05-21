
namespace TaskManager.Application.Entities
{
  public class User
  {
    public Guid Id {get;private set;}
    public string Name {get;private set;} = String.Empty;
    public string Email{get;private set;} = String.Empty;

    public string PasswordHash{get;private set;} = String.Empty;

    public UserRole Role {get;private set;}

    public Guid TenantId {get;private set;}

    public Tenant? Tenant {get;private set;} 
    public DateTime CreatedAt {get;private set;}

    public bool IsDeleted{get;private set;}
  }
}