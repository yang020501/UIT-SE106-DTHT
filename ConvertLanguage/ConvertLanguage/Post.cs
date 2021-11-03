using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvertLanguage
{
    class Post
    {
        

        //Hàm tách chuỗi của post condition thường
        public static string Tach_PostThuong(string post)
        {
            doRegex.clearSpace(ref post);

            for (int i = 0; i < post.Length; i++)
            {
                char s = post[i];
                if (s == 't')
                {
                    post = post.Substring(i + 1, post.Length - i - 1).Trim();
                    break;
                }
            }            
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
            return result;
        }


    }
}
