using System;

namespace HW9
{
    internal class Program
    {
        // не созда изначально через гит т.к. проекты маленькие
        static void Main(string[] args)
        {
            Exception myEx = new Exception("Неведомая ошибка");
            StackOverflowException stackOverflowException = new StackOverflowException();
            NullReferenceException nullReferenceException = new NullReferenceException(); // почему-то выпадает в ошибку... не смотря на нахождение в блоке try. 
            // не выпадает в ошибку если экземпляр класса запихнуть в конец массива
            ArgumentException argumentException = new ArgumentException();
            IndexOutOfRangeException indexOutOfRangeException = new IndexOutOfRangeException();
            DivideByZeroException divideByZeroException = new DivideByZeroException();
            Exception[] exArray = { myEx, argumentException, indexOutOfRangeException, stackOverflowException, divideByZeroException, nullReferenceException };

            foreach (var ex in exArray)
            {
                try
                {
                    throw ex;
                }
                catch (Exception exept)
                {
                    if (exept is StackOverflowException) { Console.WriteLine(ex.Message); }
                    else if (exept is NullReferenceException) { Console.WriteLine(ex.Message); }
                    else if (exept is ArgumentException) { Console.WriteLine(ex.Message); }
                    else if (exept is IndexOutOfRangeException) { Console.WriteLine(ex.Message); }
                    else if (exept is DivideByZeroException) { Console.WriteLine(ex.Message); }
                    else { Console.WriteLine(exept.Message); }


                }

                //finally
                //{

                //}

            }

            Console.ReadKey();

        }
    }
}
