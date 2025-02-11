using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

var builder = WebApplication.CreateBuilder(args);
var AllowSomeStuff = "_AllowSomeStuff";
builder.Services.AddCors(options =>
{
	options.AddPolicy(name: AllowSomeStuff, builder => {
		builder.AllowAnyOrigin()
		.AllowAnyHeader()
		.AllowAnyMethod();
	});
});
var app = builder.Build();
app.UseCors(AllowSomeStuff);

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
        {return Results.BadRequest(f);}
    fruit.Add(f.name);
    return Results.Ok();
});

///////////////////////////////////////////////////////////

List<ToDo> toDos = new List<ToDo>() {
    new ToDo(0, "Get the tasks working", false),
	new ToDo(1, "Make it look nice", false),
	new ToDo(2, "Create a remove button", false),
    new ToDo(3, "Have a cup of tea", false)
};

app.MapGet("/api/tasks", () => Results.Ok(toDos));
app.MapGet("/api/tasks/{id}", (int id) => {
   return id < 0 || id >= toDos.Count ? Results.BadRequest("Invalid Id") : Results.Ok(toDos[id]);
});
app.MapPost("/api/tasks/", (ToDo todo) =>
{
    if (todo != null)
    {
        toDos.Add(todo);
        return Results.Ok();
    }
    return Results.BadRequest("null object");
});
app.MapPut("/api/tasks/update/{id}", (int id, ToDo todo) => {
    if (id < 0 || id >= toDos.Count) {
        return Results.NoContent();
	}
    toDos[id] = todo;
    return Results.Ok();
});
app.MapDelete("/api/tasks/delete/{id}", (int id) =>
{
    if (id < 0 || id >= toDos.Count)
    {
        return Results.NoContent();
    }
    toDos.RemoveAt(id);
    return Results.Ok();
});

////////////////////////////////////////////////////////////////////////////////////

List<Question> questions = new List<Question>();

app.MapGet("/api/questions", () => {
    List<qOnly> onlyQuestion = new();
    foreach (var q in questions) {
        onlyQuestion.Add(new qOnly(q.id, q.question));
    }
});
app.MapGet("/api/questions/{id}", (int id) => {
    Question? request = questions.Where(x => x.id == id).FirstOrDefault();
    if (request == null) {
        return Results.NoContent();
    }
    return Results.Ok(new qOnly(request.id, request.question));
});

app.MapGet("/api/questions/{id}/validate/{answer}", (int id, string answer) =>
{
    Question? request = questions.Where(x => x.id == id).FirstOrDefault();
    if (request == null)
    {
        return Results.BadRequest("The id had no question attached");
    }
    return Results.Ok(answer.ToLower() == request.answer.ToLower());
});

app.MapPost("/api/questions/addquestion", (Question question) => questions.Add(question));


app.Run();

public record ToDo(int id,string text, bool done);

public record Fruit {
    public string name { get; set; } = String.Empty;
}

public record Question (int id, string question, string answer);
public record qOnly (int id, string question);