using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KPIEP_Laba15
{
    class ZnakiPrepChet
    {
        string text;
        string[] predl;
        public void ReadFile()
        {
            using (StreamReader sr = new StreamReader($"{Directory.GetCurrentDirectory()}\\2input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    text = sr.ReadToEnd();
                }
            }
            predl = text.Split('.');
        }

        public string Solution()
        {
            char[] mas = {',',':'};
            int count = predl[0].Count(x=> mas.Contains(x));
            string ans=predl[0];
            for (int i = 0; i < predl.Length-1; i++)
            {
                if (count> predl[i].Count(x => mas.Contains(x)))
                {
                    count = predl[i].Count(x => mas.Contains(x));
                    ans = predl[i];
                }
            }
            return ans;
        }
    }
}
