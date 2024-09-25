using Gulbee.Api.Data;
using Gulbee.Api.Dto;
using Gulbee.Api.Entities;
using Gulbee.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Gulbee.Api.Endpoints;

public static class ProductEndpoints{

    private static string GetProductEndointName = "GetProduct";
    public static WebApplication MapProductEndpoints(this WebApplication app){
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
            Product? product = await dbContext.Products
                                              .Include((Product p) => p.Category)
                                              .Include((Product p) => p.Nutri)
                                              .SingleAsync(p => p.Id == id);
            return product is null ? 
                Results.NotFound() : Results.Ok(product.ToGetDto());
        }).WithName(GetProductEndointName);

        prodGroup.MapPost("/", async (ProductPostDto productPostDto, GulbeeContext dbContext) => 
        {
            Nutri nutritions = productPostDto.GetNutri();
            Product product = productPostDto.ToEntity();

            product.Nutri = nutritions;
            //product.Category = await dbContext.Categories.FindAsync(product.CategoryId);

            dbContext.Products.Add(product); 

            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetProductEndointName,new {id = product.Id},product.ToGetDto());
        });

        prodGroup.MapPut("/{id}", async (int id, ProductUpdateDto productUpdateDto, GulbeeContext dbContext) => 
        {
            Product? product = await dbContext.Products.FindAsync(id);
            if(product is null) return Results.NotFound();

            Nutri? nutritions = await dbContext.Nutritions.FindAsync(product.NutriId);
            if(nutritions is null) return Results.Conflict();
            
            var prod = productUpdateDto.ToEntity(id);
            var nutri = productUpdateDto.GetNutri();

            int nutriId = product.NutriId;
            prod.NutriId = nutriId;
            nutri.Id = nutriId;

            dbContext.Entry(product)
                     .CurrentValues
                     .SetValues(prod);
            dbContext.Entry(nutritions)
                     .CurrentValues
                     .SetValues(nutri);

            await dbContext.SaveChangesAsync();
            return Results.NoContent();
        });

        prodGroup.MapDelete("/{id}", async (int id, GulbeeContext dbContext) => 
        {
            await dbContext.Products
                           .Where(p => p.Id == id)
                           .ExecuteDeleteAsync();
            await dbContext.Nutritions
                           .Where(p => p.Id == id)
                           .ExecuteDeleteAsync(); //it should have the same id
            return Results.NoContent();
        });

        return app;
    }
}
