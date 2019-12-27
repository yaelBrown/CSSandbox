using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
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

            Console.WriteLine("==============");

            // Math methods are similar like in 
            Console.WriteLine(Math.Pow(3, 2));

            bool compare = 4 == 4.0;


            Console.WriteLine("Compare is : " + compare);

            // Arrays (information needs to be of same type. Like java)
            int[] nums = { 1, 2, 3, 4, 5 };
            string[] str = new string[5];
            str[0] = "Yael";
            str[1] = "Ethan";
            str[2] = "Skyler";

            // Call method (methods and static context works similar to Java's)
            sayHello();
            Console.WriteLine(cube(3));

            // If statements work the same as in Java as well

            // Switch statements are the same as in Java.

            // While and Do-while loops are the same.

            // Create two-demensional arrays in c#
            int[,] twoDee =
            {
                {1, 2 },
                {2, 3 },
                {3, 4 }
            };


        }

        // Define methods
        static void sayHello()
        {
            Console.WriteLine("Hello !");
        }

        static int cube(int n)
        {
            return n * n * n;
        }

    }
}
