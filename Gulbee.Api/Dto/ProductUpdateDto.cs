namespace Gulbee.Api.Dto;

public record ProductUpdateDto( //klient do mnie
    string Name,
    int Kcal,
    double Fat,
    double Carbo,
    double Sugar,
    double Proteins,
    double Salt,
    double Fiber,
    int CategoryId
);