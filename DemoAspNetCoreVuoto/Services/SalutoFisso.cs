namespace DemoAspNetCoreVuoto.Services;

public class SalutoFisso : ISaluto
{
    private readonly IClock clock;

    public SalutoFisso(IClock clock)
    {
        this.clock = clock;
    }

    public string Saluta(string nome)
    {
        if(clock.OraCorrente().Hour <= 12)
        {
            return $"Buongiorno, {nome} {clock.OraCorrente().ToString()}";
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
