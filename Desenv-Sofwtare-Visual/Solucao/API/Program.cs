// Testar as APIs
// - rest Client - Extensão do VS Code
// - Postman
// - Insomnia

// MINIMAL APIs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// EndPoints - Funcionalidades
// Configurar a URL e o método/verbo
app.MapGet("/", () => "1 Hello World em C#!");

app.MapGet("/segundaFunc", () => "2 Hello World em C#!");

app.MapGet("/retornarendereco", () => {
    dynamic endereco = new {
        rua = "Parigot de Souzaw",
        numero = 3000,
        cep = "81290-350"
    };

    return endereco;
});

// criar Endpoint para receber informações
// - Receber informações pela URL da requisição
// - Pelo informações pelo corpo da requisição
//Guardar as requisições em uma lista;

app.Run();
