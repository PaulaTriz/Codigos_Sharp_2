using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        int resto = num % 2;
        Console.WriteLine("O resto da divisão por 2 é: " + resto);
    }
}
