using Gulbee.Api.Dto;

namespace Gulbee.Api.Endpoints;

public static class ProductEndpoints{
    private static readonly List<ProductGetDto> produkty = [
        new (){
            Id = 1,
            Name = "Banan",
            Kcal = 40,
            Carbo = 10,
            Fat = 3,
            Proteins = 5,
            Salt = 0,
            Sugar = 2,
            Category = "Owoc"
        },
        new (){
            Id = 2,
            Name = "Jabłko",
            Kcal = 40,
            Carbo = 10,
            Fat = 3,
            Proteins = 5,
            Salt = 0,
            Sugar = 2,
            Category = "Owoc"
        },
        new (){
            Id = 3,
            Name = "Truskawka",
            Kcal = 40,
            Carbo = 10,
            Fat = 3,
            Proteins = 5,
            Salt = 0,
            Sugar = 2,
            Category = "Owoc"
        }
    ];

    public static WebApplication MapProductEndpoints(this WebApplication app){
        var prodGroup = app.MapGroup("products");

        prodGroup.MapGet("/", () => Results.Ok(produkty));
        prodGroup.MapGet("/{id}", (int id) => produkty.Find(prod => prod.Id == id));

        prodGroup.MapPost("/", (ProductPostDto productPostDto) => produkty.Add(
            new ProductGetDto(){
                Id = productPostDto.Id,
                Name = productPostDto.Name,
                Kcal = productPostDto.Kcal,
                Carbo = productPostDto.Carbo,
                Fat = productPostDto.Fat,
                Proteins = productPostDto.Proteins,
                Salt = productPostDto.Salt,
                Sugar = productPostDto.Sugar,
                Category = "Owoc"
            }
        ));

        prodGroup.MapPut("/{id}", (int id, ProductUpdateDto productUpdateDto) => 
            {
                var replaceThis = produkty.Find(prod => prod.Id == id);
                int replaceId = produkty.IndexOf(replaceThis!);
                produkty[replaceId] = 
                new ProductGetDto(){
                    Id = productUpdateDto.Id,
                    Name = productUpdateDto.Name,
                    Kcal = productUpdateDto.Kcal,
                    Carbo = productUpdateDto.Carbo,
                    Fat = productUpdateDto.Fat,
                    Proteins = productUpdateDto.Proteins,
                    Salt = productUpdateDto.Salt,
                    Sugar = productUpdateDto.Sugar,
                    Category = "Owoc"
                };
            }
        );

        prodGroup.MapDelete("/{id}", (int id) => produkty.RemoveAll(prod => prod.Id == id));


        return app;
    }
}
