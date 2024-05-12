namespace interfaces
{
    public interface ICombate
    {
        int atacar(Personaje atacante, Personaje defensor);
        int defensa(Personaje atacante, Personaje defensor);
    }

    public interface IMago
    {
        int librohechizo();
        int curar();
    }

    public interface IEquipable
    {
        void EquiparArma(Arma arma);
        void EquiparDefensa(Defensa defensa);
    }
}