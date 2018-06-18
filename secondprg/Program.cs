using System;
using System.Collections;
using System.Collections.Generic;
using ClassLibrary1;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace secondprg
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Register reg = new Register();
            foreach (Circuit item in reg)
            {
                Console.WriteLine(item);
            }

            
            double userW = double.Parse(Console.ReadLine());
            
            foreach (Circuit item in reg)
            {
                item.W = userW;
            }

            
            //По W от пользователя по возрастанию реактивного оспротивления
            var query1 = from Circuit c in reg orderby c.ReactiveRes select c;
            
            
            
            foreach (Circuit item in query1)
            {
                Console.WriteLine(item);
            }
            //По W от пользователя вывести отрицательные.
            var query2 = from Circuit c in reg where c.ReactiveRes < 0 select c;
            foreach (Circuit item in query2)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Register : IEnumerable
    {
        public string path;

        public Register(string path = "circuits.txt")
        {
            this.path = path;
        }

        public IEnumerator GetEnumerator()
        {
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Circuit c = new Circuit();
                yield return c;
            }

            sr.Close();
        }
    }
}