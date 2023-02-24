using LibraryAnagram;

namespace ConsoleAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Anagram().StringReverse(new string("   !")));
            Console.WriteLine(new Anagram().StringReverse(new string(" hello  !")));
        }
    }
}