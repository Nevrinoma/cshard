using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshard
{
    class alamprogmass
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine(alam_prog.keskN(5));
            Console.WriteLine(alam_prog.cat(da));
            for (int i = 0; i < da; i++)
			{
                    Console.WriteLine("nurr ");
			}
            










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
