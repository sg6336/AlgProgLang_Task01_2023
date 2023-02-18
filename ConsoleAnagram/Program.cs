using LibraryAnagram;

namespace ConsoleAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Anagram().Reverse(new string("input")));
        }
    }
}