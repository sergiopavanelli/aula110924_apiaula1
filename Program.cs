//https://github.com/alexmontanha/tutorial_api_dotnet


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

