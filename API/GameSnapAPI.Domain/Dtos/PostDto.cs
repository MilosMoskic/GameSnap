namespace GameSnapAPI.Domain.Dtos;

public class PostDto
{
    public required string Title { get; set; }
    public string? Text { get; set; }
    public string? PhotoUrl { get; set; }
    public string? VideoUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public int AppUserId { get; set; }
}
