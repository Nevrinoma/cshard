using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshard
{
    class massiivid
    {
        static void Main(string[] args)
        {
            /*
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);

            }
            foreach (int item in numbers)
            {
                Console.Write(" {0,4} ", item);
            }
            Console.WriteLine();



            string[] names = new string[5] { "Anna", "Olga", "Mark", "Timur", "Jegor" };
            
            int a=0;
            do
            {
                foreach (string name in names)
                {
                    Console.Write(" {0,4} ", name);
                }
                Console.WriteLine();
                Console.WriteLine("What name u want to remove?");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                
            } while (a<1 || a>5);
            Console.WriteLine(names[a - 1]);
            */

            //task 1
            /*
            Random rnd = new Random();
            int N = rnd.Next(1, 33);
            int M = rnd.Next(1, 33);
            Console.WriteLine("N >>> {0} ", N);
            Console.WriteLine("M >>> {0} ", M);
            if (N>M)
            {
                int help = N;
                N = M;
                M = help;
            }
            int[] NM = new int[M - N + 1];

            for (int j = N; j < M + 1; j++)
            {
                NM[j-N] = j;
                Console.WriteLine(j*j);
            }
            */
            /*
            //task 2
            double[] numbers = new double[5];
            do
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[0] = Convert.ToDouble(Console.ReadLine());
                }
                double summ = 0;
                double proiz = 1;
                int item = numbers.Length;
                foreach (double itemm in numbers)
                {
                    summ += itemm;
                    proiz *= itemm;
                }
                
                
                Console.WriteLine("Summ >>> {0}",summ);
                Console.WriteLine("Sred >>> {0}", summ/item);
                Console.WriteLine("Proiz >>> {0}", proiz);

            } while (numbers.Length==5);


            */
            /*
            int tryes,otvet;
            tryes = 0;
            Random rnd = new Random();
            int number = rnd.Next(1,10);
            //Console.WriteLine(number);
            Console.WriteLine("ugadai 4islo ot 1 do 10");
            Console.WriteLine("u tebja 5 popitok");
            do
            {

                otvet = int.Parse(Console.ReadLine());
                if (otvet == number)
                {
                    Console.WriteLine("pravilno, ti molodec");
                    break;
                }
                else if (otvet<number)
                {
                    tryes++;
                    Console.WriteLine("zagadanoe 4islo bolshe {0} , ostalos "+(5-tryes)+" popitok", otvet);
                   
                }
                else if (otvet > number)
                {
                    tryes++;
                    Console.WriteLine("zagadanoe 4islo menshe {0} , ostalos " + (5 - tryes) + "  popitok", otvet);
                    
                }
            } while (tryes < 5);
            if (tryes==5)
            {
                Console.WriteLine("U vas kon4ilis popitki");
            }
            
            */

            /*
            Console.WriteLine("Введите 4 числа");
            int a, b, c, d, max;
            max = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            if ((a > b) && (a > c) && (a > d)) max = a;
            if ((b > a) && (b > c) && (b > d)) max = b;
            if ((c > a) && (c > b) && (c > d)) max = c;
            if ((d > a) && (d > b) && (d > c)) max = d;
            Console.WriteLine("Наибольшее число >>> {0}", max);
            */

            /*

            for (int i = 1; i < 11; i++)
            {
                for (int i2 = 1; i2 < 11; i2++)
                {
                    Console.Write("\t" + i * i2);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            */
            /*
            Console.WriteLine("1230");
            Console.WriteLine("\n"+"1230");
            Console.WriteLine("\t" + "1230");
            */

            ConsoleKeyInfo click;
            do
            {
                click = Console.ReadKey(true);
                Console.Beep();
            } while (click.Key != ConsoleKey.Escape);
            Environment.Exit(0);
        }


    }
}
