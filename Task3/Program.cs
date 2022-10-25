using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Пользователь\Desktop\ИТМО\Lesson8\Task3.txt";
            string s;
            string[] ss;
            int lines;
            int chars = 0;
            int words = 0;
            string[] w;

            using (StreamReader sr = new StreamReader(path))
            {
                s = sr.ReadToEnd();
            }
            ss = s.Split('\n');
            lines = ss.Length;
            foreach (string line in ss)
            {
                words += (line.Split(' ')).Length;
                chars += line.Length;
            }
            //При выводе количества символов, видимо, учитываются непечатные символы

            Console.WriteLine("Строк: {0}; Символов: {1}; Слов: {2}", lines, chars, words);
            Console.ReadKey();
        }
    }
}
