using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace LibraryAnagram
{
    public class IndexSymbol
    {
        public int index;
        public string symbol = new string("");
 
        public IndexSymbol(int index, string symbol)
        {
            this.index = index;
            this.symbol = symbol;
        }
    }
    public class Anagram
    {
        public string Reverse(string input)
        {
            string[] strArr = input.Split(" ");
            string answer = new string("");

            foreach (string str in strArr)
            {
                string tmp = ReverseWord(str);
                answer += tmp + " ";
            }

            return answer.Remove(answer.Length - 1);
        }
        string ReverseLiteralWord(string input)
        {
            char[] ans = input.ToCharArray();

            Array.Reverse(ans);

            return new string(ans);
        }

        string ReverseWord(string input)
        {
            string answer = new string("");

            IndexSymbol[] numIndexArr = new IndexSymbol[input.Count() - input.Count(Char.IsLetter)];

            int indexChar = 0;
            int indexArr = 0;

            foreach (Char c in input)
            {
                if (!char.IsLetter(c))
                {
                    char[] arr = { c };
                    string str = new string(arr);
                    numIndexArr[indexArr] = new IndexSymbol(indexChar, str);
                    indexArr++;
                }
                indexChar++;
            }

            answer = Regex.Replace(input, "[^a-zA-Zа-яА-Яїєі]", "");
            answer = ReverseLiteralWord(answer);

            foreach (IndexSymbol el in numIndexArr)
            {
                answer = answer.Insert(el.index, el.symbol);
            }

            return answer;
        }
    }
}
