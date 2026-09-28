namespace MyBlazorApp.Data;

public class Rating
{
    public int Id { get; set; }

    public int Value { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public int UserId { get; set; }

    public User? User { get; set; }
}