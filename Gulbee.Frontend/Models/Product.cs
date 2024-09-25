namespace Gulbee.Frontend.Models;


public class Product{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Kcal { get; set; }
    public double? Fat { get; set; }
    public double? Carbo { get; set; }
    public double? Sugar { get; set; }
    public double? Proteins { get; set; }
    public double? Salt { get; set; }
    public int CategoryId { get; set; }
    public string? Category { get; set; }
}