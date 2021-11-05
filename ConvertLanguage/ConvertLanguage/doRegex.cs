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
            return result; // trả về kiểu mảng chuỗi với phần tử đầu là name và cuối là result giữa là các biến

        }
        // hàm cắt dòng main (khai báo)
        public static string cutMain(string txt) // dạng **** các chữ trc pre
        {
            clearSpace(ref txt); // clear toàn bộ space và \n
            MatchCollection main = Regex.Matches(txt, @".*?(?=pre)");
            return txt = main[0].Value; 

        }
        //hàm cắt dòng pre 
        public static string cutPre(string txt) // dạng : pre****post
        {
            clearSpace(ref txt);
            MatchCollection pre = Regex.Matches(txt, @"pre(.*?)post"); // do match có trùng pre,post nên lấy () group khi chạy regextester.exe
            return txt = pre[0].Groups[1].Value;
        }
        //Hàm cắt dòng post
        public static string cutPost(string txt)
        {
            clearSpace(ref txt);
            MatchCollection post = Regex.Matches(txt, @"post(.+)");  //dạng ***** các chứ sau post
            return txt = post[0].Groups[1].Value; // do match có trùng post nên lấy () group khi chạy regextester.exe
        }
        //Hàm cắt thành phần trong post
        public static List<string[]> doPost(string txt)
        {
            List<string[]> list = new List<string[]>();
            clearSpace(ref txt);
            txt = Regex.Replace(txt, @"\(", "");
            txt = Regex.Replace(txt, @"\)", ""); // clear hết ngoặc 
            string[] s = Regex.Split(txt, @"\|\|"); // cắt các cụm kq và đk
            for (int i = 0; i < s.Length; i++)
            {
                string[] a = Regex.Split(s[i], @"&&"); // cắt các biểu thức trong 1 cụm lưu vào mảng
                list.Add(a);
            }
            foreach(string[] item in list)
            {
                for(int i=1;i<item.Length;i++)
                {
                    item[i] = Regex.Replace(item[i], @"\b(=)", "=="); // thay = trong dk thành == 
                }    
            }    
            return list; // trả về danh sách các cụm điều kiện và kq đã đc cắt dạng kq=xxx && dk && dk của 1 item
        }
        public static string replaceType(string s)
        {
            if (s == "char*")
                return "string";
            else if (s == "R")
                return "float";
            else if (s == "Z" || s == "N" || s == "N1")
                return "int";
            else if (s == "B")
                return "bool";
            else if (s == "R*")
                return "float[]";
            else if (s == "Z*" || s == "N*" || s=="N1*")
                return "int[]";
            return "";
        }

        public static string Arr(string s)
        {
            if (s == "float[]")
                return "float";
            else
                return "int";
            
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
