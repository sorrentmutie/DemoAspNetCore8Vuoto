namespace DemoAspNetCoreVuoto.Services;

public class OrologioStatico: IClock
{
    public DateTime OraCorrente()
    {
        return new DateTime(2024, 1, 1, 10, 0, 0); 
    }
}

public class OrologioServer : IClock
{
    DateTime ora;
    public OrologioServer()
    {
        ora = DateTime.Now; 
    }

    public DateTime OraCorrente()
    {
        return ora;
    }
}

