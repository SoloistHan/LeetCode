using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class E_SearchInsert
    {
        public int SearchInsert(int[] nums, int target)
        {
            List<int> list_nums = nums.ToList<int>();
            if (list_nums.IndexOf(target) > 0)
                return list_nums.IndexOf(target);
            else
            {
                for (int FindMin = list_nums.Count - 1; FindMin >= 0; FindMin--)
                {
                    if (list_nums[FindMin] < target)                    
                        return (FindMin + 1);                    
                    else if (FindMin == 0)
                        return 0;
                }
                
                return list_nums.Count;
            }
        }
    }
}
