using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class M_CanJump
    {
        public static bool CanJump(int[] nums)
        {
            int Left = 0;
            int Now = 0;
            
            while (Now <= nums.Length)
            {
                //Now = nums[0];
                //if (Now >= nums.Length)
                //    return false;
                Now++;
            }
            

            return true;
        }
    }
}
