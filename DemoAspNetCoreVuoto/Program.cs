var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddSingleton<ISaluto, SalutoFisso2>();
//builder.Services.AddSingleton<ISaluto, SalutoFisso>();
//builder.Services.AddSingleton<IClock, OrologioServer>();
//builder.Services.AddTransient<ISaluto, SalutoFisso>();
//builder.Services.AddTransient<IClock, OrologioServer>();
builder.Services.AddScoped<ISaluto, SalutoFisso>();
builder.Services.AddScoped<IClock, OrologioServer>();


var app = builder.Build();

//app.MapGet("/", (IEnumerable<ISaluto> saluti) => { 
//        var sal = saluti.First().Saluta("Salvatore");
//        return sal;
//    });

app.MapGet("/", (ISaluto saluto, ILogger<Program> logger) => {
    var sal = saluto.Saluta("Salvatore");
    logger.LogInformation("Esempio di log");
    return sal;
});

app.Run();
