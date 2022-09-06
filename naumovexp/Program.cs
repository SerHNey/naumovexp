using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naumovexp
{
    internal class Program
    {
        public void Exp1()
        {
            Console.WriteLine("Задание №1");
            Console.WriteLine("Введите первое число");
            double number_one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double number_two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(number_one,number_two));
            Console.ReadKey();
        }
        public void Exp2()
        {

        }
        public void Exp3()
        {
            Console.WriteLine("Задание №3");
            Console.WriteLine("Введите  число");
            double number_one = Convert.ToDouble(Console.ReadLine());
            double del2 = number_one % 2;
            double del3 = number_one % 3;
            if (del2 == del3)
            {
                Console.WriteLine($"Остаток от деления одинаковый при делении на 2 и 3 и равен {del2}");
            }
            else
            {
                Console.WriteLine($"Остатки от деления разные и равны {del2} и {del3}");
            }
        }
        public void Exp4(int number_one)
        {
            
        }
        public void Exp5()
        {
            Console.WriteLine("Задание №5");
            Console.WriteLine("Введите первое число");
            double number_one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double number_two = Convert.ToDouble(Console.ReadLine());
            double result = (1 + Math.Sin(Math.Sqrt(number_one + 1))) / (Math.Cos(12*number_two - 4));
            Console.WriteLine($"Результат выражения при введёных цифрах равен {result}");
            
        }
        public void Exp6()
        {

        }
        public void Exp7()
        {
            Console.WriteLine("Задание №7");
            Console.WriteLine("Введите число");
            int number_one = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            double num1 = 1;
            double num2 = 2;
            for(int i = 0; i < number_one; i++)
            {
                result += num1 / num2;
                num1++;
                num2++;
            }
            Console.WriteLine($"Сумма первых n членов последовательности равна: {result}");
            
        }
        public void Exp8()
        {
            Console.WriteLine("Задание №8");
            Console.WriteLine("Введите результаты первого спортсмена");
            double number_one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите результаты второго спортсмена");
            double number_two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите результаты третьего спортсмена");
            double number_three = Convert.ToDouble(Console.ReadLine());
            if(number_one < number_two && number_one < number_three)
            {
                Console.WriteLine($"Лучший результат: {number_one}");
            } else if (number_two < number_three)
            {
                Console.WriteLine($"Лучший результат: {number_two}");
            }
            else { Console.WriteLine($"Лучший результат: {number_three}"); }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Выберите задание 1-3-5-7-8");
            int v = Convert.ToInt16(Console.ReadLine());
            switch (v)
            {
                case 1:
                    program.Exp1();
                    break;
                case 3:
                    program.Exp3();
                    break;
                case 5:
                    program.Exp5();
                    break;
                case 6:
                    //program.Exp6();
                    break;
                case 7:
                    program.Exp7();
                    break;
                case 8:
                    program.Exp8();
                    break;
                default:
                    {
                        Console.WriteLine("Неверно");
                        break;
                    }
            }
            Console.ReadLine();
        }
    } 
} 
