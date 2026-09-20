using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double multiplicacao = num1 * num2;
        Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);
    }
}
