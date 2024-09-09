using Gulbee.Api.Data;
using Gulbee.Api.Dto;
using Microsoft.EntityFrameworkCore;

namespace Gulbee.Api.Endpoints;

public static class ProductEndpoints{

    public static  async WebApplication MapProductEndpoints(this WebApplication app){
        var prodGroup = app.MapGroup("products");

        prodGroup.MapGet("/", async (GulbeeContext dbContext) => 
        {
            return await dbContext.Products.
        });

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
