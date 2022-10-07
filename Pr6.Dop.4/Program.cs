using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1, num2; // присвоение локальным переменным "num1", "num2" целого типа "short".
            num1 = 10; // присвоение значения локальной переменной
            num2 = 15; // присвоение значения локальной переменной

            Console.WriteLine("{0} + {1} = {2}", num1, num2, Sum(num1, num2));// Вычисление суммы и вывод вычислительной операции на экран.
            Console.ReadLine(); //считывание предыдущей строки.
        }

        static int Sum(int x, int y) // объявления статического члена и присвоение целого типа "int" целочисленным переменным x,y.
        {
            return x + y; // return служит для выхода из функции.
        }
    }
}