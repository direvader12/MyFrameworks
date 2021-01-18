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



    class AccountCreditInformation
    {
        struct Person
        {

            public string lastname;
            public string firstname;
            public string middlename;
            public int age;
            public string address;
            public double cashbalance;
        }

        static void Main(string[] args)
        {
            Person universal = new Person();
            universal.lastname = "error: invalid input";
            universal.firstname = "error: invalid input";
            universal.middlename = "error: invalid input";
            universal.age = 0000;
            universal.address = "error: invalid input";
            universal.cashbalance = 0000000.00;
            try
            {

                universal.lastname = Console.ReadLine();
                universal.firstname = Console.ReadLine();
                universal.middlename = Console.ReadLine();
                universal.age = Convert.ToInt32(Console.ReadLine());
                universal.address = Console.ReadLine();
                universal.cashbalance = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(universal.lastname);
                Console.WriteLine(universal.firstname);
                Console.WriteLine(universal.middlename);
                Console.WriteLine(universal.age);
                Console.WriteLine(universal.address);
                Console.WriteLine(universal.cashbalance);
            }
        }
    }
}



