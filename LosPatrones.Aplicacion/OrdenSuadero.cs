using static System.Console;

namespace LosPatrones.Aplicacion;

public class OrdenSuadero
{
    public void PrepararTacos()
    {
        WriteLine($"Asando carne de suadero");
        WriteLine("Preparando los tacos");
    }

    public void CobrarOrden()
    {
        WriteLine($"Cobrando $65.5");
    }

    public void EntregarOrden()
    {
        WriteLine($"Mandando ordén de 3 tacos");
    }
}