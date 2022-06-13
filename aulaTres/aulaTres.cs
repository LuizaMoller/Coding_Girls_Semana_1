namespace AulaTres
{
    public class AulaTres
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 1) Leia um valor de ponto flutuante com duas casas decimais. " +
                "Este valor representa um valor monetário. A seguir, " +
                "calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. " +
                "As notas consideradas são de 100, 50, 20, 10, 5, 2.");

            Console.WriteLine("Insira um valor monetário:");
            decimal numInp = Convert.ToDecimal(Console.ReadLine());
            int num = Decimal.ToInt32(numInp);
            int notasCem = num / 100;
            int restoCem = num % 100;
            int notasCinq = restoCem / 50;
            int restoCinq = restoCem % 50;
            int notasVint = restoCinq / 20;
            int restoVint = restoCinq % 20;
            int notasDez = restoVint / 10;
            int restoDez = restoVint % 10;
            int notasCinc = restoDez / 5;
            int restoCinc = restoDez % 5;
            int notasDois = restoCinc / 2;
            Console.WriteLine($" NOTAS DE RS 100.00: {notasCem} \n NOTAS de RS 50.00: {notasCinq} " +
                $"\n NOTAS DE RS 20: {notasVint} \n NOTAS DE RS 10.00: {notasDez} \n NOTAS DE RS 5.00: {notasCinc} \n NOTAS DE RS 2.00: {notasDois}");
            Console.WriteLine();

            Console.WriteLine("Questão 2)  Faça um programa que leia três valores e apresente o maior dos três " +
                "valores lidos seguido da mensagem “x é o maior”.");
            Console.WriteLine("INSIRA O PRIMEIRO VALOR");
            int primeiroVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INSIRA O SEGUNDO VALOR");
            int segundoVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INSIRA O TERCEIRO VALOR");
            int terceiroVal = Convert.ToInt32(Console.ReadLine());

            if (primeiroVal > terceiroVal && primeiroVal > segundoVal)
            {
                Console.WriteLine($"{primeiroVal} é o maior");
            }
            else if (segundoVal > primeiroVal && segundoVal > terceiroVal)
            {
                Console.WriteLine($"{segundoVal} é o maior");
            }
            else if (terceiroVal > primeiroVal && terceiroVal > segundoVal)
            {
                Console.WriteLine($"RESULTADO: {terceiroVal} é o maior");
            }
            Console.WriteLine();

            Console.WriteLine("Questão 3) Leia 3 valores que são as três notas de um aluno. " +
                "A seguir, calcule a média do aluno. Considere que cada nota pode ir de 0 até 10.0, " +
                "sempre com uma casa decimal. Imprima se o aluno foi aprovado ou reprovado considerando a " +
                "média 7.");
            Console.WriteLine("INSIRA A PRIMEIRA NOTA");
            decimal primeiraNota = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("INSIRA A SEGUNDA NOTA");
            decimal segundaNota = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("INSIRA A TERCEIRA NOTA");
            decimal terceiraNota = Convert.ToDecimal(Console.ReadLine());
            decimal media = (primeiraNota + segundaNota + terceiraNota) / 3;
            if (media >= 7)
            {
                Console.WriteLine($"Estudante tirou: {media.ToString("c")} e foi aprovada.");
            }
            else if (media <= 7)
            {
                Console.WriteLine($"Estudante tirou: {media.ToString("c")} e foi reprovada.");
            }
            Console.WriteLine();

            Console.WriteLine("Questão 4) Leia 3 valores que são as três notas de um aluno. " +
                "A seguir, calcule a média do aluno."); //Realizei esta questão com base nos valores da questão 3.
            if (media < 6)
            {
                Console.WriteLine($"Estudante tirou F e precisa refazer o curso.");
            }
            else if (media >= 6 && media < 7)
            {
                Console.WriteLine($"Estudante tirou D e foi reprovada e precisa fazer segunda chamada.");
            }
            else if (media >= 7 && media < 8)
            {
                Console.WriteLine($"Estudante tirou C e foi aprovada sem resalvas.");
            }
            else if (media >= 8 && media < 9)
            {
                Console.WriteLine($"Estudante tirou B e foi aprovada com louvor.");
            }
            else if (media >= 9 && media <= 10)
            {
                Console.WriteLine($"Estudante tirou A e foi aprovada com o máximo louvor.");
            }
            Console.WriteLine();

            Console.WriteLine("Questão 5) A Blue resolveu dar um aumento de salários" +
                " a seus funcionários de acordo com os dados abaixo: Salário de 0 até 400.00 ganha 15% " +
                "Salário de 400.01 até 800.00 ganha 12% Salário de 800.01 até 1200.00 ganha 10% " +
                "Salário de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4%. " +
                "Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste " +
                "ganho e o índice reajustado, em percentual.");

            Console.WriteLine("INSIRA SEU SALÁRIO");
            Decimal salario = Convert.ToDecimal(Console.ReadLine());
            if (salario >= 0 && salario <= 400)
            {
                decimal quinzeporc = (salario * 15m) / 100m;
                decimal salarioNvo = salario + quinzeporc;
                Console.WriteLine($"NOVO SALARIO: {salarioNvo} \nREAJUSTE: {quinzeporc} \nEM PERCENTUAL: 15%");
            }
            else if (salario > 400 && salario <= 800)
            {
                decimal dozeporc = (salario * 12m) / 100m;
                decimal salarioNvo = salario + dozeporc;
                Console.WriteLine($"NOVO SALARIO: {salarioNvo} \nREAJUSTE: {dozeporc} \nEM PERCENTUAL: 12%");
            }
            else if (salario > 800 && salario <= 1200)
            {
                decimal dezporc = (salario * 10m) / 100m;
                decimal salarioNvo = salario + dezporc;
                Console.WriteLine($"NOVO SALARIO: {salarioNvo} \nREAJUSTE: {dezporc} \nEM PERCENTUAL: 10%");
            }
            else if (salario > 1200 && salario <= 2000)
            {
                decimal seteporc = (salario * 7m) / 100m;
                decimal salarioNvo = salario + seteporc;
                Console.WriteLine($"NOVO SALARIO: {salarioNvo} \nREAJUSTE: {seteporc} \nEM PERCENTUAL: 7%");
            }
            else if (salario < 1200)
            {
                decimal quatroporc = (salario * 4m) / 100m;
                decimal salarioNvo = salario + quatroporc;
                Console.WriteLine($"NOVO SALARIO: {salarioNvo} \nREAJUSTE: {quatroporc} \nEM PERCENTUAL: 4%");
            }
        }
    }
}

