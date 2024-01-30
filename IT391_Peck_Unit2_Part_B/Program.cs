using System;
using System.Collections.Generic;


namespace IT391_Peck_Unit2_Part_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
       

            Console.WriteLine();
            Console.WriteLine("********Part B: Section 1 ********");
            Console.WriteLine();

            getBankingCustomers();

            Console.WriteLine();
            Console.WriteLine("********Part B: Section 2 ********");
            Console.WriteLine();

            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine(ReverseSentence(words));

            Console.ReadKey();
        }
        private static void getBankingCustomers()
        {
            Queue<String> customers = new Queue<String>();

            customers.Enqueue("Jim");
            customers.Enqueue("Bob");
            customers.Enqueue("Susan");
            customers.Enqueue("Liz");
            customers.Enqueue("Alex");

            Console.WriteLine("The number of customers at the bank when the bank opens is " + customers.Count);

            foreach (string customer in customers)
                Console.WriteLine(customer);

            Console.WriteLine("The first customer in line is " + customers.Peek());

            customers.Dequeue();

            customers.Enqueue("Andy");
            customers.Enqueue("Rhonda");

            for (int i = 1; i < 4; i++)
            {
                customers.Dequeue();
            }

            Console.WriteLine("There are now " + customers.Count + " customers in line.");

            Console.WriteLine(customers.Peek() + " is now at the head of the line.");

            Console.ReadKey();
        }
        private static string ReverseSentence(string[] str)
        {
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < str.Length; i++)
                stack.Push(str[i]);

            string reversed = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                reversed += stack.Pop();
                reversed += " ";
            }
            return reversed;
        }
    }
    }

