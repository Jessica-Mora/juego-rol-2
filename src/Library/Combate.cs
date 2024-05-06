using System;
using System.Collections.Generic;

public class Combate 
{
    //metodos atacar y curar --- logica del juego
    public void atacar (Personaje atacante, Personaje defensor)
    {
        //int daño = atacante.AtaqueTotal() - defensor.DefensaTotal();
        int daño = atacante.AtaqueTotal();
        int puntos_defensa = defensor.DefensaTotal();
       //Aca estaba el if

        while (puntos_defensa > 0)
        {
            Console.WriteLine($"puntos de defensa {puntos_defensa}");
            Console.WriteLine($"{atacante.GetNombre()} ataca a {defensor.GetNombre()} por {daño} puntos de daño.");
            //int defensor.DefensaTotal -= daño;
            puntos_defensa -= daño;
            Console.WriteLine($"puntos de defensa {puntos_defensa}");
            Console.WriteLine($"{atacante.GetNombre()} ataca a {defensor.GetNombre()} por {daño} puntos de daño.");
        }
        
    }
    public void curar (Personaje personaje)
    {
        personaje.vida = 100;
        
    }
}

/* if (puntos_defensa > 0)
        {
            //int defensor.DefensaTotal -= daño;
            puntos_defensa -= daño;
        }
        Console.WriteLine($"{atacante.GetNombre()} ataca a {defensor.GetNombre()} por {daño} puntos de daño.");  */