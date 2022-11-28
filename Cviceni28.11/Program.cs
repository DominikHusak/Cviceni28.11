using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni28._11
{
    internal class Program
    {
        public delegate int Operation(int a, int b);

        public static int Add(int a, int b) => a + b;
        public static int Sub(int a, int b) => a + b;
        public static int Mul(int a, int b) => a + b;
        public static int Div(int a, int b) => a + b;

        public delegate int MyFunction(int x);
        MyFunction Square = x => x * x;
        MyFunction Cube =x => x * x * x;
        MyFunction Signum = x => x > 0 ? 1 : x < 0 ? -1 : 0; 

        static void Main(string[] args)
        {

        Operation operation = Add;
        Console.WriteLine(operation(12,5));
            operation = Sub;
        Console.WriteLine(operation(12,5));

            operation = Mul;
        Console.WriteLine(operation(12,5));

            operation = Div;
        Console.WriteLine(operation(12,5));

        Operation[] operations = { Add, Sub, Mul, Div };
            operation = operations[Int32.Parse(Console.ReadLine())];
            Console.WriteLine(operation(12,5));



        }
    }
}
