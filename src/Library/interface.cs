namespace interfaces{
public interface ICombate
{
    int atacar(Personaje atacante, Personaje defensor);
    int defensa(Personaje atacante, Personaje defensor);
}
public interface IMago
{
    int librohechizo();
   int curar (Personaje personaje);
}
}