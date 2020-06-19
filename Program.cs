using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача_2
{
    class Program
    {
        public static int MAX(string a, string b)
        {
            if (a.Length > b.Length)
                return a.Length;
            else return b.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n и k через пробел.");
            string text = "";
            int count = 0;
            int n = 0, k = 0;
            string input_f = "input.txt";
            string output_f = "output.txt";
            string h;
            int i, j, z;


            using (FileStream sf = new FileStream(input_f, FileMode.Create)) { }
            using (StreamWriter writer = new StreamWriter(input_f))
            {
                string str = Console.ReadLine();
                writer.Write(str);

            }
            using (StreamReader reader = new StreamReader(input_f, Encoding.Default))
            {
                Console.WriteLine("INPUT.TXT/n");
                do
                {

                    char chr = (char)reader.Read();

                    if (((chr >= '1') & (chr <= '9')) || (chr == '0'))
                        text += chr;
                    else if (chr != ' ')
                    {
                        Console.WriteLine("Введите 3 целых положительных числа после пробел.Поставьте пробел после положительного числа");
                        break;
                    }
                    if (chr == ' ')
                    {
                        if (text != "") count++;

                        switch (count)
                        {
                            case 1: n = Convert.ToInt32(text); break;
                            case 2:
                                k = Convert.ToInt32(text);
                                if (k > n)
                                {
                                    k = 0;
                                    Console.WriteLine("k должно быть меньше n");
                                }
                                break;
                        }
                        text = "";

                    }
                } while (reader.Peek() > -1);
                if (k == 0) k = Convert.ToInt32(text);

            }

            if ((n != 0) & (k != 0))
            {
               
                using (StreamWriter writer = new StreamWriter(input_f))
                {
                    Console.WriteLine(n+" "+k);
                }
                string[] mas = new string[n];
                for (i = 0; i < n; i++)
                {
                    mas[i] = Convert.ToString(i+1);
                }
                int length = mas[n-1].Length;
                z = 0;
                for (i = 0; i < n - 1; i++)
                {
                    for (j = i +1; j < n; j++)
                    {
                        for (z = 0; z < length; z++)
                        {
                            if ((mas[i].Length <= z) || (mas[j].Length <= z))
                                break;
                            if (mas[i][z] > mas[j][z])
                            {
                                h = mas[i];
                                mas[i] = mas[j];
                                mas[j] = h;
                                break;
                            }
                            if (mas[i][z] < mas[j][z]) break;
                        }
                    }
                }
                for (i = 1; i <= n - 1; i++)
                {
                    if (mas[i] == Convert.ToString(k))
                    {
                        using (FileStream sf = new FileStream(output_f, FileMode.OpenOrCreate)) { }
                        using (StreamWriter writer = new StreamWriter(output_f))
                        {
                            writer.Write(i+1);
                        }
                        Console.WriteLine("\nOUTPUT.TXT\n\n" + (i+1));
                        Console.ReadKey();
                        break;
                    }
                }


            }

        }
    }
}
