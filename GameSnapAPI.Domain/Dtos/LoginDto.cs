using System;

namespace GameSnapAPI.Domain.Dtos;

public class LoginDto
{
    public required string UserName { get; set; }
    public required string Password { get; set; }
}