using System;
using System.Collections;
using System.Collections.Generic;
using interfaces;

public class Mago : Personaje, IMago
{
    private ArrayList libroDeHechizos;
    private int vidaMago;

    public Mago(string nombre, int vida, int ataque, int defensa, int poderMagico) : base(nombre, vida, ataque, defensa)
    {
        libroDeHechizos = new ArrayList();
        InicializarHechizos();
        vidaMago = vida;
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
        else if (vidaMago >= vida)
        {
            Console.WriteLine("El mago ya tiene la vida máxima.");
        }
        else
        {
            vidaMago += 20; // Curar al mago aumentando su vida en 20 puntos
            if (vidaMago > vida)
            {
                vidaMago = vida; // Limitar la vida máxima al valor original
            }
            Console.WriteLine($"La vida del mago ahora es {vidaMago}.");
        }
        return vidaMago;
    }
}