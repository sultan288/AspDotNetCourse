using System;

namespace IntroToCShar
{
    class Program
    {
        static void Main()
        {
            //Boolean Types
            //======================================================
            bool bl = false;
            Console.WriteLine("Are you major: " +bl);

            //Integral Types
            //========================================================
            byte age = 255;
            Console.WriteLine("Age is : "+age);

            char cr = 'A';
            int i = Convert.ToInt16(cr);
            Console.WriteLine("Character value is: " +i);

            //Find Minimum and Maximum value
            //Console.WriteLine("Minimum vale of int is {0} and Maximum value is {1}", int.MinValue, int.MaxValue);
            //Console.WriteLine("Minimum vale of byte is {0} and Maximum value is {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("Minimum vale of long is {0} and Maximum value is {1}", long.MinValue, ulong.MaxValue);

            //Floating Data Types
            //===================================================
            float flt = 100.00011F; // F is mandatory
            Console.WriteLine("Float value is :"+flt);
            Console.WriteLine("float is {0} and {1} ", float.MinValue, float.MaxValue);


            double dbl = 110.345021121210D; // D is optional
            Console.WriteLine("Double value is " +dbl);

            //Decimal Data Types
            //======================================================
            decimal decm = 10100000000000.12344555554554M; // M is mandatory
            Console.WriteLine("Decimal value is {0}", decm);
        }       
    }
}
