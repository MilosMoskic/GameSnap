using System.Text.Json;
using System.Text.Json.Serialization;

namespace GameSnapAPI.Domain.Models;

public class Post
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // navigation property
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; }

    public void SetPostContent(PostContent content)
    {
        Content = JsonSerializer.Serialize(content);
    }

    public PostContent? GetPostContent()
    {
        return JsonSerializer.Deserialize<PostContent>(Content);
    }
}
