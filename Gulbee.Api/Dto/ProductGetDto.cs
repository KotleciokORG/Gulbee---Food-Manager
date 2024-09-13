namespace Gulbee.Api.Dto;

public record ProductGetDto(
    int Id, //it does not have to be shown, but will be helpful for updating
    string Name,
    int Kcal,
    double Fat,
    double Carbo,
    double Sugar,
    double Proteins,
    double Salt,
    string? Category
);