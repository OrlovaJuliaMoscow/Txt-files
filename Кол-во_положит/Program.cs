using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кол_во_положит
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\C#_temp\Numbers.txt";
            Random rand = new Random();
            using (StreamWriter sw = new StreamWriter(path,false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rand.Next(-10, 10));
                }
            }
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Convert.ToInt32(sr.ReadLine()) > 0)
                       k++;
                }
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
