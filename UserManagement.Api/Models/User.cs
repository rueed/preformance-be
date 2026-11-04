namespace UserManagement.Api.Models;

public class User
{ //All the properties of the User class are defined here. Each property has a type and a name, and they can be accessed and modified using the get and set accessors.
    public int Id { get; set; } //Property in generale public (type:like int , string) (value:name) {get; set;}
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public UserStatus Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<TaskItem> Tasks { get; set; } = new List<TaskItem>(); //Navigation property to represent the relationship between User and TaskItem. It allows you to access the tasks associated with a user.>
}



