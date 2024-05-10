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
public class Mago:IMago{
public int librohechizo(){
    ArrayList libro = new ArrayList();
    ArrayList hechizo = new ArrayList();
    for (int i =0; i<5;i++){
        libro.Add(hechizo.Add(10)); //ataque
        libro.Add(hechizo.Add(5)); //defensa
    }
    int ataque=0;
    int defensa=0;
    for (int i =0; i<5;i++){
        ataque+=10;
        defensa+=5;
    }
    Console.WriteLine($"la defenza es {defensa} y el ataque es {ataque}");

    
    
    return 0;

    }
    public int curar(Personaje personaje){
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
        return personaje.vida;
       
    }
}
}
