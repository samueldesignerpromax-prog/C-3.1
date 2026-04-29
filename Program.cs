using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
app.Urls.Add($"http://0.0.0.0:{port}");

app.MapGet("/", () => @"
<!DOCTYPE html>
<html>
<head>
    <title>Meu Site Profissional</title>
    <style>
        body {
            margin: 0;
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            background: linear-gradient(135deg, #0f172a, #1e293b);
            color: white;
            font-family: Arial;
        }
        .box {
            text-align: center;
        }
        h1 {
            font-size: 40px;
            color: #38bdf8;
        }
        button {
            margin-top: 20px;
            padding: 10px 20px;
            border: none;
            background: #38bdf8;
            cursor: pointer;
            border-radius: 8px;
        }
    </style>
</head>
<body>
    <div class='box'>
        <h1>Meu primeiro site em C# 🚀</h1>
        <button onclick='alert(""Funcionando!"")'>Clique aqui</button>
    </div>
</body>
</html>
");

app.Run();
