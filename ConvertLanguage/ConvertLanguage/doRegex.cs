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
        public static void clearSpace(ref string  txt)
        {
            txt = Regex.Replace(txt, @"\s+", "");
        }
        // hàm cắt dòng dòng khai báo implicit
        public static string[] doMain(string txt) // txt là 1 chuỗi các loại trong Implicit
        {
            string name;
            doRegex.clearSpace(ref txt); // xoá space
            MatchCollection c = Regex.Matches(txt, @"(?<name>(\w)+|\S)"); // cắt tên hàm
            MatchCollection d = Regex.Matches(txt, @"(?<type>(\w+:((\w\*|\w))))"); // cắt các biến 
            name = c[0].Groups["name"].ToString(); // tên chỉ 1 nên kh cần duyệt
            string[] type = new string[d.Count];
            for (int i = 0; i < d.Count; i++)
            {
                type[i] = d[i].Value.ToString(); // biến có nhiều thằng 
            }
            string[] result = new string[1 + type.Length];
            
            for (int i=0;i<result.Length;i++)
            {
                if (i == 0)
                    result[i] = name;
                else
                    result[i] = type[i - 1];
            }
            
            return result;
        }
    }
}
