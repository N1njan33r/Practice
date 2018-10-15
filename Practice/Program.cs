using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public enum ejercicio
    {
        Sixteen,
        Seventeen
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "*";
            ////string b = a;
            //string c = "         ";
            ////string d = " ";
            //for(int i = 0; i < 10; i++)
            //{
            //    //===Exercise 16===
            //    //Console.WriteLine(a);
            //    //a += "*";

            //    //===Exercise 17===
            //    Console.WriteLine(c + a + c);
            //    a = "*" + a + "*";
            //    if (c != "")
            //    {
            //        c = c.Remove(0, 1);
            //    }
            //}

            while (true)
            {
                Console.Write("Enter numerical grade: ");
                int number;
                string strNumber;
                strNumber = Console.ReadLine();
                if (int.TryParse(strNumber, out number))
                {
                    string letter;
                    if (number >= 90)
                    {
                        Console.WriteLine("Letter grade: A");
                    }
                    else if (number >= 80)
                    {
                        Console.WriteLine("Letter grade: B");
                    }
                    else if (number >= 70)
                    {
                        Console.WriteLine("Letter grade: C");
                    }
                    else if (number >= 60)
                    {
                        Console.WriteLine("Letter grade: D");
                    }
                    else if (number < 60)
                    {
                        Console.WriteLine("Letter grade: F");
                    }
                }
                else if (strNumber == "exit")
                {
                    Console.WriteLine("Application will now close. Press any key to exit.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"'{strNumber}' is not a valid input.");
                    continue;
                }

                Console.ReadKey();
            }
        }
    }
}
