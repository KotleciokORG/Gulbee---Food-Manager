namespace Gulbee.Api.Dto;

public record ProductPostDto(){
    public int Id;
    public required string Name;
    public int Kcal;
    public double Fat;
    public double Carbo;
    public double Sugar;
    public double Proteins;
    public double Salt;
    public int Category;
}