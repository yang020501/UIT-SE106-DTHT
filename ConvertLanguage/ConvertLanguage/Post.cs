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
        public string Tach_PostThuong(string post)
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

        //Hàm tách chuỗi của post condition có chứa array
        public static string[] Tach_PostArray(string post)
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

            for (int i = 0; i < post.Length; i++)
            {
                char s = post[i];
                if (s == '=')
                {
                    post = post.Substring(i + 1, post.Length - i - 1);
                    break;
                }
            }

            post = post.Substring(1, post.Length - 2);

            string[] result = new string[3];
            int count = 0;
            int indext = 0;

            for (int i = 0; i < post.Length; i++)
            {
                if (post[i] == '.' && post[i - 1] != '.' && post[i + 1] != '.')
                {
                    result[count] = post.Substring(indext, i - indext + 1);
                    indext = i + 1;
                    count++;
                }
            }

            result[count] = post.Substring(indext, post.Length - indext);
            if (count == 2)
            {
                return result;
            }
            else
            {
                count++;
                result[count] = "";
                return result;
            }

        }

    }
}
