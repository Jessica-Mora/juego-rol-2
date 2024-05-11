public class Arma
{
    public string Nombre { get; set; }
    public bool EsMagico { get; set; }
    public int ValorAtaque { get; set; }

    public Arma(string nombre, bool esMagico, int valorAtaque)
    {
        Nombre = nombre;
        EsMagico = esMagico;
        ValorAtaque = valorAtaque;
    }
}

public class Defensa
{
    public string Nombre { get; set; }
    public bool EsMagico { get; set; }
    public int ValorDefensa { get; set; }

    public Defensa(string nombre, bool esMagico, int valorDefensa)
    {
        Nombre = nombre;
        EsMagico = esMagico;
        ValorDefensa = valorDefensa;
    }
}