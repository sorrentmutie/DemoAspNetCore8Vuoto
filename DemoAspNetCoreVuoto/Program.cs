var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddSingleton<ISaluto, SalutoFisso2>();
builder.Services.AddSingleton<ISaluto, SalutoFisso>();
builder.Services.AddSingleton<IClock, OrologioServer>();

var app = builder.Build();

//app.MapGet("/", (IEnumerable<ISaluto> saluti) => { 
//        var sal = saluti.First().Saluta("Salvatore");
//        return sal;
//    });

app.MapGet("/", (ISaluto saluto) => {
    var sal = saluto.Saluta("Salvatore");
    return sal;
});

app.Run();
