
using GeradorDeApostas.Model;

class Program
{
    static void Main()
    {
        void ExibirMenu()
        {
            Console.WriteLine("Seja bem vindo ao gerador de apostas!\n");
            Console.WriteLine("Selecione em qual jogo irá apostar:\n");
            Console.WriteLine("1. Lotofácil.");
            Console.WriteLine("2. Outro jogo");
            Console.WriteLine("\n\nDigite o número do jogo escolhido: ");
            string JogoEscolhido = Console.ReadLine()!;
            int JogoEscolhidoInt = int.Parse(JogoEscolhido);

            switch (JogoEscolhidoInt)
            {
                case 0: 
                    Console.WriteLine("Opção inválida.");
                    break;
                case 1: 
                    Console.WriteLine("escolheu 1");
                    break;
            }
        }
        ExibirMenu();

    }
}