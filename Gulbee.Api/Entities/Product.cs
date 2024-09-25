namespace Gulbee.Api.Entities;
public class Product{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Kcal { get; set; }
    public int NutriId { get; set; }
    public int CategoryId { get; set; }
    public Nutri? Nutri { get; set; } 
    public Category? Category { get; set; } 
}