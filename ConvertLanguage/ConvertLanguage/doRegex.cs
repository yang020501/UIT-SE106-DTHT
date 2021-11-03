using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvertLanguage
{
    public static class doRegex
    {
        // xoá khoảng trắng
        public static void clearSpace(ref string  txt)
        {
            txt.Trim();
            txt = Regex.Replace(txt, @"\s+", "");
           
        }
        public static  string tab(int x)
        {
            string s = "\n";
            for (int i=0;i<x;i++)
            {
                s+="\t";
            }
            return s;
        }
        // hàm cắt dòng dòng khai báo implicit
        public static string[] doMain(string txt) // txt là 1 chuỗi các loại khai báo trong Implicit
        {
            doRegex.clearSpace(ref txt); // xoá space
            MatchCollection Name = Regex.Matches(txt, @"(?<name>(\w)+|\S)"); // cắt tên hàm
            MatchCollection Type = Regex.Matches(txt, @"(?<type>(\w+:((\w\*|\w))))"); // cắt các biến 
            string[] result = new string[1 + Type.Count];
            for (int i = 0; i < Type.Count; i++)
            {
                if (i == 0)
                    result[i] = Name[0].Groups["name"].ToString();
                else
                    result[i] = Type[i - 1].Value.ToString();
            }
            return result;

        }
        public static string[] doPre(string txt) // txt là một chuỗi Pre
        {
            MatchCollection Pre = Regex.Matches(txt, @"(?<type>((\w)+(\W)+(\w)+)|\W|(\W)+)");
            string[] result = new string[Pre.Count];
            for (int i = 0; i < Pre.Count; i++)
            {
                result[i] = Pre[i].Value.ToString(); 
            }

            return result;
        }
    }
}
