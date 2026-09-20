using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número (dividendo): ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número (divisor): ");
        double num2 = double.Parse(Console.ReadLine());

        double divisao = num1 / num2;
        Console.WriteLine("O resultado da divisão é: " + divisao);
    }
}

