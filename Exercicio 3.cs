using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        double num = double.Parse(Console.ReadLine());

        double metade = num / 2.0;
        Console.WriteLine("A metade é: " + metade);
    }
}

