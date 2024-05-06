using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {string print = "hola";
        Console.WriteLine(print);

        // pruebas de clases
        //prueba imprimir elemento
        Elemento Espada = new Elemento("espada", 55, 60);
        Console.WriteLine($"elemento {Espada.GetNombre()}, ataque {Espada.GetAtaque()}, defensa {Espada.GetDefensa()}");
        
        //prueba imprimir clase mago
        Mago ma_1 = new Mago ("el mago", 100, 50, 70, 150);
        Console.WriteLine($"el nombre del personaje es: {ma_1.GetNombre()}, su vida es: {ma_1.GetVida()}, su ataque {ma_1.GetAtaque()}, su defensa {ma_1.GetDefensa()} y su poder magico: {ma_1.GetPoderMagico()}");
        // agrega elementos al personaje
        ma_1.AgregarElemento(Espada);
        
        Console.WriteLine($"defensa total: {ma_1.DefensaTotal()}");
        //imprime los elementos del personaje, su daño y su defensa
        foreach (Elemento elemento in ma_1.Elementos)
            {
                Console.WriteLine($"Elemento: {elemento.GetNombre()}, Ataque: {elemento.GetAtaque()}, Defensa: {elemento.GetDefensa()}");
            }
        
         
       }
    }
}

 
/* 
/
       
               Elemento Hacha = new Elemento("Hacha", 55, 60);
        Console.WriteLine($"elemento {Hacha.GetNombre()}, ataque {Hacha.GetAtaque()}, defensa {Hacha.GetDefensa()}");
        //prueba imprimir clase mago
        Enano en_1 = new Enano ("el Enano", 100, 50, 70);
        Console.WriteLine($"el nombre del personaje es: {en_1.GetNombre()}, su vida es: {en_1.GetVida()}, su ataque {en_1.GetAtaque()}, su defensa {en_1.GetDefensa()}");
        en_1.AgregarElemento(Hacha);
        */