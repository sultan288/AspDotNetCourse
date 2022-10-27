using System;

namespace IntroToCShar
{
    class Program
    {
        static void Main()
        {
            //Boolean Types
            bool bl = false;
            Console.WriteLine("Are you major: " +bl);

            //Integral Types
            byte age = 255;
            Console.WriteLine("Age is : "+age);

            char cr = 'A';
            int i = Convert.ToInt16(cr);
            Console.WriteLine("Character value is: " +i);

            //Minimum and Maximum value
            Console.WriteLine("Minimum vale of int is {0} and Maximum value is {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Minimum vale of byte is {0} and Maximum value is {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Minimum vale of long is {0} and Maximum value is {1}", long.MinValue, ulong.MaxValue);
        } 
       
    }
}
