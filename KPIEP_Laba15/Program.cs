using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KPIEP_Laba15
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Console.ReadLine();
        }

        private static void Ex2()
        {
            Console.WriteLine("Предложение с наименьшим кол-вом знаков препинания:");
            ZnakiPrepChet znakiPrepChet = new ZnakiPrepChet();
            znakiPrepChet.ReadFile();
            Console.WriteLine(znakiPrepChet.Solution());
        }

        private static void Ex1()
        {
            MasReader masReader = new MasReader();
            masReader.ReadFile();
            masReader.OutputMas();
            Console.WriteLine("Ср арефм.+производ:");
            masReader.OutputRezMas();
        }
    }
}
