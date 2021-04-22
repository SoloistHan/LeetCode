using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class E_StrStr
    {
        public int StrStr(string haystack, string needle)
        {
            int i_Ans = 999;
            i_Ans = haystack.IndexOf(needle);
            if (needle == "")
                i_Ans = 0;
            return i_Ans;
        }
    }
}
