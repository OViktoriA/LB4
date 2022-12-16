using System;

namespace lb4
{
    class Program
    {
        private static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char oper;
            double i;
            a = 1;
            b = 1;


            char again = 'д';
            while (again == 'д')
            {
                Console.WriteLine("1. ввести A");
                Console.WriteLine("2. ввести B");
                Console.WriteLine("3. выполнить операцию «+»");
                Console.WriteLine("4. выполнить операцию «-»");
                Console.WriteLine("5. выполнить операцию «*»");
                Console.WriteLine("6. выполнить операцию «/»");
                i = Convert.ToDouble(Console.ReadLine());
          
                if (i == 1)
                {
                    Console.WriteLine("Введите A:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("A = " + a);
                    continue;
                }

                if (i == 2)
                {
                    Console.WriteLine("Введите B:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("B = " + b);
                    continue;
                }

                if (i == 3)
                {
                    total = a + b;
                    Console.WriteLine(a + " + " + b + " = " + total);
                }

                if (i == 4)
                {
                    total = a - b;
                    Console.WriteLine(a + " - " + b + " = " + total);
                }

                if (i == 5)
                {
                    total = a * b;
                    Console.WriteLine(a + " * " + b + " = " + total);
                }

                if (i == 6)
                {
                    total = a / b;
                    Console.WriteLine(a + " / " + b + " = " + total);
                }

                else
                {
                Console.WriteLine("Неизвестный оператор.");
                }

                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }

        }
    }
}
