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
        class MePerson
        {
            public string name = "Astley Dave De Mesa";
            public int age = 17;
            public int Getage() { return age; }
            public string WhoIam() { return $"My Name Is {name}. "; }
            public void HorrayPyramid(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j <= n; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*" + " ");
                    }
                    Console.WriteLine();
                }
            }
        }


        static void Main(string[] args)
        {
            MePerson Davey = new MePerson();
            string MyName = Davey.WhoIam();
            int Myage = Davey.Getage();

            Console.WriteLine(MyName);
            Console.WriteLine(Myage);
            Console.WriteLine("Now you know me. How old are you?");
            int intvalue = Convert.ToInt32(Console.ReadLine());
            Davey.HorrayPyramid(intvalue);
            Console.WriteLine("Great! You deserved this Pyramid");
            Console.ReadKey();

        }
    }
}

