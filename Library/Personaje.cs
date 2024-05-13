using System;
using System.Collections;
using System.Collections.Generic;
using interfaces;


public class Personaje
{
    public string nombre;
    public int vida;
    public int ataque;
    public int defensa;
    public List<ElementoCombate> Elementos { get; set; }

    public Personaje(string nombre, int vida, int ataque, int defensa)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.ataque = ataque;
        this.defensa = defensa;
        this.Elementos = new List<ElementoCombate>();
    }

    public Personaje(string nombre, int vida)
    {
        this.nombre = nombre;
        this.vida = vida;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public int GetVida()
    {
        return vida;
    }

    public void AgregarElemento(ElementoCombate elemento)
    {
        Elementos.Add(elemento);
    }

    public void QuitarElemento(ElementoCombate elemento)
    {
        Elementos.Remove(elemento);
    }

    public int DefensaTotal()
    {
        int defensaTotal = defensa;
        foreach (ElementoCombate elemento in Elementos)
        {
            defensaTotal += elemento.GetDefensa();
        }
        return defensaTotal;
    }

    public int AtaqueTotal()
    {
        int ataqueTotal = ataque;
        foreach (ElementoCombate elemento in Elementos)
        {
            ataqueTotal += elemento.GetAtaque();
        }
        return ataqueTotal;
    }
}