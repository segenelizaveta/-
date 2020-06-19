using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Задача1
{
    class Program
    {
        public static int NOD(int a, int b)
        {
            while ((a != 0) & (b != 0))
            {
                if (a > b)
                    a = a % b;
                else b = b % a;
            }
            if (a > b)
                return a;
            else return b;
        }
        static void Main(string[] args)

        {
            Console.WriteLine("Введите n,x,y через пробел.После последнего числа поставьте пробел.");
            int nod;
            double time;
            string text = "";
            int count = 0;
            int n=0, x=0, y=0;
            string input_f = "input.txt";
            string output_f = "output.txt";

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
                    else if (chr!=' ')
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
                            case 2: x = Convert.ToInt32(text);
                                if (x > 10)
                                {
                                    x = 0;
                                    Console.WriteLine("x и y должны быть меньше 11");
                                }
                                    break;
                            case 3: y = Convert.ToInt32(text);
                                if (y > 10)
                                {
                                    y = 0;
                                    Console.WriteLine("x и y должны быть меньше 11");
                                }
                                break;
                        }
                        text = "";

                    }
                } while (reader.Peek() > -1);
            }
            if ((n != 0) & (x != 0) & (y != 0))
            {
                Console.Write(n + " " + x + " " + y);
                nod = NOD(x, y);
                double x2 = Convert.ToDouble(x);
                double y2 = Convert.ToDouble(y);
                double nod2 = Convert.ToDouble(nod);
                double s1 = nod2 / x2;
                double s2 = nod2 / y2;
                time = n * nod / ((s1 + s2));
                time = Math.Truncate(time);
                while ((time % x != 0) & (time % y != 0))
                    time++;

                using (FileStream sf = new FileStream(output_f, FileMode.OpenOrCreate)) { }
                using (StreamWriter writer = new StreamWriter(output_f))
                {
                    writer.Write(time);
                }
                Console.WriteLine("\nOUTPUT.TXT\n\n" + time);

                Console.ReadKey();
            }
            else Console.WriteLine("Ошибка!");
        }
    }
}
