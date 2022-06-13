using System;

namespace AulaUm
{
    class AulaUm
    {
        static void Main(String[] args)
        {
            //Primeira questão: Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.

            Console.WriteLine("PRIMEIRA QUESTÃO");
            Console.WriteLine("Coloque seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Coloque seu endereço:");
            string endereco = Console.ReadLine();

            Console.WriteLine("Coloque seu CEP:");
            string CEP = Console.ReadLine();

            Console.WriteLine("Coloque seu telefone:");
            string telefone = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("*** CADASTRO REALIZADO ***");
            Console.WriteLine($" Nome: {nome} \n Endereço: {endereco} \n CEP: {CEP} \n Telefone: {telefone}");
            Console.WriteLine("**************************");
            Console.WriteLine();

            //Segunda questão: Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome,
            //sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.
            Console.WriteLine("SEGUNDA QUESTÃO");

            string diva = "Hedy Lamarr";
            string formacao = "Atriz";
            string contribuiçao = "Foi responsável por diversas invenções, dentre elas o  Wi-Fi";

            Console.WriteLine($"**********{diva}*************** \nSua formação: {formacao} \nSua contribuição: {contribuiçao}");
            Console.WriteLine("********************************");


            //Terceira questão: Elabore um programa que mostre na tela uma letra de música que você gosta,
            //o compositor e o gênero musical em linhas separadas.
            Console.WriteLine("TERCEIRA QUESTÃO");

            string letra = "Eagle fly free/Let people see/Just make it your own way/Leave time behind/Follow the sign/" +
                "Together we'll fly someday";
            string compositor = "Michael Weikath";
            string genero = "Power Metal";

            Console.WriteLine();
            Console.WriteLine($"Música: {letra} \nCompositor: {compositor} \nGênero: {genero}");
            Console.WriteLine();

            Console.WriteLine("**************************");
            //Quarta questão: Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia.
            Console.WriteLine("QUARTA QUESTÃO");

            Console.WriteLine("Somente cerca de 30% do mercado de tecnologia é composto por mulhreres, essa realidade precisa" +
                "ser mudada urgentemente, então venha para o lado tech da força!");

        }
    }

}
