using MementoGame.Classes;

Jogador jogador = new Jogador();
Checkpoint checkpoint = new Checkpoint();

Console.WriteLine($"Jogo iniciado! Vida do jogador: {jogador.Vida}");

checkpoint.Salvar(jogador.SalvarEstado());

jogador.TomarDano(30);
checkpoint.Salvar(jogador.SalvarEstado());

jogador.TomarDano(50);

jogador.RestaurarEstado(checkpoint.Restaurar());

jogador.RestaurarEstado(checkpoint.Restaurar());

Console.WriteLine("Simulação concluída!");
Console.ReadLine();