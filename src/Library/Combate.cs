using System;
using System.Collections;
using System.Collections.Generic;
using interfaces;
namespace combate{

public class Personajes: ICombate
{
    //metodos atacar y curar --- logica del juego
    public int  atacar (Personaje atacante, Personaje defensor)
    {
        int daño = atacante.AtaqueTotal();
        int defensa = defensor.AtaqueTotal();
        if (defensa > 0){
            defensa -= daño;
        }
        if (defensa == 0){
            defensor.vida -= daño;
        }
        Console.WriteLine($"{atacante.GetNombre()} ataca a {defensor.GetNombre()} por {daño} puntos de daño.");
        return defensor.vida;

    }
    public int defensa(Personaje atacante, Personaje defensor){
        int daño = atacante.AtaqueTotal();
        int defensa = defensor.AtaqueTotal();
        if (atacante.AtaqueTotal() > defensor.defensa){
            defensor.vida -=atacante.AtaqueTotal();
            Console.WriteLine($"el daño infligido fue de {atacante.AtaqueTotal()}");
        }
        if (atacante.AtaqueTotal()==defensor.defensa){
            Console.WriteLine("El ataque y la defensa son iguales, se anula");
        }
        else {
             Console.WriteLine("Se anulo, ya que la defensa es mayor al daño");
        }
        return defensor.vida;
    }
}
public class Mago : IMago
{
    private ArrayList libroDeHechizos;
    private int vidaMago;

    public Mago()
    {
        libroDeHechizos = new ArrayList();
        InicializarHechizos();
        vidaMago = 100; // Vida inicial del Mago
    }

    private void InicializarHechizos()
    {
        ArrayList hechizo1 = new ArrayList { 50, 0 }; // Bola de Fuego
        ArrayList hechizo2 = new ArrayList { 0, 25 }; // Curación Menor
        ArrayList hechizo3 = new ArrayList { 40, 10 }; // Rayo Congelante
        ArrayList hechizo4 = new ArrayList { 0, 30 }; // Escudo Mágico
        ArrayList hechizo5 = new ArrayList { 60, 0 }; // Llamarada

        libroDeHechizos.Add(hechizo1);
        libroDeHechizos.Add(hechizo2);
        libroDeHechizos.Add(hechizo3);
        libroDeHechizos.Add(hechizo4);
        libroDeHechizos.Add(hechizo5);
    }

    public int librohechizo()
    {
        int ataque = 0;
        int defensa = 0;

        foreach (ArrayList hechizo in libroDeHechizos)
        {
            ataque += (int)hechizo[0];
            defensa += (int)hechizo[1];
        }

        Console.WriteLine($"La defensa es {defensa} y el ataque es {ataque}");
        return 0;
    }

    public int curar()
    {
        if (vidaMago == 0)
        {
            Console.WriteLine("El mago está muerto, no se puede curar.");
        }
        else if (vidaMago >= 100)
        {
            Console.WriteLine("El mago ya tiene la vida máxima.");
        }
        else
        {
            vidaMago += 20; // Curar al mago aumentando su vida en 20 puntos
            if (vidaMago > 100)
            {
                vidaMago = 100; // Limitar la vida máxima a 100
            }
            Console.WriteLine($"La vida del mago ahora es {vidaMago}.");
        }

        return vidaMago;
    }
}
}