public class ElementoCombate
{
    public string nombre;
    public int ataque;
    public int defensa;

    public ElementoCombate(string nombre, int ataque, int defensa)
    {
        this.nombre = nombre;
        this.ataque = ataque;
        this.defensa = defensa;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public int GetAtaque()
    {
        return ataque;
    }

    public int GetDefensa()
    {
        return defensa;
    }
}