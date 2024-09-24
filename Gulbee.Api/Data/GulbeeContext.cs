using Gulbee.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gulbee.Api.Data;

public class GulbeeContext(DbContextOptions<GulbeeContext> options) : DbContext(options){
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Nutri> Nutritions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new {
                Id = 1,
                Name = "Owoc"
            }
        );
        modelBuilder.Entity<Nutri>().HasData(
            new {   Id = 1,
                    Carbo = 10d,
                    Fat = 3d,
                    Proteins = 5d,
                    Salt = 0d,
                    Sugar = 2d,
                },
            new {   Id = 2,
                    Carbo = 10d,
                    Fat = 3d,
                    Proteins = 5d,
                    Salt = 0d,
                    Sugar = 2d,
                },
            new {   Id = 3,
                    Carbo = 10d,
                    Fat = 3d,
                    Proteins = 5d,
                    Salt = 0d,
                    Sugar = 2d,
                }
        );
        modelBuilder.Entity<Product>().HasData(
            new {   Id = 1,
                    Name = "Banan",
                    Kcal = 40,
                    NutriId = 1,
                    CategoryId = 1
                },
            new {   Id = 2,
                    Name = "Jabłko",
                    Kcal = 40,
                    NutriId = 2,
                    CategoryId = 1
                },
            new {   Id = 3,
                    Name = "Truskawka",
                    Kcal = 40,
                    NutriId = 3,
                    CategoryId = 1
                }
        );
    }
    //maybe some initialization for Categories

} 