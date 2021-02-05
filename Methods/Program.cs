//Author: Drake Ferry
//Date: 2/4/2021
//Class: ISM4300
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user to type in their name which will be used as the input 
            Console.WriteLine("Please enter your name");

            //Allows user to write their name which will be used as the input
            String Name = Console.ReadLine();

            //Output's users name with a greeting
            Console.WriteLine("Hello " + Name + "!");
        }
    }
}
