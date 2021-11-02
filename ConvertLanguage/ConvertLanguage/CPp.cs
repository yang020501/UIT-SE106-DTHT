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
    }
}
