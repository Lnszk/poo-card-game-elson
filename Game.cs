public class Game {
    private List<Carta> cartas;
    private Jogador usuario;
    private Jogador computador;

    public Game() {
        cartas = new List<Carta>();
        cartas.Add(new CartaAtaque("Golpe Rápido", "Um corte veloz que fere o oponente.", 1, 2));
        cartas.Add(new CartaAtaque("Estocada Precisa", "Um ataque certeiro que perfura a defesa.", 2, 4));
        cartas.Add(new CartaAtaque("Machado Brutal", "Um golpe destruidor com machado pesado.", 3, 6));
        cartas.Add(new CartaAtaque("Espada Flamejante", "Um corte envolto em chamas, causando queimaduras.", 3, 5));
        cartas.Add(new CartaAtaque("Flecha Venenosa", "Atinge o inimigo e causa dano persistente.", 2, 3));
        cartas.Add(new CartaAtaque("Rajada de Gelo", "Um golpe congelante que reduz a movimentação.", 3, 4));
        cartas.Add(new CartaAtaque("Golpe Sombrio", "Um ataque das trevas, consumindo energia vital.", 4, 8));
        cartas.Add(new CartaAtaque("Fúria do Berserker", "Um ataque feroz, mas consome toda sua energia.", 5, 10));
        cartas.Add(new CartaAtaque("Impacto Sísmico", "Um golpe que faz o chão tremer, atingindo em cheio.", 6, 12));
        cartas.Add(new CartaAtaque("Lança Sombria", "Uma lança de energia negra atravessa o adversário.", 4, 6));
        cartas.Add(new CartaAtaque("Flecha Tripla", "Três flechas rápidas atingem o inimigo ao mesmo tempo.", 3, 5));
        cartas.Add(new CartaAtaque("Espinhos do Caos", "Projeta espinhos mágicos que perfuram a armadura.", 4, 7));
        cartas.Add(new CartaAtaque("Trovão Arcano", "Um raio destruidor cai sobre o oponente.", 5, 9));
        cartas.Add(new CartaAtaque("Golpe Veloz", "Um ataque ágil que confunde o inimigo.", 2, 4));
        cartas.Add(new CartaAtaque("Rajada de Lâminas", "Várias lâminas cortam o oponente de diferentes ângulos.", 4, 7));
        cartas.Add(new CartaAtaque("Garras da Fera", "Um ataque selvagem como de uma fera raivosa.", 3, 5));
        cartas.Add(new CartaAtaque("Chamas do Inferno", "Um fogo intenso consome o adversário.", 6, 11));
        cartas.Add(new CartaAtaque("Corte Duplo", "Dois cortes rápidos que ignoram parte da defesa.", 3, 5));
        cartas.Add(new CartaAtaque("Golpe Fantasma", "Uma espada espectral atinge o inimigo sem ser bloqueada.", 5, 9));
        cartas.Add(new CartaAtaque("Lança de Sangue", "Usa o próprio sangue para fortalecer o ataque.", 4, 7));
        cartas.Add(new CartaDefesa("Poção de Cura", "Uma poção básica que recupera energia vital.", 2, 4));
        cartas.Add(new CartaDefesa("Escudo Espiritual", "Uma barreira de luz bloqueia ataques.", 3, 6));
        cartas.Add(new CartaDefesa("Regeneração Mágica", "Uma magia que regenera feridas lentamente.", 4, 7));
        cartas.Add(new CartaDefesa("Cura do Druida", "A energia da natureza restaura suas forças.", 3, 5));
        cartas.Add(new CartaDefesa("Armadura de Pedra", "Endurece sua pele como rocha.", 4, 6));
        cartas.Add(new CartaDefesa("Aura de Vida", "Um brilho sagrado envolve o corpo, curando ferimentos.", 5, 8));
        cartas.Add(new CartaDefesa("Bênção dos Ancestrais", "Espíritos antigos restauram sua vitalidade.", 6, 10));
        cartas.Add(new CartaDefesa("Meditação Interior", "Acalma a mente e acelera a cura natural.", 2, 4));
        cartas.Add(new CartaDefesa("Pele de Aço", "Fortalece a resistência física por alguns instantes.", 3, 5));
        cartas.Add(new CartaDefesa("Muralha Arcana", "Uma barreira mágica absorve parte do impacto.", 4, 6));
        cartas.Add(new CartaDefesa("Fôlego Renovado", "Um segundo fôlego para continuar lutando.", 2, 3));
        cartas.Add(new CartaDefesa("Reflexos Felinos", "Movimentos rápidos evitam golpes fatais.", 3, 5));
        cartas.Add(new CartaDefesa("Escudo Elemental", "Uma barreira de fogo, gelo ou trovão protege você.", 4, 7));
        cartas.Add(new CartaDefesa("Proteção Divina", "Luz celestial fortalece sua alma.", 5, 9));
        cartas.Add(new CartaDefesa("Pele do Dragão", "Adquire resistência lendária temporária.", 6, 11));
        cartas.Add(new CartaDefesa("Poção de Vitalidade", "Uma mistura poderosa que restaura o vigor.", 2, 4));
        cartas.Add(new CartaDefesa("Resiliência Suprema", "Suporta ataques com a força de um titã.", 5, 9));
        cartas.Add(new CartaDefesa("Armadura Sagrada", "A luz purifica seu corpo, curando feridas profundas.", 6, 12));
        cartas.Add(new CartaDefesa("Restauração Total", "Uma magia suprema que regenera completamente.", 7, 15));
        cartas.Add(new CartaDefesa("Cura Sombria", "Poder negro que sacrifica um pouco de energia para curar.", 4, 6));

        usuario = new Jogador("Herói");
        computador = new Jogador("Vilão");
        

    }
    public void Run() {
        
    }
}


//    public static void Main(string[] args) {
//         Jogador jogador1 = new Jogador("Jogador 1");
//         Jogador jogador2 = new Jogador("Jogador 2");

//         List<Carta> cartas = new List<Carta> {
//             new CartaAtaque("Ataque 1", "Descrição do Ataque 1", 2, 5),
//             new CartaAtaque("Ataque 2", "Descrição do Ataque 2", 3, 7),
//             new CartaAtaque("Ataque 3", "Descrição do Ataque 3", 4, 9),
//             new CartaDefesa("Defesa 1", "Descrição da Defesa 1", 2, 5),
//             new CartaDefesa("Defesa 2", "Descrição da Defesa 2", 3, 7),
//             new CartaDefesa("Defesa 3", "Descrição da Defesa 3", 4, 9)
//         };

//         jogador1.IniciarDeck(cartas);
//         jogador2.IniciarDeck(cartas);

//         while (jogador1.Vidas > 0 && jogador2.Vidas > 0) {
//             Carta cartaJogador1 = jogador1.SelecionarCarta(0);
//             Carta cartaJogador2 = jogador2.SelecionarCarta(0);

//             cartaJogador1.Usar(jogador1, jogador2);
//             cartaJogador2.Usar(jogador2, jogador1);

//             Console.WriteLine($"Vidas Jogador 1: {jogador1.Vidas}");
//             Console.WriteLine($"Vidas Jogador 2: {jogador2.Vidas}");
//         }

//         if (jogador1.Vidas == 0) {
//             Console.WriteLine("Jogador 2 venceu!");
//         } else {
//             Console.WriteLine("Jogador 1 venceu!");
//         }
//     }