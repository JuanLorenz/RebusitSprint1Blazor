namespace MyBlazorApp.Data;

public class Comment
{
    public int Id { get; set; }

    public string Text { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public int UserId { get; set; }

    public User? User { get; set; }
}