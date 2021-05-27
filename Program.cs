using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
await using var app = builder.Build();

app.MapGet("/", (System.Func<string>)(() => "Hello World HERE!"));

await app.RunAsync();