using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class E_LengthOfLastWord
    {
        static string Testing = "   fly me   to   the moon  ";
        public static int LengthOfLastWord(string s)
        {
            int ans = 0;
            string  last ;
            List<string> list_take = Testing.Split(' ').ToList();
            for(int first = 0; first < list_take.Count; first++)
            {                
                if (list_take[first]  != "")
                {
                    ans = list_take[first].Length;
                }
            }
            return ans;
        }
    }
}
