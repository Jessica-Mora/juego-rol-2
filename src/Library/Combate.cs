using System;
using System.Collections.Generic;

public class Combate 
{
    //metodos atacar y curar --- logica del juego
    public void atacar (Personaje atacante, Personaje defensor)
    {
        int daño = atacante.AtaqueTotal() - defensor.DefensaTotal();
        if (defensor.vida>0){
        if (daño > 0)
        {
            defensor.vida -= daño;
        }}
        Console.WriteLine($"{atacante.GetNombre()} ataca a {defensor.GetNombre()} por {daño} puntos de daño.");

    }
    public void curar (Personaje personaje)
    {

        if (personaje.vida == 0){
            Console.WriteLine("Su personaje esta muerto");
        }
        if (personaje.vida>100){
            Console.WriteLine("su personaje esta al maximo de vida, no es posible curarlo.");
            }
        else {
             personaje.vida = personaje.ataque/2;
             Console.WriteLine($"ALa Vida de su personaje es {personaje.vida}.");
             }
    }
}