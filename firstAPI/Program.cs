using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


List<string> fruit = new List<string>{"Orange", "PassionFruit", "Strawberry", "Apple", "Banana", "Pineapple"};
Random rnd = new Random();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/hello/{name}", (string name) => new { Message = $"Hello {name}!" });
app.MapGet("/api/jello/{name}/{age}", (string name, string age) => new { Message = $"Jello {name} you know {age} is very old." });
app.MapGet("/api/fruit/all", () => new { Messege = String.Join(", ", fruit)});
app.MapGet("/api/fruit/byindex/{num}", (int num) => new { Message = num < fruit.Count && num>=0 ? fruit[num] : "We don't have that many fruits"});
app.MapGet("/api/fruit/random", () => new {Message = fruit[rnd.Next(fruit.Count)] });
app.MapPost("/api/fruit/add", (Fruit f) => {
    if (f == null)
        {Results.BadRequest(f);}
    fruit.Add(f.name);
    return;
});

app.Run();

public record Fruit {
    public string name { get; set; } = String.Empty;
}
