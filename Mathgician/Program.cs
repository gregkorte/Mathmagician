﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathgician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I AM THE MATHMAGICIAN");
            Console.WriteLine("What shall I MATH?\n Fibonacci, Primes, OrderedParallelQuery Integers");
            string desiredMaths = Console.ReadLine();
            Console.WriteLine("Ok, I'm going to do some " + desiredMaths + "!");
            if ("Integers" == desiredMaths){
                PrintIntegers();
            } 
            else if("Fibonacci" == desiredMaths){
                PrintFibonacciSequence();
            }
            else
            {
            Console.WriteLine("Well, actually... I lied...");
                }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void PrintFibonacciSequence()
        {
            //1, 3, 5, 8, 13
            int previous = 0;
            int current = 1;
            while(true)
        {
            Console.WriteLine(current);
            System.Threading.Thread.Sleep(100);
            int newValue = previous + current;
            previous = current;
            current = newValue;
        }
    }

        private static void PrintIntegers()
        {
            int nextInteger = 0;
            while(true)
            {
                nextInteger++;
                Console.WriteLine(nextInteger);
            }
        }
    }
}
