namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerreiro guerreiro = new Guerreiro("Guerreiro", 100, 20, 10);

            Mago mago = new Mago("Mago", 100, 15, 30);

            int turno = 1;

            while (guerreiro.EstaVivo() && mago.EstaVivo())
            {
                Console.WriteLine($"\n===== TURNO {turno} =====");

                guerreiro.Atacar(mago);

                if (mago.EstaVivo())
                {
                    mago.Atacar(guerreiro);
                }

                turno++;
            }

            Console.WriteLine("\n===== FIM DA BATALHA =====");

            if (guerreiro.EstaVivo())
            {
                Console.WriteLine($"O vencedor é {guerreiro.Nome}!");
            }
            else
            {
                Console.WriteLine($"O vencedor é {mago.Nome}!");
            }
        }
    }
}