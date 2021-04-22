using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //int[] A_int = new int[] {6,5,5, 2, 3, 4, 5, 4, 5, 6 };
            int[] A_int = new int[] { 1,1,2 };
            string[] A_str = new string[2] { "ab", "a" };

            string haystack = "qqqttlooll", needle = "ll";

            bool Test = E_Brackets.IsValid("(([]){})");

            E_StrStr e_StrStr = new E_StrStr();
            int indexStr = e_StrStr.StrStr(haystack, needle);

            // This one odd
            //E_RemoveDuplicates e_RemoveDuplicates = new E_RemoveDuplicates();
            //int RDu = e_RemoveDuplicates.RemoveDuplicates(A_int);

            //string Outcome = LongestCommonPrefix(QQQ);

            //E_RomaNumber e_RomaNumber = new E_RomaNumber();
            //int TESTt =  e_RomaNumber.RomanToInt("X");


            //int Target = 9;
            //int[] ans = E_TwoSum.TwoSum(Testt, Target);

            //bool TEst = IsPalindrome(12521);
        }

        


        public string LongestCommonPrefix(string[] strs)
        {
            string Now = "";
            string Next = "";
            int Count = 0;
            int Right = 0;
            if (strs.Length >= 1)
            {
                for (int Main = 0; Main < strs[0].Length; Main++)
                {
                    Count = 0;
                    Right = 0;
                    Now = strs[0].Substring(0, Main + 1);
                    for (int Compare = 1; Compare < strs.Length; Compare++)
                    {
                        try
                        {
                            Count++;
                            if (strs[Compare].Substring(0, Now.Length) == Now)
                            {
                                Right++;
                                if (Right == strs.Length - 1)
                                {
                                    Next = Now;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            return Next;
                        }
                    }
                    if (Count != Right)
                        return Next;
                }
                return Now;
            }
            else
                return "";
        }

        public bool IsPalindrome(int x)
        {
            int Xfar = x.ToString().Length;
            string Xword = x.ToString();

            for (int front = 0; front < Xfar / 2; front++)
            {
                string FF = Xword.Substring(front, 1);
                string BB = Xword.Substring(Xfar - front - 1, 1);

                if (Xword.Substring(front, 1) != Xword.Substring(Xfar - front - 1, 1))
                    return false;
            }
            return true;
        }
    }
}
