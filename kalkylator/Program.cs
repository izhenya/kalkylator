using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char c;
            Console.WriteLine("введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите способ расчёта (+, -, *, /)");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            switch (c) 
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a ,b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;

                    case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                    case '/':
                    Console.WriteLine("{0}/{1}={2}" , a , b , a / b);
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;



            }
                
        }
    }
}
