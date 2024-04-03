using System;
class HelloWorld
{
    static void Main()
    {
        double soma = 0;
        int quantidade = 0;
        int contador = 0;
        Console.WriteLine("Insira a quantidade de números: ");
        int quantidade_nums = int.Parse(Console.ReadLine());
        while (contador < quantidade_nums)
        {
            Console.WriteLine("Digite seus números: ");
            int nums_analisados = int.Parse(Console.ReadLine());
            if (nums_analisados % 2 == 0)
            {
                soma += nums_analisados;
                quantidade++;
            }
           contador++;
        }
        double media = soma / quantidade;
        Console.WriteLine("Sua média é: " + media);
    }
}