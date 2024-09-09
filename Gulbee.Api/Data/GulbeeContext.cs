using Gulbee.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gulbee.Api.Data;

public class GulbeeContext(DbContextOptions<GulbeeContext> options) : DbContext(options){
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new {
                Id = 1,
                Name = "Owoc"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new {   Id = 1,
                    Name = "Banan",
                    Kcal = 40,
                    Carbo = 10d,
                    Fat = 3d,
                    Proteins = 5d,
                    Salt = 0d,
                    Sugar = 2d,
                    CategoryId = 1
                },
            new {   Id = 2,
                    Name = "Jabłko",
                    Kcal = 40,
                    Carbo = 10d,
                    Fat = 3d,
                    Proteins = 5d,
                    Salt = 0d,
                    Sugar = 2d,
                    CategoryId = 1
                },
            new {   Id = 3,
                    Name = "Truskawka",
                    Kcal = 40,
                    Carbo = 10d,
                    Fat = 3d,
                    Proteins = 5d,
                    Salt = 0d,
                    Sugar = 2d,
                    CategoryId = 1
                }
        );
    }
    //maybe some initialization for Categories

} 