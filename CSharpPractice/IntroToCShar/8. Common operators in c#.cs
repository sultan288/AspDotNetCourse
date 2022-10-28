using System;

namespace IntroToCShar
{
    class Program
    {
        static void Main()
        {
            //Assignment Operators
            string name = "Tipu";

            //Arithmetic Operators
            int fno = 31;
            int lno = 20;
            int result = fno + lno;
            Console.WriteLine("Result is {0} + {1} = {2}", fno,lno,result);

            int mod = fno % lno;
            Console.WriteLine("Modulus is " + mod);

            //Comparison Operators
            int x = 10;
            int y = 20;
            if (x == y)
            {
                Console.WriteLine("X is equal to y");
            }
            else
            {
                Console.WriteLine("X is not equal to y");
            }

            //Conditional Operators
            string con = "bd";
            string stat = "khu";
            if (con == "bd" && stat == "khu")
            {
                Console.WriteLine("Statement true");
            }
            else
            {
                Console.WriteLine("Statement false");
            }

            //Ternary Operators
            string con2 = "bd";
            string stat2 = "khu";
            string result2 = (con2 == "bd") ? "True stat" : "False stat";
            Console.WriteLine(result2);
        }       

    }
}
 