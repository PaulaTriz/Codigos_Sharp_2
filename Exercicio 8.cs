using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        double num = double.Parse(Console.ReadLine());

        double valorAbsoluto = Math.Abs(num);
        Console.WriteLine("O valor absoluto é: " + valorAbsoluto);
    }
}
