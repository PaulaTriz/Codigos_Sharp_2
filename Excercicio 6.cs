using System;

class Program
{
    static void Main(string[] agrs)
    {
        Console.Write("Digite um número: ");
        double num = double.Parse(Console.ReadLine());

        double raiz = Math.Sqrt(num);
        Console.WriteLine("A raiz quadrada é: " + raiz);
    }
}