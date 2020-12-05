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
    //i am DireVader sir baka akala nyo po ibang tao hahaha sarili ko pong guthub yan
    class Program
    {



        static void Main(string[] args)
        {
            int[] myarray = new int[3];
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The inputs are:");
            Console.WriteLine("{0}\n{1}\n{2}", myarray[0], myarray[1], myarray[2]);
        }
    }
}


