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
                        
            bool Test = E_Brackets.IsValid("(([]){})");
            //string[] QQQ = new string[2] { "ab", "a" };
            //string Outcome = LongestCommonPrefix(QQQ);

            //E_RomaNumber e_RomaNumber = new E_RomaNumber();
            //int TESTt =  e_RomaNumber.RomanToInt("X");

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
