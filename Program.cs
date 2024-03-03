using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do aluno:");
        string nome = Console.ReadLine();

        double nota1, nota2, nota3;

        Console.WriteLine("Digite a nota do primeiro trimestre:");
        while (!double.TryParse(Console.ReadLine(), out nota1) || nota1 < 0 || nota1 > 100)
        {
            Console.WriteLine("Nota inválida. Digite novamente:");
        }

        Console.WriteLine("Digite a nota do segundo trimestre:");
        while (!double.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota2 > 100)
        {
            Console.WriteLine("Nota inválida. Digite novamente:");
        }

        Console.WriteLine("Digite a nota do terceiro trimestre:");
        while (!double.TryParse(Console.ReadLine(), out nota3) || nota3 < 0 || nota3 > 100)
        {
            Console.WriteLine("Nota inválida. Digite novamente:");
        }

        double notaFinal = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine($"Nome do aluno: {nome}");
        Console.WriteLine($"Nota final: {notaFinal}");

        if (notaFinal >= 60)
        {
            Console.WriteLine("Situação: Aprovado");
        }
        else
        {
            Console.WriteLine("Situação: REPROVADO");
            double pontosFaltantes = 60 - notaFinal;
            Console.WriteLine($"Pontos faltantes para aprovação: {pontosFaltantes}");
        }
    }
}

//Fazer um programa que calcule a media de 03 notas do aluno = String
//Solicitar ao usuario
//nome de um aluno = String
//três notas que ele obteve nos três trimestres do ano = double
//primeiro trimestre vale 30
//segundo e terceiro valem 35 cada
//Mostrar em tela nota final do aluno no ano.
//Informar se APROVADO ou REPROVADO 
//Se  reprovado mostra uma mensagem informando
//quantos pontos o aluno deveria obter para ser aprovado
//Considerar nota para aprovação 60 pontos = double
//Sem orientação a objetos
