using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double subtracao = num2 - num1;
        Console.Write("A subtração do segundo pelo primerio é: " + subtracao);
    }
}
