using System;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok;
            int x,y;
            Console.WriteLine("Введите координаты");
            do
            {
                
                ok = Int32.TryParse(Console.ReadLine(), out x);
                if (!ok) Console.WriteLine("Error!");
            } while (!ok);
            do
            {
                Console.WriteLine("Введите координаты");
                ok = Int32.TryParse(Console.ReadLine(), out y);
                if (!ok) Console.WriteLine("Error!");
            } while (!ok);
            if (((x * x + y * y) <= 4) && (x * x + y * y >= 1) && (y >= 0)) Console.WriteLine("Принадлежит области");
            else Console.WriteLine("Не принадлежит");
        }
                
    }
}
