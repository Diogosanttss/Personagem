namespace Auladepoo;

class Program
{
    static void Main(string[] args)
    {
        Personagem jogador = new Personagem("Jack");

        jogador.PegarItem("Cajado mágico");
        jogador.PegarItem("poção de cura");
        jogador.MostrarInventario();

        jogador.Atacar("Bruxo");
        jogador.LargarItem("Cajado mágico");
        jogador.MostrarInventario();


    }
}
