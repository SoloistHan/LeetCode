using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class E_RemoveDuplicates
    {
        public int RemoveDuplicates(int[] nums)
        {
            List<int> list_More = new List<int>();
            for (int standard = 0; standard < nums.Length; standard++)
            {
                for (int another = standard + 1; another < nums.Length; another++)
                {
                    if (nums[standard] == nums[another])
                    {
                        if (list_More.Count == 0)
                            list_More.Add(nums[another]);
                        else
                        {
                            for (int Main = 0; Main < list_More.Count; Main++)
                            {
                                if (!list_More.Contains(nums[another]))
                                    list_More.Add(nums[another]);
                            }
                        }
                    }
                } 
            }
            return list_More.Count;
        }
    }
}
