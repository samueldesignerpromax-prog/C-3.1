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
            background: linear-gradient(135deg, #000000, #1e3a8a, #9333ea);
            font-family: Arial;
            color: white;
        }

        h1 {
            font-size: 80px; /* 🔥 BEM GRANDE */
            text-align: center;
            background: linear-gradient(90deg, #22c55e, #06b6d4, #facc15);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            animation: pulse 2s infinite;
        }

        @keyframes pulse {
            0% { transform: scale(1); }
            50% { transform: scale(1.1); }
            100% { transform: scale(1); }
        }
    </style>
</head>
<body>
    <h1>🚀 ESSE É MEU PRIMEIRO PROGRAMA EM C# 🚀</h1>
</body>
</html>
");
