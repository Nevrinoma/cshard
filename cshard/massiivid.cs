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
