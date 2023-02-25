using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace LibraryAnagram
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class Anagram
    {
        string ReverseLiteralWord(string input)
        {
            char[] ans = input.ToCharArray();

            Array.Reverse(ans);

            return new string(ans);
        }

        string ReverseWord(string input)
        {
            string answer = new string("");

            Tuple<int, string>[] numIndexArr =
                new Tuple<int, string>[input.Count() - input.Count(Char.IsLetter)];

            int indexChar = 0;
            int indexArr = 0;

            foreach (Char c in input)
            {
                if (!char.IsLetter(c))
                {
                    char[] arr = { c };
                    string str = new string(arr);
                    numIndexArr[indexArr] = new Tuple<int, string>(indexChar, str);
                    indexArr++;
                }
                indexChar++;
            }

            answer = Regex.Replace(input, "[^a-zA-Z]", "");
            answer = ReverseLiteralWord(answer);

            foreach (Tuple<int, string> el in numIndexArr)
                answer = answer.Insert(el.Item1, el.Item2);

            return answer;
        }

        public string StringReverse(string input)
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
    }
}
