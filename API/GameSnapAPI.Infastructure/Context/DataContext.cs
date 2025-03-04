using Microsoft.EntityFrameworkCore;
using GameSnapAPI.Domain.Models;

namespace GameSnapAPI.Infastructure.Context;

// primary constructor
public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
