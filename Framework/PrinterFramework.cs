using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrinterTools
{
    public class PrinterFramework
    {
        //prints one int value
        public void PrinterInt(int a)
        {
            Console.WriteLine("Value: " + a);
        }
        //prints one Double value
        public void PrinterDouble(int a)
        {
            Console.WriteLine("Value: " + a);
        }
        //prints one string and one int value
        public void PrinterStringandNumber(string greeting, int value)
        {
            Console.WriteLine(greeting + " " + value);
        }
        //print two strings
        public string TwoString(string name1, string name2)
        {
            return $"{name1} {name2}";
        }
    }
}
