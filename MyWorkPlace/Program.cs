using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathTools;
using MyPrinterTools;
using MyMiscsTools;

namespace MyWorkPlace
{
    //git hub 58480803+direvader12@users.noreply.github.com
    class Program
    {
        static void Main(string[] args)
        {
            //MathFramework sum = new MathFramework();
            int sum = 0;
            int[] myarray = { 1, 4, 78, 89, 97, 0, 4 };
            for (int i = 0; i > myarray.Length; i++)
            {
                sum = sum + myarray[i];
            }
            Console.WriteLine(sum);
        }
    }
}

