using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvertLanguage
{
    public class Var
    {
        private string name;
        private string type;
        private string value;
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Value { get => value; set => this.value = value; }
        public Var(string s)
        {
            string[] a = Regex.Split(s, @":"); // s có dạng là chuỗi biến x:R,x:R thì hàm sẽ cắt và trả về a là  x R
            name = a[0];
            type = doRegex.replaceType(a[1]); // lấy về chuỗi type đúng
            if(type == "int" )
            {
                value = "0";
            }    
            else if(type == "float")
            {
                value = "0";
            }    
            else if(type == "string")
            {
                value = "\"\"";
            }    
            else if(type == "bool")
            {
                value = "false";
            }    
            else if (type == "float[]")
            {
                value = "new float[0]";
            }
            else if (type == "int[]")
            {
                value = "new int[0]";
            }
        }
      


    }
}
