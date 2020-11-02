using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathTools
{
    public class MathFramework
    {
        //property
        public int VarSum { get; set; }
        public int Variable2 { get; set; }

        //object 
        public int Myvar1;
        public int Myvar2;

        //add two numbers result is the total
        public int Addition(int var1, int var2)
        {
            return var1 + var2;
        }
        //subtract two numbers result is the total
        public void Minus(ref int var1, ref int var2, ref int result)
        {
            result = var1 - var2;
        }
        //multiply two numbers result is the total
        public void Multiply(ref int var1, ref int var2, ref int result)
        {
            result = var1 * var2;
        }
        //divide two numbers result is the total
        public void Divide(ref int var1, ref int var2, ref int result)
        {
            result = var1 / var2;
        }
        // solve the factorial of a number
        public int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        // check the divisibility of first input by second input
        public void Divisibility(int number, int divby)
        {

            int divisibility = number % divby;
            if (divisibility == 0)
            {
                Console.WriteLine($"{number} is divisible by {divby}");

            }
            else
            {
                Console.WriteLine($"{number} is not divisible by {divby}");
            }

        }
    }
}
