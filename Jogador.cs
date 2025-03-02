public class Jogador
{
    public string Nome {get; }
    public int Energia {get; private set; }
    public int Vidas {get; private set; }
    public List<Carta> Deck { get; private set; }  // 20 cartas, sendo 10 de ataque e 10 de defesa.

    // construtor
    public Jogador(string nome)
    {
        Nome = nome;
        Energia = 10;
        Vidas = 30;
    }

    // Consome Energia do Jogador
    public void ConsumirEnergia(Carta carta)
    {
        Energia = Math.Max(0, this.Energia - carta.Energia);
    }

    // Restaura Energia do Jogador em 2 pontos, máximo 10
    public void RestaurarEnergia()
    {
        Energia = Math.Min(10, this.Energia + 2);
    }

    public void ReceberDano(CartaAtaque carta)
    {
        Vidas = Math.Max(0, this.Vidas - carta.Dano);

        // Se Vidas == 0, o jogador perdeu. (condição de vitória).
    }

    public void RestaurarVida(Carta carta)
    {
        // CartaDefesa cartaDefesa = (CartaDefesa)carta; // cast (coerção)
        CartaDefesa cartaDefesa = carta as CartaDefesa; // cast seguro

        Vidas = Math.Min(30, this.Vidas + cartaDefesa.Vida);
    }

    // Selecionar as cartas (escolher as cartas para compor seu deck)
    public void SelecionarCarta(){

    }

    // Adicionar cartas ao deck
    public void IniciarDeck(List<Carta> cartas) {
        Deck.AddRange(cartas);
    }
}