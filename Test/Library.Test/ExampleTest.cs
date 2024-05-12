using NUnit.Framework;

namespace Test.Library
{
    public class CombateTest
    {
        public void Atacar_inflingiendo_daño()
        {
            Personaje atacante = new Personaje("Atacante", 100, 50, 0);
            Personaje defensor = new Personaje("Defensor", 100, 20, 0);
            ICombate combate = new Personajes();

            combate.atacar(atacante, defensor);

            Assert.Less(defensor.vida, 100); 
            
        public void Atacar_no_inflingiendo_daño()
        {
            
            Personaje atacante = new Personaje("Atacante", 100, 50, 0);
            Personaje defensor = new Personaje("Defensor", 100, 20, 100); 
            ICombate combate = new Personajes();

            combate.atacar(atacante, defensor);

            Assert.AreEqual(100, defensor.vida); // Verifica que la vida del defensor no haya cambiado
        }

        public void Curar()
        {
            Personaje personaje = new Personaje("Personaje", 80, 30, 20);
            IMago mago = new Mago("Mago", 100, 40, 20, 150); // Se crea un mago con poder mágico suficiente para curar
            int vidaInicial = personaje.GetVida();

            int vidaAntesDeCurar = personaje.GetVida();
            mago.curar(personaje);
            int vidaDespuésDeCurar = personaje.GetVida();

            Assert.Greater(vidaDespuésDeCurar, vidaAntesDeCurar); // Verifica que la vida del personaje haya aumentado
            Assert.AreEqual(vidaInicial + 20, vidaDespuésDeCurar); // Verifica que la vida del personaje sea la esperada después de curar
        }

        public void IntercambiarObjetos()
        {
            Personaje personaje1 = new Personaje("Personaje 1", 100, 50, 30);
            Personaje personaje2 = new Personaje("Personaje 2", 100, 40, 20);
            Arma armaPersonaje1 = new Arma("Espada", 20, 0);
            Defensa defensaPersonaje1 = new Defensa("Escudo", 0, 30);
            Arma armaPersonaje2 = new Arma("Hacha", 25, 0);

            personaje1.AgregarElemento(armaPersonaje1);
            personaje1.AgregarElemento(defensaPersonaje1);
            personaje2.AgregarElemento(armaPersonaje2);

            personaje1.IntercambiarElementos(personaje2, armaPersonaje1, armaPersonaje2);

            Assert.IsTrue(personaje1.Elementos.Contains(armaPersonaje2)); // Verifica que el personaje 1 tenga el arma del personaje 2
            Assert.IsFalse(personaje1.Elementos.Contains(armaPersonaje1)); // Verifica que el personaje 1 ya no tenga su arma original
            Assert.IsTrue(personaje2.Elementos.Contains(armaPersonaje1)); // Verifica que el personaje 2 tenga el arma original del personaje 1
            Assert.IsFalse(personaje2.Elementos.Contains(armaPersonaje2)); // Verifica que el personaje 2 ya no tenga su arma original
        }
        }      
    }
}   