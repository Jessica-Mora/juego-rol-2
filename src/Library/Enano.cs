using System;
using System.Collections;
using System.Collections.Generic;
using interfaces;



public class Enano : Personaje
{
    private List<ElementoCombate> equipamiento;

    public Enano(string nombre, int vida, int ataque, int defensa) : base(nombre, vida, ataque, defensa)
    {
        equipamiento = new List<ElementoCombate>();
    }

    public void EquiparArma(Arma arma)
    {
        equipamiento.Add(arma);
    }

    public void EquiparDefensa(Defensa defensa)
    {
        equipamiento.Add(defensa);
    }
}