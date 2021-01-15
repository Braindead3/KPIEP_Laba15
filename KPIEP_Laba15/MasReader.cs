using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KPIEP_Laba15
{
    class MasReader
    {
        List<double>[] vs;
        List<double> output = new List<double>();

        public void ReadFile()
        {
            int i = 0;
            vs = new List<double>[File.ReadAllLines($"{Directory.GetCurrentDirectory()}\\1input.txt").Count()];
            for (int j = 0; j < vs.Length; j++)
            {

                vs[j] = new List<double>();

            }
            using (StreamReader sr = new StreamReader($"{Directory.GetCurrentDirectory()}\\1input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    string[] mas = str.Split();
                    foreach (var item in mas)
                    {
                        vs[i].Add(Convert.ToDouble(item));
                    }
                    i++;
                }
            }
        }

        public void OutputMas()
        {
            for (int i = 0; i < vs.Length; i++)
            {
                foreach (var item in vs[i])
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
        }

        public void OutputRezMas()
        {
           Solution();
           foreach (var item in output)
           {
             Console.WriteLine(item + " ");
           }
            WriteFile();
        }

        private double Proizvod(List<double> vs)
        {
            double ans=1;
            foreach (var item in vs)
            {
                ans *= item;
            }
            return ans;
        }

        private double Sloj(List<double> vs)
        {
            double ans = 0;
            int i=0;
            foreach (var item in vs)
            {
                if (item%2==0)
                {
                    ans += item;
                    i++;
                }
            }
            ans = ans / i;
            return ans;
        }

        private void Solution()
        {
            foreach (var item in vs)
            {
                output.Add(Proizvod(item) + Sloj(item));
            }
        }

        private void WriteFile()
        {
            using (StreamWriter sr = new StreamWriter($"{Directory.GetCurrentDirectory()}//1output.txt"))
            {
                foreach (var item in output)
                {
                    sr.WriteLine(item);
                }
            }
        }
    }
}
