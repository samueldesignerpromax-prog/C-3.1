using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Porta do Render
var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
app.Urls.Add($"http://0.0.0.0:{port}");

app.MapGet("/", () => @"
<!DOCTYPE html>
<html>
<head>
    <title>Meu Primeiro Programa</title>
    <style>
        body {
            margin: 0;
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            background: linear-gradient(135deg, #4f46e5, #06b6d4, #22c55e);
            font-family: Arial;
            color: white;
        }

        .box {
            text-align: center;
            background: rgba(0,0,0,0.3);
            padding: 40px;
            border-radius: 20px;
        }

        h1 {
            font-size: 42px;
        }
    </style>
</head>
<body>
    <div class='box'>
        <h1>🚀 Esse é meu primeiro programa em C#</h1>
    </div>
</body>
</html>
");

app.Run();
