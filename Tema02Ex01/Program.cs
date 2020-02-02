using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema02Ex01
{
    class Program
    {
        static void Main(string[] args)
        { 
        
            //   ex 1

          int a = 3;                                                // a = 3  
          int b = (a = 2) * a;                                     // b = 2*2 = 4; a = 2
          int c = b * (b = 5);                                     // c = 4*5; b = 5
          Console.WriteLine("a =" + a + ", b =" + b + ", c =" + c);  // afiseaza a =2, b =5, c =20
          Console.ReadKey();

            //   ex 2

            double d = 2.95;
            int i = 4;
            Console.WriteLine(++d > i ? d : i); // d = 3.95; echivalent cu:  daca(d>i) afiseaza d, altfel afiseaza i; intrucat d<i, va afisa valoarea lui i, adica 4
            Console.ReadKey();

            //  ex 3

            int a1 = 3;
            if (++a1 < 4)                   // verifica conditia 4 < 4; gaseste false si nu executa urmatorul if si implicit else; nu va afisa nimic
                if (a1++ < 4)
                    Console.WriteLine(a1);
                else
                    Console.WriteLine(a1);

            Console.ReadKey();

            // ex 4

            int suma = 0;
            for (int j = 1; j < 10; j++)
            {
                suma = suma + j;                   // suma = 0+1+2+3+4+5+6+7+8+9 = 34
            }
            Console.WriteLine("Suma este: " +suma); // va afisa: Suma este: 45
            Console.ReadKey();

            // ex 5

            // Scrieti un program care sa returneze n! (adica n = 1 * 2 * 3 * … * n), unde n < 13 este un numar natural.

            int n = 13;
            int nFactorial = 1;
            for(int k = 1; k < n; k++)
            {
                nFactorial = nFactorial * k;
            }
            Console.WriteLine((n-1) + "! = " + nFactorial);
            Console.ReadKey();


            // ex 6

            // Scrieti un program care sa returneze minimum a trei numere intregi , folosind instructiunea if - else.

            Console.WriteLine("Urmatorul program afiseaza minimul a trei numere intregi cerute de la tastatura.");

            int x, y, z;
            int min;

            Console.Write("Introduceti primul numar: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti al treilea numar: ");
            z = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                if (x < z)
                {
                    min = x;
                }
                else
                {
                    min = z;
                }
            }
            else
            {
                if (y < z)
                {
                    min = y;
                }
                else
                {
                    min = z;
                }
            }
            Console.WriteLine("Minimul celor 3 numere introduse este: "+ min);
            Console.ReadKey();

            // ex 7

            // Determinati daca un numar este par sau impar.

            Console.WriteLine("Programul urmator afiseaza daca un numar cerut de la user este par sau impar.");

            int numar;

            Console.Write("Introduceti un numar: ");
            numar = Convert.ToInt32(Console.ReadLine());

            if (numar % 2 == 0)
            {
                Console.WriteLine("Numarul " + numar + " este par");
            } else
            {
                Console.WriteLine("Numarul " + numar + " este impar");
            }
            Console.ReadKey();



            // ex8

            // Folosind instructiunea switch scrieti un program care sa afiseze ziua saptamanii in functie de numarul acesteia.
            // De exemplu : ziua 1 este echivalenta zilei “Luni”, ziua 2 este “Marti” etc.

            Console.WriteLine("Programul urmator afiseaza o zi a saptamanii in functie de numarul introdus de utilizator.");

            int numar2;

            Console.Write("Introduceti un numar ce va reprezenta o zi a saptamanii: ");
            numar2 = Convert.ToInt32(Console.ReadLine());

            switch (numar2)
            {
                case 1:
                    Console.WriteLine("Luni");
                    break;
                case 2:
                    Console.WriteLine("Marti");
                    break;
                case 3:
                    Console.WriteLine("Miercuri");
                    break;
                case 4:
                    Console.WriteLine("joi");
                    break;
                case 5:
                    Console.WriteLine("Vineri");
                    break;
                case 6:
                    Console.WriteLine("Sambata");
                    break;
                case 7:
                    Console.WriteLine("Duminica");
                    break;


                default:
                    Console.WriteLine("Nu ati introdus un nr valid.");
                    break;

            }
            Console.ReadKey();
            }
        }
}
