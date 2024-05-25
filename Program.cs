
class Program
{
    static void Main()
    {
        Random numeroAleatorio = new Random();
        int[] aposta = new int[15];
        int i = 0;

        while (i < 15)
        {
            int inteiro = numeroAleatorio.Next(1, 26);
            aposta[i] = inteiro;
            i++;
        }

        foreach (int num in aposta)
        {
            Console.WriteLine(num);
        }
    }
}