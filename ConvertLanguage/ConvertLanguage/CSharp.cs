using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string result = "public void Nhap_name(reftype)"+
                doRegex.tab(2) + "{" +
                doRegex.tab(3) + "nhaphere" +
                doRegex.tab(2) + "}" +
                doRegex.tab(2);
            return result;
        }
        public string formXuat()
        {
            string result = "public void Xuat_name(resultType result)" +
                doRegex.tab(2) + "{" +
                doRegex.tab(3) + "Console.WriteLine(\"Ket qua la: \" + result);" +
                doRegex.tab(2) + "}" +
                doRegex.tab(2);
            return result;
        }  
        public string formCheck(string txt)
        {
            if (txt == "")
                txt = "true";
            string result = "public int Check_name(type)" +
                doRegex.tab(2) + "{" +
                doRegex.tab(3) + "if( "+txt+" )" +
                doRegex.tab(4) + "return 1;" +
                doRegex.tab(3) + "else" +
                doRegex.tab(4) + "return 0;" +
                doRegex.tab(2) + "}" +
                doRegex.tab(2);            
            return result;
        }
        public string formFunction()
        {
            string result = "public resultType name(type)" +
               doRegex.tab(2) + "{" +
               doRegex.tab(3) + "resultType result = rstValue;" +
               doRegex.tab(3) + "post" +
               doRegex.tab(3) + "return result;" +
               doRegex.tab(2) + "}" +
               doRegex.tab(2);
            return result;

        }
        public string formMain()
        {
            string result = "public static void Main(string[] args)"+
              doRegex.tab(2) + "{"+
              doRegex.tab(3) + "intro" +
              doRegex.tab(3) + "resultType result = rstValue;" +
              doRegex.tab(3) + "Nhap_name(nonrefType);" +
              doRegex.tab(3) + "if(Check_name(nonType) == 1)" +
              doRegex.tab(3) + "{" +
              doRegex.tab(4) + "result = name(nonType);" +
              doRegex.tab(4) + "Xuat_name(result);" +
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
