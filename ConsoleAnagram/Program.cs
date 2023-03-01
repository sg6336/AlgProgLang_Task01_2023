﻿using LibraryAnagram;

namespace ConsoleAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.Greetings);
            ConsoleKeyInfo e;
            Anagram anagram = new Anagram();
 
            do
            {
                Console.WriteLine(Messages.Input);
 
                string input = Console.ReadLine();
 
                Console.WriteLine(Messages.Output + anagram.Reverse(input));
                Console.WriteLine(Messages.LoopInput);
                e = Console.ReadKey();
            } while (e.Key == ConsoleKey.Enter);
        }
    }
}