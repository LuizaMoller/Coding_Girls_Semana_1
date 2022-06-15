using System;
using System.Linq;

public class aulaQuatro
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Questão 1) Crie um programa que solicite a entrada de 10 números pelo usuário, " +
            "armazenando-os em um vetor, e então monte outro vetor com os valores do primeiro multiplicados por 5.");

        int[] numUser = new int[10];
        int[] numMulti = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"INSIRA UM VALOR PARA A POSIÇÃO NUMERO {i} DO VETOR");
            numUser[i] = Convert.ToInt32(Console.ReadLine());
            numMulti[i] = numUser[i] * 5;
        }

        Console.WriteLine("**********************************************");
        Console.Write("VALORES DIGITADOS: ");
        foreach (int i in numUser)
        {
            Console.Write($"{i}. ");
        }
        Console.WriteLine();
        Console.Write("VALORES MULTIPLICADOS: ");
        foreach (int i in numMulti)
        {
            Console.Write($"{i}. ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("Questão 2) Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: " +
            "um somente para números pares, e outro somente para números ímpares. Após, exiba os valores dos dois vetores " +
            "na tela, um vetor em cada linha."); //Foram utilizadas Listas para variar a saída dos dados de acordo com a entrada. 
        Console.WriteLine("\n");

        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine($"Insira o valor de numero {x} para verificação: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares.Add(num);
            }
            else if (num % 2 != 0)
            {
                impares.Add(num);
            }
        }
        Console.WriteLine("**********************************************");

        Console.Write("NÚMEROS PARES: ");
        foreach (int i in pares)
        {
            Console.Write(i + ". ");
        }
        Console.WriteLine();
        Console.Write("NÚMEROS IMPARES: ");
        foreach (int i in impares)
        {
            Console.Write(i + ". ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("Questão 3) Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu tamanho. " +
            "Se o tamanho das strings for igual, deve-se manter a ordem inserida pelo usuário.");

        Console.WriteLine("ESCREVA A PRIMERIRA PALAVRA");
        string a = Console.ReadLine();
        Console.WriteLine("ESCREVA A SEGUNDA PALAVRA");
        string b = Console.ReadLine();
        Console.WriteLine("ESCREVA A TERCEIRA PALAVRA");
        string c = Console.ReadLine();
        Console.WriteLine("ESCREVA A QUARTA PALAVRA");
        string d = Console.ReadLine();
        Console.WriteLine("ESCREVA A QUINTA PALAVRA");
        string e = Console.ReadLine();
        string[] nomes = new string[5]
        {
            a, b, c, d, e
        };

        string palavrasOrde = Array.Sort(nomes, (x, y) => x.Length.CompareTo(y.Length));

        Console.WriteLine($"Palavras ordem: {string.Join(" ", palavrasOrde)} \n");

        Console.WriteLine("Questão 4) Utilizando os conceitos aprendidos até estruturas de repetição, " +
            "crie um programa que jogue pedra, papel e tesoura (Jokenpô) com você.");

        int user = 0;
        int pc = 0;
        string comeco = "1";
        while (comeco == "1")
        {
            Console.WriteLine("QUANTAS RODADAS VAMOS JOGAR?");
            int rodadas = int.Parse(Console.ReadLine());
            int[] rodada = new int[rodadas];
            foreach (int i in rodada)
            {
                Console.WriteLine("ESCOLHA: [0]PEDRA  [1]PAPEL  [2]TESOURA");
                int userJogada = int.Parse(Console.ReadLine());
                Random random = new Random();
                int pcJogada = random.Next(0, 2);
                if (userJogada > 2 || userJogada < 0)
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA. O COMPUTADOR VAI PONTUAR. PRESTE ATENÇÃO!");
                    pc += 1;
                }
                if (pcJogada == 0 && userJogada == 0)
                {
                    Console.WriteLine($"O COMPUTADOR JOGOU PEDRA E VOCÊ TAMBÉM: EMPATOU!");
                }
                if (pcJogada == 0 && userJogada == 1)
                {
                    Console.WriteLine($"O COMPUTADOR JOGOU PEDRA E VOCÊ JOGOU PAPEL: PONTO PARA VOCÊ!");
                    user += 1;
                }
                if (pcJogada == 0 && userJogada == 2)
                {
                    Console.WriteLine($"O COMPUTADOR JOGOU PEDRA E VOCÊ JOGOU TESOURA: PONTO PARA O COMPUTADOR!");
                    pc += 1;
                }
                if (pcJogada == 1 && userJogada == 0)
                {
                    Console.WriteLine($"O COMPUTADOR JOGOU PAPEL E VOCÊ JOGOU PEDRA: PONTO PARA O COMPUTADOR!");
                    pc += 1;
                }
                if (pcJogada == 1 && userJogada == 1)
                {
                    Console.WriteLine($"O COMPUTADOR JOGOU PAPEL E VOCÊ TAMBÉM: EMPATOU!");
                }
                if (pcJogada == 1 && userJogada == 2)
                {
                    Console.WriteLine($"O COMPUTADOR JOGOU PAPEL E VOCÊ JOGOU TESORA: PONTO PARA VOCÊ!");
                    user += 1;
                }
                if (pcJogada == 2 && userJogada == 0)
                {
                    Console.WriteLine($"O COMPUTADOR JOGOU TESOURA E VOCÊ JOGOU PEDRA: PONTO PARA VOCÊ!");
                    user += 1;
                }
                if (pcJogada == 2 && userJogada == 1)
                {
                    Console.WriteLine($"O COMPUTADOR JOGOU TESOURA E VOCÊ JOGOU PAPEL: PONTO PARA O COMPUTADOR!");
                    pc += 1;
                }
                if (pcJogada == 2 && userJogada == 2)
                {
                    Console.WriteLine($"O COMPUTADOR JOGOU TESOURA E VOCÊ TAMBÉM: EMPATOU!");
                }

            }

            Console.WriteLine("DESEJA JOGAR NOVAMENTE: [1]SIM  [2]NÃO");
            comeco = Console.ReadLine();
        }

        Console.WriteLine("**********************************************");

        Console.WriteLine($"VOCÊ GANHOU: {user} RODADAS \nO COMPUTADOR GANHOU: {pc} RODADAS.");
        if (user > pc)
        {
            Console.WriteLine("PARABÉNS, VOCÊ FOI O GRANDE CAMPEÃO!!!!!!!!");
        }
        else
        {
            Console.WriteLine("O COMPUTADOR FOI O GRANDE CAMPEÃO!!!!!!!!");
        }


    }

}

