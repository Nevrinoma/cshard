using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshard
{
    public class alam_prog
    {
        public static int Korrutamine(int arv1, int arv2)
        {
            int kor = arv1 * arv2;
            return kor;
        }

        public static int[] arvud_mass(int n,bool t_f)
        {
            Random rnd = new Random();
            int[] masiv = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (t_f)
                {
                    Console.Write("Write number >>> ");
                    string input = Console.ReadLine();
                    int output;
                    if (int.TryParse(input, out output))
                    {
                        masiv[i] = output;
                    }
                    else
                    {
                        Console.WriteLine("Write only numbers !!");
                    }

                }
                else
                {
                    masiv[i] = rnd.Next(1, 100);
                }
            }
            return masiv;
        }

        public static void print_numbers(Array massiiv)
        {
            int k,max = 0;
            foreach (var item in massiiv)
            {
                k = item.ToString().Length;
                if (k>max)
                {
                    max = k;
                }
            }
            foreach (var item in massiiv)
            {
                int n = max + 1;
                Console.Write($"{item,4}");
            }

        }

        public static double keskN(int n)
        {
            double[] arvud = new double[n];
            double kesk = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vedite 5 4isel");
                arvud[i] = int.Parse(Console.ReadLine());
            }
            foreach (double item in arvud)
            {
                kesk = kesk + item;
            }
            kesk = Math.Round(kesk / n, 4);
            return kesk;

        }


        public static string cat(int t1,int t2,string tehe)
        { 
            double da;
            Console.WriteLine("Napishite pervoe celoe 4islo");
            t1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Napishite vtoroe celoe 4islo");
            t2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Napishite deistvie (+ - * /");
            tehe = Console.ReadLine();  
            Console.WriteLine(tehe);
            if (tehe=="+")
	        {
                da=(t1+t2);
                /*
                for (int i = 0; i < da; i++)
			    {
                    Console.WriteLine("nurr ");
			    }
                */
	        }
            else if (tehe=="-")
	        {
                if (t1<t2)
	            {
                    da=(t2-t1);
                    /*
                    for (int i = 0; i < da; i++)
			        {
                        Console.WriteLine("nurr ");
			        }
                    */
	            }
                else
	            {
                    da=(t1-t2);
                    /*
                    for (int i = 0; i < da; i++)
			        {
                        Console.WriteLine("nurr ");
			        }
                    */
	            }
	        }
            else if (tehe=="*")
	        {
                da=(t1*t2);
                /*
                for (int i = 0; i < da; i++)
			    {
                    Console.WriteLine("nurr ");
			    }
                */
	        }
            else if (tehe=="/")
	        {
                da=(t1/t2);
                Math.Round(da);
                /*
                for (int i = 0; i < da; i++)
			    {
                    Console.WriteLine("nurr ");
			    }
                */
	        }
            return da;
        }






    }
}
