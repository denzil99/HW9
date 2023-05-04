using System;
using System.Collections.Generic;

namespace HW9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Petrov", "Ivanov", "Simonov", "Knyazev", "Krivoruchkin"
            };

            NumReader nr = new NumReader();
            nr.NumEnteredEvent += SortSurnames;
            int val = 0;

            while (true)
            {
                try
                {
                    nr.ReadTheNum();
                }
                catch
                {
                    Console.WriteLine("Вы ввели неправильное значение.");
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }

        static void SortSurnames(int numb, List<string> surnames)
        {
            surnames.Sort();

            if (numb == 1)
            {
                foreach (string s in surnames)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                surnames.Reverse();

                foreach (string s in surnames)
                {
                    Console.WriteLine(s);
                }
            }
        }


    }
}
