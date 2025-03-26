namespace GameSnapAPI.Domain.Dtos;

public class UserPostDto
{
    public required string Title { get; set; }
    public string? Text { get; set; }
    public string? PhotoUrl { get; set; }
    public string? VideoUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public required string Username { get; set; }
    public string? ProfilePictureUrl { get; set; }
}
