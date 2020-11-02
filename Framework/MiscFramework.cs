using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMiscsTools
{
    public class MiscFramework
    {
        public int Age { get; set; }//property
        public string Name { get; set; }//property
        public char Yorn { get; set; }


        public void DrawPyramid(int n)
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


        public int VarAge()
        {
            return 3;
        }

        public string VarName()
        {
            return "Davey";
        }


    }
}
