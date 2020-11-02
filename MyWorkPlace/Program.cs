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
        class Person
        {
            public int Age { get; set; }//property
            public string Name { get; set; }//property

            public Person()//concstructor
            {
                Name = "bobby";//property assignation of value
                Age = 3;//property assignation of value
            }

        }

        static void Main(string[] args)
        {
            Person bob = new Person();//concstructor implementation
            Console.WriteLine(bob.Name);//property implementation
            Console.WriteLine(bob.Age);//property implementation
        }
    }
}

