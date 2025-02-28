// Carta carta1 = new Carta("Golpe Rápido", "Um corte veloz que fere o oponente.", 1);

CartaAtaque cartaA = new CartaAtaque("Golpe Forte", "Um golpe forte que causa muito dano.", 3, 5);
CartaDefesa cartaD = new CartaDefesa("Poção de Cura", "Uma poção básica que recupera energia vital.", 3, 3);


Jogador jogador1 = new Jogador("Jogador 1");
Jogador jogador2 = new Jogador("Jogador 2");

// carta.Usar(jogador1, jogador2);  // errado!

cartaA.Usar(jogador1, jogador2);
cartaD.Usar(jogador2, jogador1);

Console.WriteLine(jogador1.Vidas);
Console.WriteLine(jogador2.Vidas);