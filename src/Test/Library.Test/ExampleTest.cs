using NUnit.Framework;

namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void dummyTest()
        {
            Assert.True(true);
        }
    
        [Test]
        public void TestNombrePersonaje()
        {
            const string nombre = "Nombre";
            const int vida = 100;
            const int ataque = 100;
            const int defensa = 100;

            Personaje personaje = new Personaje(nombre,  vida, ataque, defensa);
            //Assert.True(true);
            Assert.AreEqual(nombre, personaje.nombre);
        }
    
    
    }
}