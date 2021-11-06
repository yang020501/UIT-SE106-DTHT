using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLanguage
{
    class CPp
    {
        private string result;
        public string Result { get => result; set => result = value; }
        public CPp()
        {
            result += "#include<iostream>\n\n" +
                  "using namespace std;\n\nx:R";
        }
        public string formNhap()
        {
            string result = "void Nhap_name(reftype)" +
                doRegex.tab(0) + "{" +
                doRegex.tab(1) + "nhaphere" +
                doRegex.tab(0) + "}" +
                doRegex.tab(0);
            return result;
        }
        public string formXuat()
        {
            string result = "void Xuat_name(resultType resultName)" +
                doRegex.tab(0) + "{" +
                doRegex.tab(1) + "cout << \"Ket qua la: \" << resultName;" +
                doRegex.tab(0) + "}" +
                doRegex.tab(0);
            return result;
        }
        public string formCheck(string txt)
        {
            string result = "";
            if (txt == "")
            {
                result = "public int Check_name(type)" +
                doRegex.tab(0) + "{" +
                doRegex.tab(1) + "return 1;" +
                doRegex.tab(0) + "}" +
                 doRegex.tab(0);

            }
            else
            {
                result = "int Check_name(type)" +
                    doRegex.tab(0) + "{" +
                    doRegex.tab(1) + "if( " + txt + " )" +
                    doRegex.tab(2) + "return 1;" +
                    doRegex.tab(1) + "else" +
                    doRegex.tab(2) + "return 0;" +
                    doRegex.tab(0) + "}" +
                    doRegex.tab(0);
            }
            return result;
        }
        public string formFunction()
        {
            string result = "resultType name(type)" +
               doRegex.tab(0) + "{" +
               doRegex.tab(1) + "result;" +
               doRegex.tab(1) + "post" +
               doRegex.tab(1) + "return resultName;" +
               doRegex.tab(0) + "}" +
               doRegex.tab(0);
            return result;

        }
        public string formMain()
        {
            string result = "int Main()" +
              doRegex.tab(0) + "{" +
              doRegex.tab(1) + "intro" +
              doRegex.tab(1) + "resultType resultName;" +
              doRegex.tab(1) + "Nhap_name(nonType);" +
              doRegex.tab(1) + "if(Check_name(nonType) == 1)" +
              doRegex.tab(1) + "{" +
              doRegex.tab(2) + "resultName = name(nonType);" +
              doRegex.tab(2) + "Xuat_name(resultName);" +
              doRegex.tab(1) + "}" +
              doRegex.tab(1) + "else" +
              doRegex.tab(2) + "cout << \"Du lieu sai\";" +
              doRegex.tab(1) + "return 0;" +
              doRegex.tab(0) + "}" +
              doRegex.tab(0);
            return result;
        }
    }
}
