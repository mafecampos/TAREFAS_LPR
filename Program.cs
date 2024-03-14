using System;
class HelloWorld
{
    static void Main()

    {
        Console.WriteLine("Insira seus dois números: ");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        if (num1 > num2)
        {
          if (num1 % num2==0) {
                Console.WriteLine("Seus números são múltiplos!");
            }
        }
        else
        {
            Console.WriteLine("Seus números não são múltiplos!");
        }
    }
}