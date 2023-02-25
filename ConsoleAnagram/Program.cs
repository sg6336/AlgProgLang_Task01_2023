using LibraryAnagram;

namespace ConsoleAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Anagram().StringReverse(new string("   !")));
            Console.Write(new Anagram().StringReverse(new string(" emosewa\n  !\t!")));
            Console.Write("1");
        }
    }
}