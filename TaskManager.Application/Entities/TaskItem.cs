namespace TaskManager.Application.Entities
{
  public class TaskItem
  {
    public Guid Id{get;private set;}
    public string Title {get;private set;} = String.Empty;

    public string Description {get;private set;} = String.Empty;

    public TaskStatus Status{get;private set;}
    public DateTime? DueDate {get;private set;}

    public Guid TenantId{get;private set;}
    public Tenant? Tenant { get; private set;}
    public Guid ProjectId{get;private set;}

    public Project? Project {get;private set;}

    public Guid? AssignedToUserId {get;private set;}

    public User? AssignedToUser { get;private set;}
    public Guid CreatedByUserId{get;private set;}
    public User? CreatedByUser{get;private set;}
    public DateTime CreatedAt {get;private set;}
    public bool IsDeleted {get;private set;}
  }
}