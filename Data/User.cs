using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Data;

public class User
{
    public int Id { get; set; }

    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;

    public List<Goal> Goals { get; set; } = new();

    public List<Comment> Comments { get; set; } = new();

    public List<Rating> Ratings { get; set; } = new();
}