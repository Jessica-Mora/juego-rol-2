using System.Collections.Generic;

public class Personaje  
{   public string nombre;
    public int vida;
    public int ataque;
    public int defensa;
    public List<Elemento> Elementos {get; set;}

    public Personaje(string nombre, int vida, int ataque, int defensa){
        this.nombre = nombre;
        this.vida = vida;
        this.ataque = ataque;
        this.defensa = defensa;

       this.Elementos = new List<Elemento> ();
    }

    public Personaje(string nombre, int vida)
    {
        this.nombre = nombre;
        this.vida = vida;
    }

    public string GetNombre(){
        return nombre; 
    }
    public int GetVida(){
        return  vida;
    }
    public int SetVida(){
        return vida;
    }
    //
    public int GetAtaque(){
        return  ataque;
    }
    public int SetAtaque(){
        return ataque;
    }
    //
    public int GetDefensa(){
        return  defensa;
    }
    public int SetDefesa(){
        return defensa;
    }
    ////////////////////
    public void AgregarElemento(Elemento elemento)
    {
        Elementos.Add(elemento);
    }
    public void QuitarElemento(Elemento elemento)
    {
        Elementos.Remove(elemento);
    }
    //////
    public int DefensaTotal()
    {
        int defensaTotal = GetDefensa();
        foreach (Elemento elemento in Elementos)
            {
                defensaTotal += elemento.GetDefensa();
            }
        return defensaTotal;
    }
    public int AtaqueTotal()
    {
        int ataqueTotal = GetAtaque();
        foreach (Elemento elemento in Elementos)
            {
                ataqueTotal += elemento.GetAtaque();
            }
        return ataqueTotal;
    }


}