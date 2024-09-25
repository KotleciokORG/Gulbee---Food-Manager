using Gulbee.Api.Data;
using Gulbee.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlite<GulbeeContext>("Data Source=Gulbee.db");

var app = builder.Build();

app.MapProductEndpoints();
app.MapCategoryEndpoints();

await app.MigrateDbAsync();

app.Run();
