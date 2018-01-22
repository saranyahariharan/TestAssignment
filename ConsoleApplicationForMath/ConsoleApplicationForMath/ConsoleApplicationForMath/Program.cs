using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationForMath
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the type of operation required");
            Console.WriteLine("Hint: Enter only the number");

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            int selecteVal;
            try { selecteVal = Convert.ToInt16(Console.ReadLine()); }
            catch { selecteVal = 0; }
            switch (selecteVal)
                {
                    case 1:
                        Console.WriteLine("Please enter 2 numbers for Addition");
                        int num1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the 2nd Number");
                        int num2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("The Addition result is for the Numbers {1},{2} - {0}",new Program().Addition(num1, num2),num1,num2);
                        break;
                    case 2:
                        Console.WriteLine("Please enter 2 numbers for Subtraction");
                        num1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the 2nd Number");
                        num2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("The Subtraction result is for the Numbers {1},{2} - {0}", new Program().Subtraction(num1, num2), num1, num2);
                        break;
                    case 3:
                        Console.WriteLine("Please enter 2 numbers for Multiplication");
                        num1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the 2nd Number");
                        num2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("The Multiplication result is for the Numbers {1},{2} - {0}", new Program().Multiplication(num1, num2), num1, num2);
                        break;
                    case 4:
                        Console.WriteLine("Please enter 2 numbers for Division");
                        num1 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the 2nd Number");
                        num2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("The Devision result is for the Numbers {1},{2} - {0}", new Program().Devision(num1, num2), num1, num2);
                        break;
                default:
                        Console.WriteLine("You have entered a wrong Input. Please enter number selection 1 - 4");
                        Main();
                        break;
                }

            Console.WriteLine("Hit any key to terminate the program");
            Console.Read();
           
        }

        public int Addition(int a, int b)
        {
            return a+b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public string Devision(int a, int b)
        {
            
           try
            {
                return (a / b).ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
