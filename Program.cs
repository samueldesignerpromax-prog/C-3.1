using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 🔥 Porta do Render (agora funcionando)
var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
app.Urls.Add($"http://0.0.0.0:{port}");

app.MapGet("/", () => @"
<!DOCTYPE html>
<html>
<head>
    <title>Site em C#</title>
</head>
<body style='background:black;color:white;display:flex;justify-content:center;align-items:center;height:100vh;'>
    <h1>Site funcionando no Render 🚀</h1>
</body>
</html>
");

app.Run();
