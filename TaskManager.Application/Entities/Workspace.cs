namespace TaskManager.Application.Entities
{
  public class Workspace
  {
    public Guid Id {get;private set;}
    public string Name {get;private set;} = String.Empty;

    public Guid TenantId {get;private set;}

    public Tenant? Tenant{get;private set;}

    public Guid CreatedByUserId { get; private set;}

    public User? CreatedByUser{get;private set;}

    public ICollection<Project> Projects {get;private set;} = new List<Project>();
    public DateTime CreatedAt {get;private set;}

    public bool IsDeleted {get;private set;}


  }
}