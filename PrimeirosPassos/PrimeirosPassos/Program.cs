using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassos
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            firstName = "Bob";
            Console.WriteLine(firstName);
            //  "Bob" = firstName;

            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(12.3m);
            Console.WriteLine("123");
            Console.WriteLine(123);

            
            firstName = "Bob";
            Console.WriteLine(firstName);
            firstName = "Beth";
            Console.WriteLine(firstName);
            firstName = "Conrad";
            Console.WriteLine(firstName);
            firstName = "Grant";
            Console.WriteLine(firstName);
            Console.Write("Hello, Bob! You have 3 in your inbox. The temperature is 34.4 celsius.");

            //var message;
            // var message = "Hello world!";
            // message=10.0;

            string word;
            word = "Bob";
            Console.WriteLine(word);
            word = "3";
            Console.WriteLine(word);
            word = "34.4";
            Console.WriteLine(word);

            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(messages);
            Console.Write(" in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");
            Console.ReadLine();

        }
    }
}
