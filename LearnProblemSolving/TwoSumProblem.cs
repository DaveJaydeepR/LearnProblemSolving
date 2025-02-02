using System;
using System.Collections;
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

            Hashtable ht = new Hashtable();
            for(int i = 0; i < nums.Length; i++)
            {
                if (ht.ContainsKey(target - nums[i]))
                {
                    return new int[] { (int)ht[target - nums[i]], i };
                }
                else
                {
                    ht.Add(nums[i], i);
                }
            }
            return new int[] { };
        }
    }
}
