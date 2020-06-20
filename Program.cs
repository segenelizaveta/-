using System;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random() ;
            bool ok;
            int punkt,i,k;
            int[] mas = new int[64];
            Console.WriteLine("Выберите способ ввода");
            Console.WriteLine("1. Ручной ввод");
            Console.WriteLine("2.Рандом");
            do
            {
                ok = Int32.TryParse(Console.ReadLine(), out punkt);
                if ((!ok) || (punkt < 1) || (punkt > 2)) Console.WriteLine("Ошибка!Введите 1 или 2.");
            } while ((!ok) || (punkt < 1) || (punkt > 2));

            switch (punkt)
            {
                case 1:
                    {
                        for (i=0;i<64;i++)
                        {
                            do
                            {
                                ok = Int32.TryParse(Console.ReadLine(), out mas[i]);
                                if (!ok)  Console.WriteLine("Ошибка!Введите 1 или 2.");
                            } while (!ok);
                        }
                        break;
                    }
                case 2:
                    {
                        for (i = 0; i < 64; i++)
                        {
                            mas[i] = rand.Next(-100,100) ;
                        }
                        break;
                    }
            }
            Console.WriteLine("Начальная последовательность:");
            for (i=0;i<64;i++)
            {
                if (i % 8 == 0) Console.WriteLine();
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Полученная матрица:");
            k = 0;
            string s = "";
            for (i = 0; i < 64; i++)
            {
                if (i % 8 == 0)
                {
                    Console.WriteLine();
                    k++;
                }
                if (k % 2 == 0)
                {
                    Console.Write(mas[i] + " ");
                }
                else
                {
                    s = mas[i] + " " + s;
                    if ((i + 1) % 8 == 0)
                    {
                        Console.Write(s);
                        s = "";
                    }
                }
            }
        }
    }
}
