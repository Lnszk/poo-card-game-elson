// Início do Jogo

CartaAtaque cartaAtaque04 = new CartaAtaque("Espada Flamejante", "Um corte envolto em chamas, causando queimaduras.", 3, 5);
CartaDefesa cartaDefesa01 = new CartaDefesa("Poção de Cura", "Uma poção básica que recupera energia vital.", 2, 4);
CartaAtaque cartaAtaque10 = new CartaAtaque("Lança Sombria", "Uma lança de energia negra atravessa o adversário.", 4, 6);

Jogador heroi = new Jogador("Herói");
Jogador vilao = new Jogador("Vilão");


// Sua mão:
// 1: Espada Flamejante (Custo: 3, Dano: 5)
// 2: Poção de Vida (Custo: 2, Cura: 4)
// Escolha uma carta para jogar (1 ou 2):

// "Herói usou Espada Flamejante, causando 5 de dano!"
// Vilão - Vida: 25

// "Herói usou Poção de Vida, recuperando 4 de vida!"
// Herói - Vida: 30



// "Vilão usou Lança Sombria, causando 6 de dano!"
//Herói - Vida: 24










// Jogadores regeneram 2 pontos de energia e o próximo turno começa





// CartaAtaque cartaA = new CartaAtaque("Golpe Forte", "Um golpe forte que causa muito dano.", 3, 5);
// CartaDefesa cartaD = new CartaDefesa("Poção de Cura", "Uma poção básica que recupera energia vital.", 3, 3);


// Jogador jogador1 = new Jogador("Jogador 1");
// Jogador jogador2 = new Jogador("Jogador 2");

// carta.Usar(jogador1, jogador2);  // errado!

// cartaA.Usar(jogador1, jogador2);
// cartaD.Usar(jogador2, jogador1);

// Console.WriteLine(jogador1.Vidas);
// Console.WriteLine(jogador2.Vidas);