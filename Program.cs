using System;

namespace Задача_7
{
    class Program
    {
        public static int Heming(int i, string word)
        {
            int a, j;
            int count = 0;
            int bayt = 0;
            int c = Convert.ToInt32(word[i]);
            do
            {
                for (j = i; j < i + i - 1; j++)
                {
                    if (j < word.Length)
                    {
                        count++;
                        if (count % 2 != 0) bayt = bayt + Convert.ToInt32(word[j]);
                    }
                }
                i = i + i * 2;
            } while ((i < word.Length) && (j < word.Length));
            if (bayt % 2 == 0) bayt = 0;
            else bayt = 1;
            return bayt;
        }
        static void Main(string[] args)
        {
            int i, bayt;
            double j;
            bool ok = true;
            string word;
            do
            {
                ok = true;
                Console.WriteLine("Введите кодовое слово");
                word = Console.ReadLine();
                foreach (char c in word)
                {
                    if ((c != '0') & (c != '1'))
                    {
                        Console.WriteLine("Error!");
                        ok = false;
                    }
                }
            } while (!ok);
            for (i = 0; i < word.Length; i++)
            {
                j = (Convert.ToDouble(i));
                if (Math.Log(j+1, 2) % 1 == 0)
                {
                    bayt = Heming(i, word) - Convert.ToInt32(word[i]);
                    if (bayt != Convert.ToInt32(word[i]))
                    {
                        Console.WriteLine("Ошибка в " + (i + 1) + " разряде");
                        ok = false;
                    }
                }
            }
            if (ok == true) Console.WriteLine("Ошибок нет");
        }
    }
}
