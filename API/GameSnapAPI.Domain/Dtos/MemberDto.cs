namespace GameSnapAPI.Domain.Dtos;

public class MemberDto
{
    public int Id { get; set; }
    public string? Username { get; set; }
    public DateOnly DateOfBirth { get; set; } 
    public string? KnownAs { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastActive { get; set; }
    public string? Games { get; set; }
    public string? ProfilePictureUrl { get; set; }
}
