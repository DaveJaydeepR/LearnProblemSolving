using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProblemSolving
{
    public class LongestParentheses
    {
        public int LongestValidParentheses(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ')') continue;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[j] == ')')
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return count;
        }

    }
}
