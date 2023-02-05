using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_Вывести_содержимое
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\06_Скрипты\01_AR";
            string[] files = Directory.GetFiles(path,"*.dyn",SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
