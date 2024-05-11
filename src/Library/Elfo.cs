using System.Collections.Generic;
public class Elfo : Personaje
{
   private List<Elemento> equipamiento;

   public Elfo(string nombre, int vida, int ataque, int defensa) : base(nombre, vida, ataque, defensa)
   {
       equipamiento = new List<Elemento>();
   }

   public void EquiparArma(Arma arma)
   {
       equipamiento.Add(arma);
       AtaqueTotal += arma.ValorAtaque;
   }

   public void EquiparDefensa(Defensa defensa)
   {
       equipamiento.Add(defensa);
       DefensaTotal += defensa.ValorDefensa;
   }

   public void EquiparArmaDefensa(ArmaDefensa armaDefensa)
   {
       equipamiento.Add(armaDefensa);
       AtaqueTotal += armaDefensa.ValorAtaque;
       DefensaTotal += armaDefensa.ValorDefensa;
   }

   public override int AtaqueTotal
   {
       get
       {
           int ataqueTotal = base.AtaqueTotal;
           foreach (Elemento elemento in equipamiento)
           {
               ataqueTotal += elemento.ValorAtaque;
           }
           return ataqueTotal;
       }
   }

   public override int DefensaTotal
   {
       get
       {
           int defensaTotal = base.DefensaTotal;
           foreach (Elemento elemento in equipamiento)
           {
               defensaTotal += elemento.ValorDefensa;
           }
           return defensaTotal;
       }
   }
}