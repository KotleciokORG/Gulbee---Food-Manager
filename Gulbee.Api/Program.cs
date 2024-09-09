using Gulbee.Api.Data;
using Gulbee.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlite<GulbeeContext>("Data Source=Gulbee.db");

var app = builder.Build();

await app.MigrateDbAsync();
app.MapProductEndpoints();

app.Run();
