using System.Collections.Generic;

public class Elemento  
{   public string nombre;
    public int ataque;
    public int defensa;
    

    public Elemento(string nombre, int ataque, int defensa){
        this.nombre = nombre;
        this.ataque = ataque;
        this.defensa = defensa;
   
    }

    public string GetNombre(){
        return nombre; 
    }
    public int GetAtaque(){
        return  ataque;
    }
    public int SetAtaque(){
        return ataque;
    }
    public int GetDefensa(){
        return  defensa;
    }
    public int SetDefesa(){
        return defensa;
    }


}
