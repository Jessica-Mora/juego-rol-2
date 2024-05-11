using System;
using System.Collections;
using System.Collections.Generic;
using interfaces;

namespace combate
{
    public class Personaje
    {
        public string nombre;
        public int vida;
        public int ataque;
        public int defensa;
        private Arma armaEquipada;
        private Defensa defensaEquipada;

        public Personaje(string nombre, int vida, int ataque, int defensa)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.ataque = ataque;
            this.defensa = defensa;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int AtaqueTotal()
        {
            int ataqueTotal = ataque;
            if (armaEquipada != null)
            {
                ataqueTotal += armaEquipada.ValorAtaque;
            }
            return ataqueTotal;
        }

        public int DefensaTotal()
        {
            int defensaTotal = defensa;
            if (defensaEquipada != null)
            {
                defensaTotal += defensaEquipada.ValorDefensa;
            }
            return defensaTotal;
        }

        public void EquiparArma(Arma arma)
        {
            armaEquipada = arma;
        }

        public void EquiparDefensa(Defensa defensa)
        {
            defensaEquipada = defensa;
        }
    }

    public class Personajes : ICombate
    {
        public int atacar(Personaje atacante, Personaje defensor)
        {
            int daño = atacante.AtaqueTotal();
            int defensa = defensor.DefensaTotal();
            if (defensa > 0)
            {
                defensa -= daño;
            }
            if (defensa == 0)
            {
                defensor.vida -= daño;
            }
            Console.WriteLine($"{atacante.GetNombre()} ataca a {defensor.GetNombre()} por {daño} puntos de daño.");
            return defensor.vida;
        }

        public int defensa(Personaje atacante, Personaje defensor)
        {
            int daño = atacante.AtaqueTotal();
            int defensa = defensor.DefensaTotal();
            if (atacante.AtaqueTotal() > defensor.DefensaTotal())
            {
                defensor.vida -= atacante.AtaqueTotal();
                Console.WriteLine($"el daño infligido fue de {atacante.AtaqueTotal()}");
            }
            if (atacante.AtaqueTotal() == defensor.DefensaTotal())
            {
                Console.WriteLine("El ataque y la defensa son iguales, se anula");
            }
            else
            {
                Console.WriteLine("Se anulo, ya que la defensa es mayor al daño");
            }
            return defensor.vida;
        }
    }
}