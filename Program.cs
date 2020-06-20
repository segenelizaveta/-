using System;

namespace Задача_6
{
    class Program
    {
        public static void Rekur(ref double a1, ref double a2, ref double a3, ref int count)
        {
            double x;
            count++;
            x = (a2 / a3) + Math.Abs(a1);
            Console.Write( x + " ");
            a1 = a2;
            a2 = a3;
            a3 = x;
        }
        static void Main(string[] args)
        {
            double a1, a2, a3, m;
            int n;
            bool ok;
            Console.WriteLine("Введите а1,а2,а3, N и M");
            do
            {
                ok = Double.TryParse(Console.ReadLine(), out a1);
                if (!ok) Console.WriteLine("Ошибка!Введите число.");
            } while (!ok);
            do
            {
                ok = Double.TryParse(Console.ReadLine(), out a2);
                if (!ok) Console.WriteLine("Ошибка!Введите число.");
                if (a2 == 0) Console.WriteLine("Ошибка! a2 не может быть 0.");
            } while ((!ok) || (a2 == 0));
            do
            {
                ok = Double.TryParse(Console.ReadLine(), out a3);
                if (!ok) Console.WriteLine("Ошибка!Введите число.");
                if (a3 == 0) Console.WriteLine("Ошибка! a3 не может быть 0.");
            } while ((!ok) || (a2 == 0));
            do
            {
                ok = Int32.TryParse(Console.ReadLine(), out n);
                if (!ok) Console.WriteLine("Ошибка!Введите целое положительное число.");
                if (n <= 3) Console.WriteLine("Ошибка! N должно быть");
            } while ((!ok) || (n <= 3));
            do
            {
                ok = Double.TryParse(Console.ReadLine(), out m);
                if (!ok) Console.WriteLine("Ошибка!Введите число.");
            } while (!ok);
            Console.WriteLine();
            Console.Write(a1 + " " + a2 + " " + a3 + " ");
            int count = 3;
            while ((count < n) & (a3 < m))
            {
                Rekur(ref a1,ref a2,ref a3,ref count);
            }
            if (count == n) Console.WriteLine("Количество элементов достигло N.");
            if (a3 > m) Console.WriteLine("Элемент стал больше, чем M.");

        }
    }
}