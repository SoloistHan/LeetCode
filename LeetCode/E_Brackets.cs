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
            if (s.Length > 1 && (s.Substring(0, 1) == "{" || s.Substring(0, 1) == "[" || s.Substring(0, 1) == "("))
            {
                for (int CutWord = 0; CutWord < s.Length; CutWord++)
                {
                    string RRE = s.Substring(CutWord, 1);

                    if (s.Substring(CutWord, 1) != "}" && s.Substring(CutWord, 1) != "]" && s.Substring(CutWord, 1) != ")")
                    {
                        if (s.Substring(CutWord, 1) == "{")
                        {
                            if (s.Substring(s.Length - (CutWord + 1), 1) != "}" && s.Substring(CutWord + 1, 1) != "}")
                                return false;
                            if (s.Substring(s.Length - (CutWord + 1), 1) == "}" && CutWord >= s.Length / 2)
                                break;
                            if (s.Substring(CutWord + 1, 1) == "}")
                                CutWord++;                            
                        }
                        else if (s.Substring(CutWord, 1) == "[")
                        {
                            if (s.Substring(s.Length - (CutWord + 1), 1) != "]" && s.Substring(CutWord + 1, 1) != "]")
                                return false;
                            if (s.Substring(s.Length - (CutWord + 1), 1) == "]" && CutWord >= (s.Length / 2) - 1)
                                break;
                            if (s.Substring(CutWord + 1, 1) == "]")
                                CutWord++;                            
                        }
                        else if (s.Substring(CutWord, 1) == "(")
                        {
                            if (s.Substring(s.Length - (CutWord + 1), 1) != ")" && s.Substring(CutWord + 1, 1) != ")")
                                return false;
                            if (s.Substring(s.Length - (CutWord + 1), 1) == "}" && CutWord >= s.Length / 2)
                                break;
                            if (s.Substring(CutWord + 1, 1) == ")")
                                CutWord++;                            
                        }
                        if (CutWord == s.Length - 1)
                            break;
                    }
                    else
                        return false;
                }
                return true;
            }
            else
                return false;
        }

        //private static bool FirstCheck(string Left, string Right, string Source, int CycleNow)
        //{

        //}

    }
}
