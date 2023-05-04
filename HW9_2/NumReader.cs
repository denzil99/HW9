using System;
using System.Collections.Generic;

namespace HW9_2
{
    internal class NumReader
    {
        List<string> list = new List<string>()
            {
                "Petrov", "Ivanov", "Simonov", "Knyazev", "Krivoruchkin"
            };

        public delegate void NumEnteredDelegate(int num, List<string> outList);
        public event NumEnteredDelegate NumEnteredEvent;


        public void ReadTheNum()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Сортирует фамилии от А до Я");
            Console.WriteLine("2 - Сортирует фамилии от Я до А");
            Console.WriteLine();
            Console.WriteLine("Ваше значение:");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num != 1 && num != 2) { throw new FormatException(); }

            NumEntered(num, list);

        }

        protected virtual void NumEntered(int numb, List<string> surnames)
        {
            NumEnteredEvent?.Invoke(numb, surnames);
        }
    }
}
