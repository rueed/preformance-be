namespace UserManagement.Api.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; }=string.Empty;
    public bool IsCompleted { get; set; } = false;
    public DateTime CreatedAt { get; set; }= DateTime.UtcNow;
    public int UserId { get; set; } //Foreign key to the User entity
    public User User { get; set; } = null!; //Navigation property to represent the relationship between TaskItem and User. It allows you to access the user associated with a task.

}

