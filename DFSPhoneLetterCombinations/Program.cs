using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSPhoneLetterCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] digits = new[] { '2', '3' };
            var letters = new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            Dictionary<Char, Char[]> lettersMap = new Dictionary<Char, char[]>();
            lettersMap.Add('1', null);
            lettersMap.Add('2', new[] { 'a', 'b', 'c' });
            lettersMap.Add('3', new[] { 'd', 'e', 'f' });
            lettersMap.Add('4', new[] { 'g', 'h', 'i' });
            lettersMap.Add('5', new[] { 'j', 'k', 'l' });
            lettersMap.Add('6', new[] { 'm', 'n', 'o' });
            lettersMap.Add('7', new[] { 'p', 'q', 'r', 's' });
            lettersMap.Add('8', new[] { 't', 'u', 'v' });
            lettersMap.Add('9', new[] { 'w', 'x', 'y', 'z' });
            lettersMap.Add('0', null);
            StringBuilder sb = new StringBuilder();
            List<String> result = new List<String>();
            int pos = 0;
            LetterCombinationsFunction(digits, sb, lettersMap, result, pos);
            foreach (String r in result)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
        private static List<String> LetterCombinationsFunction(Char[] digits, StringBuilder sb,
                    Dictionary<Char, Char[]> lettersMap, List<String> result, int pos)
        { 
            if (sb.Length == digits.Count())
            {
                result.Add(sb.ToString());
                return result;
            }
            lettersMap.TryGetValue(digits[pos], out char[] values);        
                foreach (var v in values)
                {  
                    sb.Append(v);
                    LetterCombinationsFunction(digits, sb, lettersMap, result, pos+1);
                    sb.Remove(sb.Length - 1, 1);
                }      
            return result;
        }
    }
}
