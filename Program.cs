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
            box-shadow: 0 0 30px rgba(0,0,0,0.5);
        }

        h1 {
            font-size: 42px;
            margin-bottom: 20px;
        }

        p {
            font-size: 20px;
            opacity: 0.9;
        }

        button {
            margin-top: 25px;
            padding: 12px 25px;
            font-size: 18px;
            border: none;
            border-radius: 10px;
            background: #ffffff;
            color: black;
            cursor: pointer;
            transition: 0.3s;
        }

        button:hover {
            transform: scale(1.1);
            background: #e2e8f0;
        }
    </style>
</head>
<body>
    <div class='box'>
        <h1>🚀 Esse é meu primeiro programa em C#</h1>
        <p>Rodando na web com estilo 😎</p>
        <button onclick='alert(""Você clicou! Tá funcionando 🔥"")'>
            Testar
        </button>
    </div>
</body>
</html>
");
