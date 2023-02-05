using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Txt_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\C#_temp";
            string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
