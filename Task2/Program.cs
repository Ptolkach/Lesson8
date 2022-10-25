using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Пользователь\Desktop\ИТМО\Lesson8\Task2.txt";
            Random rnd = new Random();
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(1, 10));
                }
            }
            int s = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    s += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
