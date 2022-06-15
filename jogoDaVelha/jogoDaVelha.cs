using System;
using System.Linq;

public class aulaQuatro
{
    public static char[,] tabuleiro = new char[,]
       {
            { '1', '2', '3'},{'4', '5', '6'},{'7', '8', '9'}
       };

    public static void Jogo()
    {
        Console.WriteLine($"  {tabuleiro[0, 0]}  |  {tabuleiro[0, 1]}  |  {tabuleiro[0, 2]} " +
        $"\n---------------\n  {tabuleiro[1, 0]}  |  {tabuleiro[1, 1]}  |  {tabuleiro[1, 2]} " +
        $"\n---------------\n  {tabuleiro[2, 0]}  |  {tabuleiro[2, 1]}  |  {tabuleiro[2, 2]} \n");
    }

    public static char turno = 'X';
    public static void Main(string[] args)
    {
        Console.WriteLine("Questão 5) Crie um algorítimo que possibilite que duas pessoas joguem o jogo da velha e " +
            "exiba quem foi o vencedor.");
        
        Jogo();
        int tentativas = 0;
        int jogadas = 9;
        while (jogadas < 10)
        {
            Console.WriteLine($"Insira o lugar de {turno} no tabuleiro: ");
            char lugar = char.Parse(Console.ReadLine());

            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {

                    if (tabuleiro[i, j] == lugar)
                    {
                        tabuleiro[i, j] = turno;
                        Jogo();
                        tentativas++;
                    }
                }
            }
            if (tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 1] == tabuleiro[0, 2] ||
                    tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[1, 2] ||
                    tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 1] == tabuleiro[2, 2])
            {
                Console.WriteLine($" QUEM JOGOU COM '{turno}' VENCEU!!!!");
                break;
            }
            else if (tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[1, 0] == tabuleiro[2, 0] ||
                    tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 1] ||
                    tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[1, 2] == tabuleiro[2, 2])
            {
                Console.WriteLine($" QUEM JOGOU COM '{turno}' VENCEU!!!!");
                break;
            }
            else if (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2] ||
                    tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
            {
                Console.WriteLine($"QUEM JOGOU COM '{turno}' VENCEU!!!!");
                break;
            }
            else if (tentativas == 9)
            {
                Console.WriteLine($"DEU VELHA!!! NINGUÉM VENCEU!!!!");
                break;
            }

            if (turno == 'X')
            {
                turno = 'O';
            }
            else
            {
                turno = 'X';
            }
        }
    }
}
    

