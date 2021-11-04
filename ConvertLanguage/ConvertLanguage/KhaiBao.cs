using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLanguage
{
    class KhaiBao
    {
        private string khaibaoNvT;
        private string name;
        private Bien[] bien;
        private Bien kq;

        public KhaiBao(string khaibaoNvT)
        {
            KhaibaoNvT = khaibaoNvT;
        }

        public string KhaibaoNvT { get => khaibaoNvT; set => khaibaoNvT = value; }
        public string Name { get => name; set => name = value; }
        public Bien[] Bien { get => bien; set => Bien = value; }
        public Bien KQ { get => kq; set => KQ = value; }
        

        public void getName_Bien()
        {
            string[] tmp = doRegex.doMain(KhaibaoNvT);
            Name = tmp[0];
            
            for(int i=1; i<tmp.Length-1; i++)
            {
                Bien[i - 1] = new Bien();
                Bien[i - 1].getDataType_Name(tmp[i]);
            }

            KQ = new Bien();
            KQ.getDataType_Name(tmp[tmp.Length - 1]);
        }
        
    }
}
