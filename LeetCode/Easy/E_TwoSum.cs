using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class E_TwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ar_Ans = new int[2];
            for (int i_Set = 0; i_Set < nums.Length; i_Set++)
            {
                for (int i_Next = i_Set + 1; i_Next < nums.Length; i_Next++)
                {
                    if (nums[i_Set] + nums[i_Next] == target)
                    {
                        ar_Ans[0] = i_Set;
                        ar_Ans[1] = i_Next;
                        return ar_Ans;
                    }
                }
            }
            return ar_Ans;
        }
    }
}
