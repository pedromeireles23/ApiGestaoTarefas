namespace TaskManager.Application.Entities
{
  public class Tenant
  {
    public Guid Id {get;private set;}
    public string Name {get;private set;} = String.Empty;
    public DateTime CreatedAt {get;private set;}
    public List<User> Users { get;private set;} = new();


  }
}