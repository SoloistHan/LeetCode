using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class E_PlusOne
    {
        // 20210915 It has to consider infinity size of array
        static int[] ar_nums = new int[] { 9,  9, 9, 9 };
        public static int[] PlusOne(int[] digits)
        {
            int[] ar_Test = digits;          
           
            for (int single = ar_Test.Count() - 1; single >= 0; single--)
            {
                if (ar_Test[single] + 1 == 10)
                {
                    ar_Test[single] = 0;
                    continue;
                }
                else
                {
                    ar_Test[single] += 1;
                    return ar_Test;
                }
            }

            int[] creat = new int[ar_Test.Length + 1];
            creat[0] = 1;
            creat.Append(0);
            return creat;
        }
    }
}
