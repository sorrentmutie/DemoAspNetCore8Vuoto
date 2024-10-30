namespace DemoAspNetCoreVuoto.Services;

public class SalutoFisso : ISaluto
{
    private readonly IClock clock;
    private readonly IConfiguration configuration;

    public SalutoFisso(IClock clock, IConfiguration configuration)
    {
        this.clock = clock;
        this.configuration = configuration;
        //this.logger = logger;
    }

    public string Saluta(string nome)
    {
        if(clock.OraCorrente().Hour <= 12)
        {
            return $"{configuration["Saluto"]}, {nome} {clock.OraCorrente().ToString()}";
        }
        return $"Buonasera, {nome}";
    }
}

public class SalutoFisso2: ISaluto
{
    public string Saluta(string nome)
    {
        return $"Ciao 2, {nome}!";
    }
}
