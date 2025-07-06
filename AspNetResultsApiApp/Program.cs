var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

//app.Map("/", () => Results.Text("Home Page"));

//app.Run(async context =>
//{
//    await Results.Text("Hello People!")
//                .ExecuteAsync(context);
//});

//app.MapGet("/", () => Results.Text("Hello World!"));



//app.MapGet("/", () => Results.Content(
//    "<h1>Привет мир</h1>", 
//    "text/html",
//    System.Text.Encoding.Unicode));



//User bob = new User("Bobby", 25);
//var sam = new { Name = "Sammy", Age = 32 };

//app.Map("/", () => Results.Json(sam));
//app.Map("/user", () => Results.Json(bob));



//app.Map("/old", () => Results.LocalRedirect("/new"));
//app.Map("/new", () => Results.Text("New Page"));
//app.Map("/yandex", () => Results.Redirect("https://ya.ru"));

app.Map("/", async (context) =>
{
    context.Response.ContentType = "text/html";
    await context.Response.SendFileAsync("html/index.html");
});

app.Map("/form", (HttpContext context) =>
{
    if (context.Request.Method.ToUpper() == "GET")
        Results.Text("Get request");
    else
        Results.Text("Post request");
});


app.Run();

record class User(string Name, int Age);

//class User2
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public User2(string name, int age)
//    {
//        this.Name = name;
//        this.Age = age;
//    }
//}
