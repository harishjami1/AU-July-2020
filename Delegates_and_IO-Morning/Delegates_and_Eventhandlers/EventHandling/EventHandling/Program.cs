using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    public delegate void Notify(int a, int b);
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine("Enter an integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer");
            int b = Convert.ToInt32(Console.ReadLine());
            cal.OnPressEnter += Sum;
            Console.WriteLine("Please Press Enter to calculate the sum");
            Boolean flag = true;
            while (flag)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {

                    flag = !flag;
                    cal.EnterPressed(a, b);
                }
                else
                {
                    Console.WriteLine("Pressed the wrong key .Press Enter");
                }
                Console.WriteLine("Enter any key to exit");
            }Console.ReadKey();
        }
        public static void Sum(int a, int b)
        {
            Console.WriteLine("Sum:" + (a + b));
        }
    }

    public class Calculator
    {
        public event Notify OnPressEnter;

        public void EnterPressed(int a, int b)
        {
            OnPressEnter?.Invoke(a, b);
        }

    }
}