using Gulbee.Api.Data;
using Gulbee.Api.Dto;
using Gulbee.Api.Entities;
using Gulbee.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Gulbee.Api.Endpoints;

public static class ProductEndpoints{

    private static string GetProductEndointName = "GetProduct";
    public static  async WebApplication MapProductEndpoints(this WebApplication app){
        var prodGroup = app.MapGroup("products");

        prodGroup.MapGet("/", async (GulbeeContext dbContext) => 
        {
            return await dbContext.Products
                        .Select((Product p) => p.ToGetDto())
                        .AsNoTracking()
                        .ToListAsync(); 
        });

        prodGroup.MapGet("/{id}", async (int id, GulbeeContext dbContext) => 
        {
            Product? product = await dbContext.Products.FindAsync(id);
            return product is null ? 
                Results.NotFound() : Results.Ok(product.ToGetDto());
        }).WithName(GetProductEndointName);

        prodGroup.MapPost("/", async (ProductPostDto productPostDto, GulbeeContext dbContext) => 
        {
            Product product = productPostDto.ToEntity();

            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetProductEndointName,product.Id,product.ToGetDto());
        });

        prodGroup.MapPut("/{id}", async (int id, ProductUpdateDto productUpdateDto, GulbeeContext dbContext) => 
        {
            Product? product = await dbContext.Products.FindAsync(id);
            if(product is null) return Results.NotFound();
            dbContext.Entry(product)
                     .CurrentValues
                     .SetValues(productUpdateDto.ToEntity(id));
            await dbContext.SaveChangesAsync();
        });

        prodGroup.MapDelete("/{id}", async (int id, GulbeeContext dbContext) => 
        {
            await dbContext.Products
                           .Where(p => p.Id == id)
                           .ExecuteDeleteAsync();
            return Results.NoContent();
        });
        return app;
    }
}
