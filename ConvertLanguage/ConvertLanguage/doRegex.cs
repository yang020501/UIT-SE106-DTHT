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
        public static void clearSpace(ref string txt)
        {

            txt = Regex.Replace(txt, @"\s+", "");

        }
        public static string tab(int x)
        {
            string s = "\n";
            for (int i = 0; i < x; i++)
            {
                s += "\t";
            }
            return s;
        }
        // hàm cắt thành phần trong main(khai baó)
        public static string[] doMain(string txt) // txt là 1 chuỗi các loại khai báo trong Implicit
        {

            clearSpace(ref txt);
            MatchCollection Name = Regex.Matches(txt, @"((\w)+|\S)"); // cắt tên hàm
            MatchCollection Type = Regex.Matches(txt, @"((\w)+:(\w)+\**)"); // cắt các biến 
            string[] result = new string[1 + Type.Count];
            Console.WriteLine(Type.Count);
            result[0] = Name[0].Value;
            for (int i = 1; i <= Type.Count; i++)
            {

                result[i] = Type[i - 1].Value; // or có thể tạo gr type nhưng kết quả ý chang
            }
            return result;

        }
        // hàm cắt dòng main (khai báo)
        public static string cutMain(string txt)
        {
            clearSpace(ref txt); // clear toàn bộ space và \n
            MatchCollection main = Regex.Matches(txt, @".*?(?=pre)");
            return txt = main[0].Value; 

        }
        //hàm cắt dòng pre 
        public static string cutPre(string txt)
        {
            clearSpace(ref txt);
            MatchCollection pre = Regex.Matches(txt, @"pre(.*?)post"); // do match có trùng pre,post nên lấy group khi chạy regextester.exe
            return txt = pre[0].Groups[1].Value;
        }
        //Hàm cắt dòng post
        public static string cutPost(string txt)
        {
            clearSpace(ref txt);
            MatchCollection post = Regex.Matches(txt, @"post(.+)");
            return txt = post[0].Groups[1].Value; // do match có trùng post nên lấy group khi chạy regextester.exe
        }

        //public static string[] doPre(string txt) // txt là một chuỗi Pre
        //{
        //    MatchCollection Pre = Regex.Matches(txt, @"(?<type>((\w)+(\W)+(\w)+)|\W|(\W)+)");
        //    string[] result = new string[Pre.Count];
        //    for (int i = 0; i < Pre.Count; i++)
        //    {
        //        result[i] = Pre[i].Value.ToString(); 
        //    }

        //    return result;
        //}
    }
}
