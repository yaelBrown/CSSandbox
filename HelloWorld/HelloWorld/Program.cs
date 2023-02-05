using System;
using System.Collections.Generic;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.Beep();

            byte a = 1;

            int b = Convert.ToInt16(a);

            Console.WriteLine(b);

            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
                                 

            // methods
            // access_modifier return_type method_name(params) {}
            PrintMessages();

            SayHello("popcorn");


            // datatypes (generics)
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "cookies");
            d.Add(2,"lemonade");
            Console.WriteLine(d);

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            List<string> l = new List<string>();
            l.Add("one");
            l.Add("two");
            l.Add("three");
            l.Add("four");


            // Nullable values is useful for when you pull data from a database
            int? c = 0;
            float? e = null;


            // Errors
            try
            {
                throw new Exception("This is an error");
            }
            catch
            {
                Console.WriteLine("This is the catch to the error");
            }
            finally
            {
                Exception err = new Exception("something didnt work");
                Console.WriteLine(err.StackTrace); // Stack trace of error
                Console.WriteLine(err.Message); // Message of the error
                Console.WriteLine(err.Source); // Source of the error?

                Console.WriteLine("Finally has been executed.") 
            };


            // Write to file
            File.Create("C:\\cs_file_test.txt");
            File.WriteAllText("C:\\cs_file_test.txt", "File from visual studio");
            // StreamReader sr;

            // Read files
            File.ReadAllText("C:\\cs_file_test.txt");

            StreamReader reader = new StreamReader("C:\\cs_file_test.txt");
            string resultReader = reader.ReadToEnd();
            Console.WriteLine(resultReader);

        }

        public static void PrintMessages()
        {
            Console.WriteLine("PrintMessages()");
            Console.WriteLine("PrintMessages()");
            Console.WriteLine("PrintMessages()");
            Console.WriteLine("PrintMessages()");
        }

        public static void SayHello(string username)
        {
            Console.WriteLine($"SayHello() {username}");
        }
    }
}
