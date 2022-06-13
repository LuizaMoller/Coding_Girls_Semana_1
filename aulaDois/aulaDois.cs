using System;
using System.Globalization;

namespace AulaDois
{
    public class AulaDois
    {
        static void Main(string[] args)
        {

            //Questão 1: Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade

            Console.WriteLine("QUESTÃO 1)");
            Console.WriteLine("Coloque o ano de seu nascimento:");
            int nascimento = Convert.ToInt32(Console.ReadLine());
            int anos = 2022 - nascimento;
            Console.WriteLine($"Sua idade é: {anos} anos");
            Console.WriteLine();

            //Questão 2: Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.

            int[] numeros = new int[10];
            int soma = 0;

            Console.WriteLine("QUESTÃO 2)");
            Console.WriteLine("Insira seus dez números: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                soma += num;
            }

            Console.WriteLine("A soma dos números é:" + soma);
            Console.WriteLine();

            //Questão 3: Escreva um programa que leia o número de horas trabalhadas e um funcionário,
            //o valor que recebe por hora e calcula o salário desse funcionário.
            //A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

            Console.WriteLine("QUESTÃO 3)");

            Console.WriteLine("Insira seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira suas horas de hoje:");
            int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            decimal valorPorhora = 80.50m * horasTrabalhadas;

            Console.WriteLine();
            Console.WriteLine("****** CALCULADORA DE SALÁRIO *******");
            Console.WriteLine($"FUNCIONÁRIO: {nome} \nHORAS TRABALHADAS POR DIA: {horasTrabalhadas}h " +
                $"\nVALOR A RECEBER: {valorPorhora.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} reais");
            Console.WriteLine("***********************************");
            Console.WriteLine();

            //Questão 4: Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos,
            //meses e dias.

            Console.WriteLine("QUESTÃO 4)");
            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            int idadeMeses = idade * 12;
            int idadeDias = idadeMeses * 365;

            Console.WriteLine($"Sua idade em anos é: {idade}");
            Console.WriteLine($"Sua idade em meses é: {idadeMeses}");
            Console.WriteLine($"Sua idade em dias é: {idadeDias}");
            Console.WriteLine();

            //Questão 5: Construa um conversor de moedas.

            Console.WriteLine("QUESTÃO 5)");

            Console.WriteLine("Insira um valor em reais: ");
            decimal valorReais = Convert.ToDecimal(Console.ReadLine());
            decimal valorDolar = valorReais * 4.87m;
            decimal valorEuro = valorReais * 5.21m;
            decimal valorLibra = valorReais * 6.13m;
            decimal valorDolcana = valorReais * 3.89m;
            decimal valorPesoar = valorReais * 0.04m;
            decimal valorPesoch = valorReais * 0.0059m;

            Console.WriteLine("********** CONVERSOR *********");
            Console.WriteLine($"VALOR EM DÓLAR: {valorDolar.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
            Console.WriteLine($"VALOR EM EURO: {valorEuro.ToString("C", CultureInfo.GetCultureInfo("en-DE"))}");
            Console.WriteLine($"VALOR EM LIBRA: {valorLibra.ToString("C", CultureInfo.GetCultureInfo("en-GB"))}");
            Console.WriteLine($"VALOR EM DÓLAR CANADENSE: {valorDolcana.ToString("C", CultureInfo.GetCultureInfo("en-CA"))}");
            Console.WriteLine($"VALOR EM PESO ARGENTINO: {valorPesoar.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
            Console.WriteLine($"VALOR EM PESO CHILENO: {valorPesoch.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
            Console.WriteLine("******************************");


        }

    }
}


