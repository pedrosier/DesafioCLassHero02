using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        if (idade < 12)
        {
            Console.WriteLine("Criança");
        }
        else if (idade >= 12 && idade <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else
        {
            Console.WriteLine("Adulto");
        }
    }
}