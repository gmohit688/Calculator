using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Operations
    {
            Queue<CHistory> history = new Queue<CHistory>();

            public double Add()
            {
                double num1 = 0, num2 = 0, ans = 0;
                
                    Console.WriteLine("Enter first number to add: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number to add: ");
                    num2 = double.Parse(Console.ReadLine());

                    history.Enqueue(new CHistory(num1, num2, "+"));

                return num1 + num2;
            }
            public double Sub()
            {
                double num1 = 0, num2 = 0;
              
                    Console.WriteLine("Enter first number to subtract: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number to subtract: ");
                    num2 = double.Parse(Console.ReadLine());
                    history.Enqueue(new CHistory(num1, num2, "-"));
                
                return num1 - num2;
            }
            public double Multi()
            {
                double num1 = 0, num2 = 0;
               
                    Console.WriteLine("Enter first number to multiply: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number to multiply: ");
                    num2 = double.Parse(Console.ReadLine());
                    history.Enqueue(new CHistory(num1, num2, "*"));
                
                return num1 * num2;
            }
            public double Div()
            {
                double num1 = 0, num2 = 0;
                try
                {
                    Console.WriteLine("\n Enter Divident to divide: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("\n Enter Divisor to divide: ");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        throw new ArithmeticException();
                    }
                    history.Enqueue(new CHistory(num1, num2, "/"));
                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine("\n Divisor cannot be zero!!!");
                }

                return num1 / num2;
            }
            public void History()
            {

                if (history.Count == 0)
                {
                    Console.WriteLine("History is empty!!!");
                }
                else
                {
                    Console.WriteLine("Operations history is as follows:");
                    foreach (CHistory x in history)
                    {
                        Console.WriteLine("-------------------");
                        Console.WriteLine(x.firstNumber + " " + x.stringOperation + " " + x.secondNumber);
                    }
                }
            }
        }
    
}
