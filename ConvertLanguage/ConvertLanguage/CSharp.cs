using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLanguage
{
    public class CSharp
    {
        private string result;
        public string Result { get => result; set => result = value; }
        public CSharp()
        {
            result += "using System\n" +
                  "namespace FormalSpecification\n{\n" +
                  "\tpublic class Program\n\t{\n\t\tx:R\n\t}\n}";
        }
        public string formNhap()
        {
            string result = "public void Nhap_name(type)"+
                doRegex.tab(2) + "{" +
                doRegex.tab(3) + "x:r" +
                doRegex.tab(2) + "}" +
                doRegex.tab(2);
            return result;
        }
        public string formXuat()
        {
            string result = "public void Xuat_name(type)" +
                doRegex.tab(2) + "{" +
                doRegex.tab(3) + "x:r" +
                doRegex.tab(2) + "}" +
                doRegex.tab(2);
            return result;
        }  
        public string formCheck(string txt)
        {
            string result = "public int Check_name(type)" +
                doRegex.tab(2) + "{" +
                doRegex.tab(3) +  "if( "+txt+" )" +
                doRegex.tab(4) + "return 1;" +
                doRegex.tab(3) + "else" +
                doRegex.tab(4) + "return 0;" +
                doRegex.tab(2) + "}" +
                doRegex.tab(2);            
            return result;
        }
        public string formMain()
        {
            string result = "public static void Main(string[] args)"+
              doRegex.tab(2) + "{"+
              doRegex.tab(3) + "khaibao" +
              doRegex.tab(3) + "resulttype result = typevalue" +
              doRegex.tab(3) + "Nhap_name(type);" +
              doRegex.tab(3) + "if(Check_name() == 1)" +
              doRegex.tab(3) + "{" +
              doRegex.tab(4) + "x:r" +
              doRegex.tab(4) + "Xuat_name(result)" +
              doRegex.tab(3) + "}" +
              doRegex.tab(3) + "else" +             
              doRegex.tab(4) + "Console.WriteLine(\"Du lieu sai\");" +
              doRegex.tab(3) + "Console.ReadLine();" +
              doRegex.tab(2) + "}" +
              doRegex.tab(2);
            return result;
        }
      

        
    }
}
