using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           

        }

        public void Stack() //про свою реализацию стека хотя не уверен это наверное мало???
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void Matritsa() //про матрицу
        {
            Console.Write("\n");
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\n");
            int[,] a = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    a[i, j] = rnd.Next(10, 100);
                    Console.Write(" " + a[i, j] + "");
                }
                Console.WriteLine();
            }
            {
                int opredelitel = a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
                Console.Write("\n");
                Console.WriteLine("2.Определитель матрицы = " + opredelitel);
            }
            Console.ReadKey();
        }

        public void ReverseAray() //про массив
        {
            int[] myarray = new int[10];
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = i;
            }
            Array.Reverse(myarray);
            for (int i = 0; i < myarray.Length; i++)
            {

                Console.WriteLine(myarray[i]);
            }
        }
            public void StringBracets() //про скобки
            {
                string text = Console.ReadLine();

                string[] bracets = text.Split(new char[] { ' ' });

                foreach (string s in bracets)
                {
                    if (s != "()")
                    {
                        Console.WriteLine("Строка не корректна");
                        return;
                    }
                }
                Console.WriteLine("Строка корректна");
            }
        }

}
