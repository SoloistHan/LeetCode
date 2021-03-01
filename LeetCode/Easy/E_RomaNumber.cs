using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class E_RomaNumber
    {
        public int RomanToInt(string s)
        {
            int Bottom = RomanTrans(s.Substring(s.Length - 1, 1));
            if (s.Length > 1)
            {
                for (int single = 0; single < s.Length; single++)
                {
                    int Last = RomanTrans(s.Substring(s.Length - single - 1, 1));
                    int Next = RomanTrans(s.Substring(s.Length - single - 2, 1));
                    if (Next >= Last)
                        Bottom += Next;
                    else if (Next < Last)
                        Bottom -= Next;

                    if (s.Length - single == 2)
                        break;
                }
                return Bottom;
            }
            return Bottom;
        }

        private static int RomanTrans(string input)
        {
            if (input == "I")
                return 1;
            else if (input == "V")
                return 5;
            else if (input == "X")
                return 10;
            else if (input == "L")
                return 50;
            else if (input == "C")
                return 100;
            else if (input == "D")
                return 500;
            else if (input == "M")
                return 1000;

            return 0;
        }
    }
}
