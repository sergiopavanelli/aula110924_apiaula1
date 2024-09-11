//https://github.com/alexmontanha/tutorial_api_dotnet


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/hello", (string name) =>

{
    var saudacao = DateTime.Now.Hour < 12 ? "Bom dia" : "Boa tarde";
    var retorno = $"{saudacao}, {name}";
    return retorno;
});

app.Run();

// http://localhost:{port}/hello?name=Montanha