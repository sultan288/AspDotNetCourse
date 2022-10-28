using System;

namespace IntroToCShar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter firstname: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter lastname: ");
            string lastname = Console.ReadLine();

            //Using Place holder syntax
            //Console.WriteLine("Hello {0}", username);

            Console.WriteLine("My full name: {0} {1}", firstname, lastname);

            //Using Concatenation
            //Console.WriteLine("My full name: " + firstname +" " + lastname);

            Console.WriteLine("Enter first no: ");
            int firstno = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter last no: ");
            int lastno = Convert.ToInt32(Console.ReadLine());
            int result = firstno + lastno;

            Console.WriteLine("My Result is {0} + {1} = {2}", firstno, lastno, result);
        } 
       
    }
}
