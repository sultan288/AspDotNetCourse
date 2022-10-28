using System;

namespace IntroToCShar
{
    class Program
    {
        static void Main()
        {
            string name = "Tipu Sultan";
            Console.WriteLine("Name is "+ name);

            //Escape Sequence
            //==============================================
            string Username = "\n \" \\sultan28\" \n Tipu";
            Console.WriteLine("UserName is "+Username);

            //Verbatim string literal
            //======================================================
            string Username2 = @"\n '\sultan28\' \n Tipu";
            Console.WriteLine("UserName is " + Username2);
        }       
    }
}
 