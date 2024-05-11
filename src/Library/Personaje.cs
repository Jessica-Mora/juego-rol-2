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