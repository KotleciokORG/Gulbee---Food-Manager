using Gulbee.Api.Data;
using Gulbee.Api.Dto;
using Gulbee.Api.Entities;
using Gulbee.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Gulbee.Api.Endpoints;

public static class CategoryEndpoints{

    private static string GetCategoryEndointName = "GetCategory";
    public static WebApplication MapCategoryEndpoints(this WebApplication app){
        var prodGroup = app.MapGroup("category");

        prodGroup.MapGet("/", async (GulbeeContext dbContext) => 
        {
            return await dbContext.Categories
                        .AsNoTracking()
                        .ToListAsync(); 
        });

        

        return app;
    }
}
