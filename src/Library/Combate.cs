using System;
using System.Collections.Generic;

public class Combate 
{
    //metodos atacar y curar --- logica del juego
    public void atacar (Personaje atacante, Personaje defensor)
    {
        int daño = atacante.AtaqueTotal() - defensor.DefensaTotal();
        if (daño > 0)
        {
            defensor.vida -= daño;
        }
        Console.WriteLine($"{atacante.GetNombre()} ataca a {defensor.GetNombre()} por {daño} puntos de daño.");

    }
    public void curar (Personaje personaje)
    {
        personaje.vida = 100;
        
    }
}