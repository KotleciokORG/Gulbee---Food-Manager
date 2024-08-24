namespace Gulbee.Api.Dto;

public record ProductGetDto(){
    public int Id;
    public required string Name;
    public int Kcal;
    public double Fat;
    public double Carbo;
    public double Sugar;
    public double Proteins;
    public double Salt;
    public string? Category;
}