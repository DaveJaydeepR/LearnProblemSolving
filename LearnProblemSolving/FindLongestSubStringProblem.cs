using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProblemSolving
{
    internal class FindLongestSubStringProblem
    {
        public int LengthOfLongestSubstring(string s)
        {
            int[] dict = new int[256];
            Array.Fill(dict, -1);
            int maxLen = 0, start = -1;
            for (int i = 0; i < s.Length; i++)
            {
                start = Math.Max(start, dict[s[i]]);
                maxLen = Math.Max(maxLen, i - start);
                dict[s[i]] = i;
            }
            return maxLen;
        }
    }
}
