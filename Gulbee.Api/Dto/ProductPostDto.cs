namespace Gulbee.Api.Dto;

public record ProductPostDto(
    string Name,
    int Kcal,
    double Fat,
    double Carbo,
    double Sugar,
    double Proteins,
    double Salt,
    int CategoryId
);