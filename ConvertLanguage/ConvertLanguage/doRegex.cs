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

        //Hàm tách chuỗi post thường
        public static string Tach_PostThuong(string post)
        {
            clearSpace(ref post);

            for (int i = 0; i < post.Length; i++)
            {
                char s = post[i];
                if (s == 't')
                {
                    post = post.Substring(i + 1, post.Length - i - 1).Trim();
                    break;
                }
            }
            Console.WriteLine(post);
            Console.WriteLine("-------------------------------------");
            int count = 0;
            int indexk = 0;
            string result = "";
            for (int i = 0; i < post.Length - 2; i++)
            {
                char s = post[i];

                if (s == '(')
                {
                    count++;
                }

                if (s == ')')
                {
                    count--;
                }

                if (count == 0 && post[i + 1] == '|' && post[i + 2] == '|')
                {
                    result += post.Substring(indexk, i + 3 - indexk) + "\n";
                    indexk = i + 3;
                }
            }
            result += post.Substring(indexk, post.Length - indexk);

            Console.Write(result);

            return result;
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
        public static string[] doPre(string txt)
        {
            return new string[4];
        }
    }
}
