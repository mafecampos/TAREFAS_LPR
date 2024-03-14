using System;
class HelloWorld
{
    static void Main()
    
    {
        Console.WriteLine("Insira seu número INTEIRO: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Seu número é Par!");
        }
        else
        {
            Console.WriteLine("Seu número é Impar!");
        }
    }
}
