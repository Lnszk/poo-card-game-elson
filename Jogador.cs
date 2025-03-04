public class Jogador
{
    public string Nome {get; }
    public int Energia {get; private set; }
    public int Vidas {get; private set; }
    public List<Carta> Deck { get; private set; }  // 20 cartas, sendo 10 de ataque e 10 de defesa.

    public Jogador(string nome) {
        Nome = nome;
        Energia = 10;
        Vidas = 30;
        Deck = new List<Carta>();
    }

    // Consome Energia do Jogador
    public void ConsumirEnergia(Carta carta) {
        Energia = Math.Max(0, this.Energia - carta.Energia);
    }

    // Restaura Energia do Jogador em 2 pontos, máximo 10
    public void RestaurarEnergia() {
        Energia = Math.Min(10, this.Energia + 2);
    }

    public void ReceberDano(CartaAtaque carta) {
        Vidas = Math.Max(0, this.Vidas - carta.Dano);

        // Se Vidas == 0, o jogador perdeu. (condição de vitória).
    }

    public void RestaurarVida(Carta carta) {
        CartaDefesa cartaDefesa = carta as CartaDefesa; // cast seguro
        Vidas = Math.Min(30, this.Vidas + cartaDefesa.Vida);
    }

    // Adicionar cartas ao deck
    public void IniciarDeck(List<Carta> cartas) {
        Deck.AddRange(cartas);
    }

    public List<Carta> ObterDeck() {
        return Deck;
    }

    // Selecionar uma carta para jogar
    public Carta SelecionarCarta(int indice) {
        Carta cartaSelecionada = Deck[indice];
        Deck.RemoveAt(indice);
        return cartaSelecionada;
    }
}