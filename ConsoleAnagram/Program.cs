using LibraryAnagram;

namespace ConsoleAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Anagram().Reverse(new string("   !")));
            Console.Write(new Anagram().Reverse(new string(" emosewa\n  !\t!")));
            Console.Write("1");
        }
    }
}