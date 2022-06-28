var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/tip/{amt:decimal}/{pct:int}", (decimal amt, int pct) => {
    return amt * (pct / 100m);
});

app.MapGet("/modulo/{a:int}/{b:int}", (int a, int b) => {
    int modulo = a - (a / b * b);
    return modulo;
});

app.MapGet("/factorial/{nbr:int}", (int nbr) => {
    long factorial = 1;
    for(int i = 2; i <= nbr; i++) {
        factorial *= i;
    }
    return Results.Ok(factorial);
});

app.Run("http://localhost:5000");
