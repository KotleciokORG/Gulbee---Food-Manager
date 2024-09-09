namespace Gulbee.Api.Dto;

public record ProductGetDto{
    public int Id; //it does not have to be shown, but will be helpful for updating
    public required string Name;
    public int Kcal;
    public double Fat;
    public double Carbo;
    public double Sugar;
    public double Proteins;
    public double Salt;
    public string? Category;
}