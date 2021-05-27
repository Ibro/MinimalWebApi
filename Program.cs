using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);
await using var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", (Func<string>)(() => "Hello World HERE!"));

await app.RunAsync();
