using Gulbee.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapProductEndpoints();

app.Run();
