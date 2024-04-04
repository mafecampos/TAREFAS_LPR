using System;
class HelloWorld
{
    static void Main()
    {
        int contador1 = 0;
        Console.WriteLine("Certo dia, cansado de ser capacho do Dicky Vigarista, Muttley decide o mandar para um asilo.\nMuttley liga para diversos asilos de Malucos e pombos, sua cidade, até que o mesmo enconta a perfeita!\nComo nosso querido cão do sorrisinho frouxo irá levar o desastrado Dicky?\n");
        while (true)
        {
            Console.WriteLine("Escolha de qual maneira leva-lo:\n1-Deixe ele dormir e o sequestre\n2-Ponha sonifero em sua comida e o leve\n3-Dizer que Penelope o convidou para sair e o leve\n");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Muttley não conseguiu, Dicky acordou!");
                    break;
                case 2:
                    Console.WriteLine("Muttley não conseguiu, Dicky percebeu!");
                    break;
                case 3:
                    Console.WriteLine("Muttley conseguiu!");
                    break;
            }
                    do
                    {
                        Console.WriteLine("Agora Dicky está bravo com Muttley, você precisa fazer com que o Vigarista o perdoe\n1-Entregar flores para Dicky\n2-Levar bomboms para Dicky\n3-Entregar um pombo de pelúcia\n4-Ligar para Penelope\n");
                        double escolha = double.Parse(Console.ReadLine());
                        for (int i = 1; i < 2; i++) ;
                        {
                            if(escolha == 1)
                            Console.WriteLine("Dicky é alérgico, além de bravo agora ele esta doente!");
                            else if (escolha == 2)
                            {
                                Console.WriteLine("Dicky é intolerante a lactose, além de bravo agora ele está com caganeira!");
                            }
                            else if (escolha == 3)
                            {
                                Console.WriteLine("Dicky não expressou, mas achou fofo. Ele te perdoou!");
                            }
                            else
                            {
                                Console.WriteLine("Dicky gostou, mas lembrou que Muttley o levou para o asilo assim. Ele não te perdoou e agora está triste!");
                            }
                        }
                        contador1++;
                    } while ( contador1 == 3);
        }
        }
    } 

