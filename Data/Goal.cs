namespace MyBlazorApp.Data;

public class Goal
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public int UserId { get; set; }

    public User? User { get; set; }
}