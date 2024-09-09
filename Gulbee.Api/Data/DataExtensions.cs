using Microsoft.EntityFrameworkCore;

namespace Gulbee.Api.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app){
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GulbeeContext>();
        await dbContext.Database.MigrateAsync();
    }
}