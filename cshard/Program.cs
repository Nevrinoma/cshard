using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            


            /*
            Console.WriteLine("Temp?");
            double temp;
            temp = Convert.ToDouble(Console.ReadLine());
            if (temp < 20)
            {
                Console.WriteLine("It is really cold here.");
            }
            else if (temp > 28)
            {
                Console.WriteLine("Here is to warm.");
            }
            else
            {
                Console.WriteLine("I feel good");
            }
            
            */
            
            
            
            
            /*
            Console.WriteLine("What is your height?");
            double height;
            height = Convert.ToDouble(Console.ReadLine());
            if (height <= 155 && height >= 80)
            {
                Console.WriteLine("You are small!");
            }
            else if (height >=156 && height <=185 )
            {
                Console.WriteLine("You are medium high!");
            }
            else if (height >= 186 && height <= 230)
            {
                Console.WriteLine("You are high!");
            }
            else
            {
                Console.WriteLine("You are ugly monster! ;3 ;3 ;3 ;3 ;3 ;3 ;3 ;3 ;3 ;3");
            }
            */
            

            /*
            
            Console.WriteLine("What is your sex?");
            string sex;
            double height;
            sex = Console.ReadLine();
            if (sex.ToLower() == "w" || sex.ToLower() == "woman" || sex.ToLower() == "dishwasher")
            {
                Console.WriteLine("What is your height?");
                height = Convert.ToDouble(Console.ReadLine());
                if (height <= 150 && height >= 140)
                {
                    Console.WriteLine("You are small!");
                }
                else if (height >= 150 && height <= 175)
                {
                    Console.WriteLine("You are medium high!");
                }
                else if (height >= 176 && height <= 210)
                {
                    Console.WriteLine("You are high!");
                }
                else
                {
                    Console.WriteLine("You are ugly monster! ;3 ;3 ;3 ;3 ;3 ;3 ;3 ;3 ;3 ;3");
                }
            }
            else if (sex.ToLower() == "male" || sex.ToLower() == "man" || sex.ToLower() == "soldier")
            {
                Console.WriteLine("What is your height");
                height = Convert.ToDouble(Console.ReadLine());
                if (height <= 155 && height >= 100)
                {
                    Console.WriteLine("You are small!");
                }
                else if (height >= 156 && height <= 185)
                {
                    Console.WriteLine("You are medium high!");
                }
                else if (height >= 186 && height <= 230)
                {
                    Console.WriteLine("You are high!");
                }
                else
                {
                    Console.WriteLine("You are ugly monster! ;3 ;3 ;3 ;3 ;3 ;3 ;3 ;3 ;3 ;3");
                }
            }
            else
            {
                Console.WriteLine("There is only 2 gender =)");
            }


            */








            /*
            Console.WriteLine("Sale price is >>> ");
            double price1, price2; 
            price1 = Convert.ToDouble(Console.ReadLine());
            price2 = price1 * 100 / 70;
            Console.WriteLine("Original price: {0}",price2);


            */











            /*

            Console.WriteLine("Hello, what is the floor width!");
            double a,b,sqr,price,price2;
            string yeno;
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Room width is {0}", a);
            Console.WriteLine("What is the floor height!");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Room height is {0} and width is {1}", b,a);
            sqr = a * b;
            Console.WriteLine("Do you want to do floor repairs?");
            yeno = Console.ReadLine();
            if (yeno.ToLower() == "yes" || yeno.ToLower() == "yeah" || yeno.ToLower() == "yep")
            {
                Console.WriteLine("Enter price for sqr m here >>> ");
                price = Convert.ToDouble(Console.ReadLine());
                price2 = sqr * price;
                Console.WriteLine("You need {0} $ for all.", price2);


            }
            else
            {
                Console.WriteLine("Okay!");
            }
            
            
            */












            /* deskmates
            double price = 20;
            string t_type = "";

            Console.WriteLine("Hello, i am Hatsune Miku! What is your name?");
            Console.Title="Title";
            string name = Console.ReadLine();
            char[] abc = name.ToCharArray(); // marco -> ["m","a","r","c","o"]
            int i = 0;
            name = "";
            foreach ( var t in abc)
            {
                if (i==0)
                {
                    name += t.ToString().ToUpper();
                }
                else
                {
                    name += t.ToString().ToLower();
                }
                i++;
            }

            Console.WriteLine("Nice to meet you {0} ! What is your friend name?", name);
            string name2 = Console.ReadLine();
            char[] abc2 = name2.ToCharArray(); // marco -> ["m","a","r","c","o"]
            int i2 = 0;
            name2 = "";
            foreach (var t in abc2)
            {
                if (i2 == 0)
                {
                    name2 += t.ToString().ToUpper();
                }
                else
                {
                    name2 += t.ToString().ToLower();
                }
                i2++;
            }

            Console.WriteLine("Nice to meet you {0} !", name2);

            if ((name == "Marco" && name2 == "Mihhail") || (name2 == "Marco" && name == "Mihhail") ||
                (name == "Marco" && name2 == "Edgar") || (name2 == "Marco" && name == "Edgar") ||

                (name == "Danik" && name2 == "Aleksandr") || (name2 == "Danik" && name == "Aleksandr") ||
                (name == "Aleksandr" && name2 == "Aleksandr") ||

                (name == "Jelena" && name2 == "Alina") || (name2 == "Jelena" && name == "Alina") ||


                (name == "Mark" && name2 == "None") || (name2 == "Mark" && name == "None") ||


                (name == "Vlademir" && name2 == "Ervin") || (name2 == "Vlademir" && name == "Ervin"))
            {
                Console.WriteLine(" You are deskmates! oWo");
            }
            else
            {
                Console.WriteLine("Get away from our class!");
            }

            */





            /*  cinema

            Console.WriteLine("Nice to meet you {0} !", name);
            if (name.ToUpper() == "JUKU" || name.ToLower() == "marco" || name.ToLower() == "mihhail" || name.ToLower() == "mihail")
            {
                Console.WriteLine("Come in,{0} !",name);
                Console.WriteLine("Maybe go to the cinema?");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes" || answer.ToLower() == "yeah" || answer.ToLower() == "yep") 
                {
                    Console.WriteLine("How old are you ? {0}.", name);
                    int age = int.Parse(Console.ReadLine());
                    if (age <= 0 || age > 110)
                    {
                        Console.WriteLine("Go back to hell, demon");
                    }
                    else if (age == 0 && age < 10)
                    {
                        price -= price;
                        t_type = "under 10 years old ticket";
                    }
                    else if (age >= 10 && age <= 18)
                    {
                        price -= price* 0.75;
                        t_type = "young ticket";
                    }
                    else if (age >= 19 && age <= 60)
                    {
                        price = price ;
                        t_type = "normal ticket";
                    }
                    else if (age >= 61 && age <= 110)
                    {
                        price -= price * 0.5;
                        t_type = "starper ticket";
                    }
                    Console.WriteLine("{0}Take {1} $ with you for {2}!", name, price,t_type);

                }
                else
                {
                    Console.WriteLine("U are BTS fan.... euwww...");
                }

            }
            else
            {
                Console.WriteLine("Not today, {0}...",name);
            }
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