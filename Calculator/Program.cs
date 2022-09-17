using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddScoped<Operations>();
            collection.AddScoped<CHistory>();
            IServiceProvider serviceProvider = collection.BuildServiceProvider();
            var OperationsDep = serviceProvider.GetService<Operations>();
           
            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("                            Welcome to mini calculator");
            Console.WriteLine("---------------------------------------------------------------------\n");
            string x = "y";
            int op = 0;
           
            while (x == "y")
            {
                try
                {
                    Console.WriteLine("Which operation would you like to do? \n 1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Divide \n 5.History");
                    op = int.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine("\n Please select from the given choices \n");
                }
                
                double ans = 0;
                if(op == 1)
                {
                    ans = OperationsDep.Add();
                    Console.WriteLine("Result: {0}",ans);
                }
                else if(op == 2)
                {
                    ans = OperationsDep.Sub();
                    Console.WriteLine("Result: {0}", ans);
                }
                else if (op == 3)
                {
                    ans = OperationsDep.Multi();
                    Console.WriteLine("Result: {0}", ans);
                }
                else if (op == 4)
                {
                    ans = OperationsDep.Div();
                    Console.WriteLine("Result: {0}", ans);
                }
                else if(op == 5)
                {
                    OperationsDep.History();
                }
                else
                {
                    Console.WriteLine("----This choice does not exist!!!----");
                }
                Console.WriteLine("\nWould you like to continue!!! Press y \n Press any key to exit!!!");
                x = Console.ReadLine();
            }
            

        }
    }
}
