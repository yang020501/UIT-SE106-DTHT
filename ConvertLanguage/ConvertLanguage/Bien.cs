using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLanguage
{
    class Bien
    {
        public string name;
        public string type;

        public void getDataType_Name(string s)
        {
            string typeInput;
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char check = s[i];
                if (check == ':')
                {
                    index = i;
                }
            }

            name = s.Substring(0, index).Trim();
            typeInput = s.Substring(index + 1, s.Length - index - 1).Trim();

            if (typeInput == "R")
            {
                type = "double";
            }
            else if (typeInput == "Z" || typeInput == "N")
            {
                type = "int";
            }
            else if (typeInput == "B")
            {
                type = "bool";
            }
            else if (typeInput == "R*")
            {
                type = "double[]";
            }
            else if (typeInput == "Z*" || typeInput == "N*")
            {
                type = "int[]";
            }
            else if (typeInput == "B*")
            {
                type = "bool[]";
            }
            else if(typeInput == "char*")
            {
                type = "string[]";
            }
        }
    }
}
