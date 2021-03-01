using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class E_Brackets
    {
        public static bool IsValid(string s)
        {
            string small_L = "(";
            string small_R = ")";
            string Medium_L = "[";
            string Medium_R = "]";
            string Large_L = "{";
            string Large_R = "}";

            int small_iL = 0, Medium_iL = 0, Large_iL = 0, small_iR = 0, Medium_iR = 0, Large_iR = 0;
            for (int each = 0; each < s.Length; each++)
            {
                string str_Now = s.Substring(each, 1);
                if (str_Now == small_L)
                    small_iL++;
                else if (str_Now == small_R)
                    small_iR++;
                else if (str_Now == Medium_L)
                    Medium_iL++;
                else if (str_Now == Medium_R)
                    Medium_iR++;
                else if (str_Now == Large_L)
                    Large_iL++;
                else if (str_Now == Large_R)
                    Large_iR++;

                if ((small_iL == 0 && str_Now == small_R) ||
                    (Medium_iL == 0 && str_Now == Medium_R) || 
                    (Large_iL == 0 && str_Now == Large_R))
                {
                    return false;
                }                
            }

            if (small_iL == small_iR && Medium_iL == Medium_iR && Large_iL == Large_iR)
                return true;
            else
                return false;
        }
    }
}
