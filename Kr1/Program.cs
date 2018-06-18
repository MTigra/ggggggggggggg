using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Kr1
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                CreateFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Завершаюсь");
                return;
            }
        }

        public static void CreateFile()
        {
            int n = ParseInt("Введите количество строк:");
            int m = ParseInt("Введите макс значение:");
            string[] lines = GenerateLines(n, m);
            File.WriteAllLines("circuits.txt", lines);
        }

        public static string[] GenerateLines(int n, int m)
        {
            Random rnd = new Random();
            string[] line = new string[n];
            for (int i = 0; i < line.Length; i++)
            {
                double r = rnd.NextDouble() * rnd.Next(1, m + 1);
                double c = rnd.NextDouble() * rnd.Next(1, m + 1);
                double l = rnd.NextDouble() * rnd.Next(1, m + 1);
                line[i] = r.ToString("f3") + " " + c.ToString("f3") + " " + l.ToString("f3");
            }

            return line;
        }

        public static int ParseInt(string s)
        {
            int n;
            do
            {
                Console.WriteLine(s);
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            return n;
        }
    }
}