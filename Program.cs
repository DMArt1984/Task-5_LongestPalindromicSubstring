using System;

namespace Task_5_LongestPalindromicSubstring
{
    class Program
    {
        // https://leetcode.com/problems/longest-palindromic-substring/
        static void Main(string[] args)
        {
            Console.WriteLine("Task-5 Longest Palindromic Substring");
            Console.WriteLine($"caba >>> {LongestPalindrome("caba")}");
            Console.WriteLine($"abb >>> {LongestPalindrome("abb")}");
            Console.WriteLine($"ab >>> {LongestPalindrome("ab")}");
            Console.WriteLine($"BOB >>> {LongestPalindrome("BOB")}");
            Console.WriteLine($"babad >>> {LongestPalindrome("babad")}");
            Console.WriteLine($"cbbd >>> {LongestPalindrome("cbbd")}");
            Console.ReadKey();
        }

        // Given a string s, return the longest palindromic substring in s.

        // Example 1:
        // Input: s = "babad"
        // Output: "bab"
        // Explanation: "aba" is also a valid answer.

        // Example 2:
        // Input: s = "cbbd"
        // Output: "bb"

        static public string LongestPalindrome(string s)
        {
            //Console.WriteLine($"===== {s} =====");
            //if (String.IsNullOrWhiteSpace(s))
            //    return "";
            
            // length
            var leng = s.Length;
            var fleng = -1;
            //if (s == Reverse(s))
            //    return s; // super!

            string retval = ""; // retval palindromic

            while (true) // find
            {
                fleng++;
                if (fleng == leng)
                    break;

                for (var i=0; i <= fleng; i++)
                {
                    if (s[i] != s[i + leng - fleng - 1]) // oh, next...
                        continue;
                    var item = s.Substring(i, leng - fleng);
                    //Console.WriteLine(item);
                    if (item == Reverse(item))
                        return item;
                }

            }
            
            return retval;
        }

        // reverse string
        static public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
