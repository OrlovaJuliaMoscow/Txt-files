using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2_Сумма_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\C#_temp\SumNumbers.txt";
            Random rand = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rand.Next(-10, 10));
                }
            }
            int s = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    s = i++;
                }
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
