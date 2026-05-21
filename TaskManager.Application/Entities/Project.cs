namespace TaskManager.Application.Entities
{
  public class Project
  {
    public Guid Id { get;private set;}
    public string Name {get;private set;} = String.Empty;

    public string Description {get;private set;} = String.Empty;
    public Guid TenantId {get;private set;}
    public Tenant? Tenant {get;private set;}
    public Guid WorkspaceId {get;private set;}
    public Workspace? Workspace {get;private set;}
    public Guid CreatedByUserId {get;private set;}

    public User? CreatedByUser{get;private set;}

    public ICollection<TaskItem> Tasks {get;private set;} = new List<TaskItem>();
    public DateTime CreatedAt{get;private set;}
    public bool IsDeleted {get;private set;}
  }
}