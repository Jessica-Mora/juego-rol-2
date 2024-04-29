using System.Collections.Generic;

public class Mago : Personaje       //esto significa que la clase mago tiene atributos heredados de la clase personaje
{
    public int poderMagico;
    public Mago (string nombre, int vida, int ataque, int defensa, int poderMagico): base (nombre, vida, ataque, defensa){ //el base indica cuales parametros son heredados
    this.poderMagico = poderMagico;
    }

    public int GetPoderMagico(){
    return poderMagico;
    }




}

