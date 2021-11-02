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
            var absolute_path = Path.Combine(@"D:\000-Work to do\Download\FormalSpe\ConvertLanguage\ConvertLanguage\formC#.txt", "..\\formC#.txt");            

            string path = Path.GetFullPath((new Uri(absolute_path)).LocalPath);
            StreamReader read = new StreamReader(path);
            result = read.ReadToEnd();
        }
      

        
    }
}
