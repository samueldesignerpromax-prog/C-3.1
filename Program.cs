using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 🔥 ESSENCIAL PARA RENDER
var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";
app.Urls.Add($"http://0.0.0.0:{port}");

app.MapGet("/", () => @"
<!DOCTYPE html>
<html>
<head>
    <title>Site em C#</title>
    <style>
        body {
            margin: 0;
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            background: linear-gradient(135deg, #0f172a, #1e293b);
            font-family: Arial;
            color: white;
        }
        .box {
            text-align: center;
        }
        h1 {
            font-size: 45px;
            color: #38bdf8;
        }
        button {
            margin-top: 20px;
            padding: 10px 20px;
            border: none;
            background: #38bdf8;
            color: black;
            font-size: 18px;
            cursor: pointer;
            border-radius: 8px;
        }
        button:hover {
            background: #0ea5e9;
        }
    </style>
</head>
<body>
    <div class='box'>
        <h1>Meu Site em C# com Docker 🚀</h1>
        <p>Rodando no Render!</p>
        <button onclick='alert(""Funcionando perfeitamente!"")'>Testar</button>
    </div>
</body>
</html>
");

app.Run();
