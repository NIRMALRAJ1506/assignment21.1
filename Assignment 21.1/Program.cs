using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_21._1
{
    public class Calc
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int  Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
       public static int Divide(int a, int b)
        {
            return a / b;
        }
    }

    
    public delegate int ArithmeticOperation(int x,int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Calc calc = new Calc();
            Console.WriteLine("Enter first number");
            int fn=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int sn=int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Choose the oprations 1.Addition 2.Subtraction 3.Multiplication 4.Division");
                int op=int.Parse(Console.ReadLine());
                ArithmeticOperation ari;
                switch (op)
                {
                    case 1:
                        {
                            ari = new ArithmeticOperation(Calc.Add);
                            Console.WriteLine("Addition of two numbers "+ari(fn,sn));
                            break;
                        }
                    case 2:
                        {
                            ari = new ArithmeticOperation(Calc.Subtract);
                            Console.WriteLine("Addition of two numbers " + ari(fn, sn));
                            break;
                        }
                    case 3:
                        {
                            ari = new ArithmeticOperation(Calc.Multiply);
                            Console.WriteLine("Addition of two numbers " + ari(fn, sn));
                            break;
                        }
                    case 4:
                        {
                            ari = new ArithmeticOperation(Calc.Divide);
                            Console.WriteLine("Addition of two numbers " + ari(fn, sn));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("invalid option");
                            break;

                        }
                }
                Console.WriteLine("Do you wanna continue press y/n");
                choice=Console.ReadLine();
            } while (choice == "y");

        }
    }
}
