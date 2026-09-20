using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        double num = double.Parse(Console.ReadLine());

        double quadrado = Math.Pow(num, 2);
        Console.WriteLine("O quadrado é: " + quadrado);
    }
}