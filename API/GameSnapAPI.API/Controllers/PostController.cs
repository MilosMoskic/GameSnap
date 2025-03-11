using System;
using System.Security.Claims;
using GameSnapAPI.Application.Interfaces;
using GameSnapAPI.Domain.Dtos;
using GameSnapAPI.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class PostController(IPostService postService) : BaseApiController
{
    [HttpPost]
    public async Task<ActionResult<PostDto>> CreatePost(PostDto postDto)
    {
        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out var userId))
        {
            return Unauthorized("Invalid user ID.");
        }

        var post = await postService.CreatePostAsync(postDto, userId);

        return Ok(post);
    }
}
