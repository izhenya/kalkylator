using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkylator
{
    internal class Program
    {
            double a, b; // правила именований
            char c;// следует давать значимые (передающие смысл) имена. Например typeOfTransaction
        // в методе Main не должно быть расчетов, весь функционал выносится в отдельные методы, а тут только их вызывают
        static void Main(string[] args)
        {
            GetInputData();
           Calc();      
        }
        static void Calc()
        {
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
        static void GetInputData()
        {
             Console.WriteLine("введите первое число:");
            a = Convert.ToDouble(Console.ReadLine()); // следовало добавить обработку исключения на случай, если не удалось конвертировать строку в число (например ввели дробное число или буквы)
            Console.WriteLine("введите способ расчёта (+, -, *, /)");
            c = Convert.ToChar(Console.ReadLine()); // обработка
            Console.WriteLine("введите второе число:");
            b = Convert.ToDouble(Console.ReadLine()); // обработка
        }
    }
}
