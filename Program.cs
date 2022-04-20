using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

ILogger<Program> logger = app.Services.GetRequiredService<ILogger<Program>>();

//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.MapPost("/postresult", ([FromBody] object content, HttpRequest request) =>
{
    logger.LogInformation("------Start processing POST request. Content:------");
    logger.LogInformation(content.ToString());
    if (!String.IsNullOrEmpty(request.ContentType))
    {
        logger.LogInformation($"Content type: ${request.ContentType}");
        logger.LogInformation($"Host: ${request.Host.Value}");
    }
    logger.LogInformation("------End processing request------");
    return Task.FromResult(Results.Ok());
});

app.Run();
