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
                Name = "Owoce"
            },
            new {
                Id = 2,
                Name = "Nabiał"
            },
            new {
                Id = 3,
                Name = "Warzywa"
            },
            new {
                Id = 4,
                Name = "Mięso"
            },
            new {
                Id = 5,
                Name = "Zboża"
            },
            new {
                Id = 6,
                Name = "Fast Food"
            },
            new {
                Id = 7,
                Name = "Oleje"
            },
            new {
                Id = 8,
                Name = "Gotowce"
            }
        );
        //data from ChatGPT
        modelBuilder.Entity<Nutri>().HasData(
            new { Id = 1, Carbo = 22.84, Fat = 0.33, Proteins = 1.09, Salt = 0d, Sugar = 12.23, Fiber = 2.0 },
            new { Id = 2, Carbo = 1.28, Fat = 33.14, Proteins = 24.9, Salt = 1.8, Sugar = 0.5, Fiber = 0.0 },
            new { Id = 3, Carbo = 9.58, Fat = 0.24, Proteins = 0.93, Salt = 0d, Sugar = 4.74, Fiber = 1.5 },
            new { Id = 4, Carbo = 0d, Fat = 13.6, Proteins = 27.3, Salt = 0.1, Sugar = 0d, Fiber = 0.0 },
            new { Id = 5, Carbo = 43.3, Fat = 4.2, Proteins = 8.8, Salt = 0.5, Sugar = 6.0, Fiber = 5.0 },
            new { Id = 6, Carbo = 30d, Fat = 15d, Proteins = 17d, Salt = 1d, Sugar = 5d, Fiber = 2.0 },
            new { Id = 7, Carbo = 0d, Fat = 100d, Proteins = 0d, Salt = 0d, Sugar = 0d, Fiber = 0.0 },
            new { Id = 8, Carbo = 44d, Fat = 6d, Proteins = 5d, Salt = 1.5, Sugar = 2d, Fiber = 1.0 },
            new { Id = 9, Carbo = 13.81, Fat = 0.17, Proteins = 0.26, Salt = 0d, Sugar = 10.39, Fiber = 0.8 },
            new { Id = 10, Carbo = 3.6, Fat = 3.3, Proteins = 10d, Salt = 0.1, Sugar = 4.7, Fiber = 0.5 },
            new { Id = 11, Carbo = 15.23, Fat = 0.14, Proteins = 0.36, Salt = 0.0, Sugar = 9.75, Fiber = 0.7 },
            new { Id = 12, Carbo = 3.38, Fat = 4.3, Proteins = 11.12, Salt = 0.6, Sugar = 2.7, Fiber = 1.2 },
            new { Id = 13, Carbo = 3.92, Fat = 0.2, Proteins = 0.88, Salt = 0.0, Sugar = 2.63, Fiber = 1.0 },
            new { Id = 14, Carbo = 0.0, Fat = 15.0, Proteins = 26.0, Salt = 0.1, Sugar = 0.0, Fiber = 0.0 },
            new { Id = 15, Carbo = 30.45, Fat = 1.5, Proteins = 6.0, Salt = 0.1, Sugar = 1.1, Fiber = 2.3 },
            new { Id = 16, Carbo = 33.33, Fat = 10.0, Proteins = 11.0, Salt = 1.0, Sugar = 3.0, Fiber = 4.0 },
            new { Id = 17, Carbo = 0.0, Fat = 100.0, Proteins = 0.0, Salt = 0.0, Sugar = 0.0, Fiber = 0.0 },
            new { Id = 18, Carbo = 39.0, Fat = 3.0, Proteins = 6.0, Salt = 1.5, Sugar = 2.0, Fiber = 3.5 },
            new { Id = 19, Carbo = 11.94, Fat = 0.65, Proteins = 1.2, Salt = 0.0, Sugar = 4.42, Fiber = 1.6 },
            new { Id = 20, Carbo = 3.4, Fat = 0.3, Proteins = 16.0, Salt = 0.5, Sugar = 2.7, Fiber = 1.0 },
            new { Id = 21, Carbo = 6.03, Fat = 0.3, Proteins = 1.0, Salt = 0.0, Sugar = 4.2, Fiber = 0.6 },
            new { Id = 22, Carbo = 1.5, Fat = 5.5, Proteins = 20.0, Salt = 1.5, Sugar = 1.0, Fiber = 1.1 },
            new { Id = 23, Carbo = 71.5, Fat = 3.1, Proteins = 13.3, Salt = 0.1, Sugar = 0.9, Fiber = 5.2 },
            new { Id = 24, Carbo = 41.4, Fat = 15.0, Proteins = 3.4, Salt = 1.3, Sugar = 0.4, Fiber = 2.5 },
            new { Id = 25, Carbo = 0.0, Fat = 100.0, Proteins = 0.0, Salt = 0.0, Sugar = 0.0, Fiber = 0.0 },
            new { Id = 26, Carbo = 30.0, Fat = 12.0, Proteins = 15.0, Salt = 1.8, Sugar = 3.5, Fiber = 1.9 },
            new { Id = 27, Carbo = 7.68, Fat = 0.3, Proteins = 0.67, Salt = 0.0, Sugar = 4.89, Fiber = 1.2 },
            new { Id = 28, Carbo = 4.99, Fat = 0.98, Proteins = 3.4, Salt = 0.1, Sugar = 5.0, Fiber = 0.4 },
            new { Id = 29, Carbo = 2.16, Fat = 0.16, Proteins = 0.65, Salt = 0.0, Sugar = 1.38, Fiber = 0.3 },
            new { Id = 30, Carbo = 1.43, Fat = 42.0, Proteins = 37.0, Salt = 1.8, Sugar = 0.45, Fiber = 0.0 },
            new { Id = 31, Carbo = 14.07, Fat = 0.33, Proteins = 0.81, Salt = 0.0, Sugar = 10.02, Fiber = 1.5 },
            new { Id = 32, Carbo = 1.7, Fat = 7.0, Proteins = 20.0, Salt = 1.7, Sugar = 0.5, Fiber = 0.0 },
            new { Id = 33, Carbo = 72.57, Fat = 1.87, Proteins = 10.67, Salt = 0.01, Sugar = 1.12, Fiber = 3.0 },
            new { Id = 34, Carbo = 36.0, Fat = 17.0, Proteins = 10.0, Salt = 1.5, Sugar = 1.8, Fiber = 2.4 },
            new { Id = 35, Carbo = 0.0, Fat = 100.0, Proteins = 0.0, Salt = 0.0, Sugar = 0.0, Fiber = 0.0 },
            new { Id = 36, Carbo = 28.0, Fat = 10.0, Proteins = 16.0, Salt = 2.0, Sugar = 3.0, Fiber = 2.0 },
            new { Id = 37, Carbo = 4.81, Fat = 0.12, Proteins = 0.88, Salt = 0.0, Sugar = 4.74, Fiber = 1.2 },
            new { Id = 38, Carbo = 9.63, Fat = 0.61, Proteins = 1.15, Salt = 0.0, Sugar = 5.41, Fiber = 0.8 },
            new { Id = 39, Carbo = 10.45, Fat = 0.12, Proteins = 0.91, Salt = 0.01, Sugar = 9.1, Fiber = 1.6 },
            new { Id = 40, Carbo = 2.0, Fat = 48.0, Proteins = 30.0, Salt = 2.5, Sugar = 0.7, Fiber = 0.0 }
        );

        modelBuilder.Entity<Product>().HasData(
            new { Id = 1, Name = "Banan", Kcal = 89, NutriId = 1, CategoryId = 1 },
            new { Id = 2, Name = "Ser Cheddar", Kcal = 402, NutriId = 2, CategoryId = 2 },
            new { Id = 3, Name = "Marchew", Kcal = 41, NutriId = 3, CategoryId = 3 },
            new { Id = 4, Name = "Kurczak", Kcal = 239, NutriId = 4, CategoryId = 4 },
            new { Id = 5, Name = "Chleb pełnoziarnisty", Kcal = 246, NutriId = 5, CategoryId = 5 },
            new { Id = 6, Name = "Burger", Kcal = 295, NutriId = 6, CategoryId = 6 },
            new { Id = 7, Name = "Oliwa z oliwek", Kcal = 884, NutriId = 7, CategoryId = 7 },
            new { Id = 8, Name = "Zupa instant", Kcal = 240, NutriId = 8, CategoryId = 8 },
            new { Id = 9, Name = "Jabłko", Kcal = 52, NutriId = 9, CategoryId = 1 },
            new { Id = 10, Name = "Jogurt naturalny", Kcal = 59, NutriId = 10, CategoryId = 2 },
            new { Id = 11, Name = "Gruszka", Kcal = 57, NutriId = 11, CategoryId = 1 },
            new { Id = 12, Name = "Serek wiejski", Kcal = 98, NutriId = 12, CategoryId = 2 },
            new { Id = 13, Name = "Pomidor", Kcal = 18, NutriId = 13, CategoryId = 3 },
            new { Id = 14, Name = "Wołowina", Kcal = 250, NutriId = 14, CategoryId = 4 },
            new { Id = 15, Name = "Makaron pełnoziarnisty", Kcal = 157, NutriId = 15, CategoryId = 5 },
            new { Id = 16, Name = "Pizza", Kcal = 266, NutriId = 16, CategoryId = 6 },
            new { Id = 17, Name = "Olej kokosowy", Kcal = 862, NutriId = 17, CategoryId = 7 },
            new { Id = 18, Name = "Gotowe pierogi", Kcal = 210, NutriId = 18, CategoryId = 8 },
            new { Id = 19, Name = "Malina", Kcal = 52, NutriId = 19, CategoryId = 1 },
            new { Id = 20, Name = "Twaróg chudy", Kcal = 72, NutriId = 20, CategoryId = 2 },
            new { Id = 21, Name = "Papryka", Kcal = 31, NutriId = 21, CategoryId = 3 },
            new { Id = 22, Name = "Szynka", Kcal = 145, NutriId = 22, CategoryId = 4 },
            new { Id = 23, Name = "Kasza gryczana", Kcal = 343, NutriId = 23, CategoryId = 5 },
            new { Id = 24, Name = "Frytki", Kcal = 312, NutriId = 24, CategoryId = 6 },
            new { Id = 25, Name = "Olej rzepakowy", Kcal = 884, NutriId = 25, CategoryId = 7 },
            new { Id = 26, Name = "Gotowa lasagna", Kcal = 300, NutriId = 26, CategoryId = 8 },
            new { Id = 27, Name = "Truskawka", Kcal = 32, NutriId = 27, CategoryId = 1 },
            new { Id = 28, Name = "Mleko", Kcal = 42, NutriId = 28, CategoryId = 2 },
            new { Id = 29, Name = "Ogórek", Kcal = 12, NutriId = 29, CategoryId = 3 },
            new { Id = 30, Name = "Boczek", Kcal = 541, NutriId = 30, CategoryId = 4 },
            new { Id = 31, Name = "Brzoskwinia", Kcal = 60, NutriId = 31, CategoryId = 1 },
            new { Id = 32, Name = "Kefir", Kcal = 65, NutriId = 32, CategoryId = 2 },
            new { Id = 33, Name = "Ryż brązowy", Kcal = 360, NutriId = 33, CategoryId = 5 },
            new { Id = 34, Name = "Hamburger", Kcal = 295, NutriId = 34, CategoryId = 6 },
            new { Id = 35, Name = "Olej lniany", Kcal = 884, NutriId = 35, CategoryId = 7 },
            new { Id = 36, Name = "Gotowa pizza", Kcal = 260, NutriId = 36, CategoryId = 8 },
            new { Id = 37, Name = "Czereśnia", Kcal = 50, NutriId = 37, CategoryId = 1 },
            new { Id = 38, Name = "Jogurt naturalny", Kcal = 61, NutriId = 38, CategoryId = 2 },
            new { Id = 39, Name = "Pomarańcza", Kcal = 47, NutriId = 39, CategoryId = 1 },
            new { Id = 40, Name = "Kabanos", Kcal = 500, NutriId = 40, CategoryId = 4 }
        );
    }
    //maybe some initialization for Categories

} 