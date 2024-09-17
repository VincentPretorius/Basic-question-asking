using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lesson_Strings
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Hi, Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your age: ");
            String age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " Are you lying about being " + age);
            String answer = Console.ReadLine();
             if (answer == "yes")
                Console.Write("We can forgive a honest liar"); 
             else
                    Console.WriteLine("We know you are lying, there will be consequences " + name); 
            



            Console.ReadLine();
        }
    }


    }