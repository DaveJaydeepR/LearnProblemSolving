using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProblemSolving
{
    internal class TwoSumProblem
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int arrLength = nums.Length;
            //Validation
            if (nums == null || arrLength < 2)
            {
                return Array.Empty<int>();
            }
            //Logic
            for (int i = 0; i < arrLength; i++)
            {
                for (int j = i + 1; j < arrLength; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }

            }

            return Array.Empty<int>();

        }
    }
}
