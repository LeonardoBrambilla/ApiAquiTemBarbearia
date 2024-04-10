// Declare the partial Program class with Main method
partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");
        var builder = WebApplication.CreateBuilder(args);

        // Configure services
        builder.Services.AddEndpointsApiExplorer();

        var app = builder.Build();

        // Define routes
        app.MapGet("/", () => "Hello Worl");
        app.MapPost("/test", () => "Hello World!");

        // Run the application
        app.Run();
    }
}
