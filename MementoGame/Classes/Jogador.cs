using MementoGame.Classes;
public class Jogador
{
    public int Vida { get; private set; } = 100;

    public void TomarDano(int dano)
    {
        Vida -= dano;
        if (Vida < 0) Vida = 0;
        Console.WriteLine($"Jogador tomou {dano} de dano. Vida atual: {Vida}");
    }

    public void Curar(int cura)
    {
        Vida += cura;
        if (Vida > 100) Vida = 100;
        Console.WriteLine($"Jogador se curou em {cura}. Vida atual: {Vida}");
    }

    public JogadorMemento SalvarEstado()
    {
        Console.WriteLine($"Checkpoint salvo (Vida: {Vida})");
        return new JogadorMemento(Vida);
    }

    public void RestaurarEstado(JogadorMemento memento)
    {
        Vida = memento.Vida;
        Console.WriteLine($"Estado restaurado! Vida atual: {Vida}");
    }
}