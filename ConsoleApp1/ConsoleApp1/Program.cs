using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a single line comment

            /* 
             * This is a multi-line comment.
             */

            Console.WriteLine("Hello Friend!");
            Console.Write("this is next to hello friend");
            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            DateTime dt = new DateTime(2019, 12, 24);

            Console.WriteLine(dt);

            // Keeps the application from closing
            Console.ReadLine();

            // CS datatypes
            string stringVar = "Hello World!!";
            int intVar = 100;
            float floatVar = 10.2f;
            char charVar = 'A';
            bool boolVar = true;

            Console.WriteLine(stringVar);
            Console.WriteLine(intVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(charVar);
            Console.WriteLine(boolVar);

        }
    }
}
