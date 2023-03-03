using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        struct Dog
        {
            public string name;
            public string mark;
            public int age;
        }
        enum HTTPError 
        {
            Bad_Request = 400,
            Unauthorized,
            Payment_Required,
            Forbidden,
            Not_Found
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            float a, b, c;
            Console.Write("Type a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type c: ");
            c = Convert.ToInt32(Console.ReadLine());  
            string answer_1 = (a >= -5 && a <= 5) ? "In Range" : "Out Of Range";
            string answer_2 = (b >= -5 && b <= 5) ? "In Range" : "Out Of Range";
            string answer_3 = (c >= -5 && c <= 5) ? "In Range" : "Out Of Range";
            Console.WriteLine($"{a} is {answer_1}");
            Console.WriteLine($"{b} is {answer_2}");
            Console.WriteLine($"{c} is {answer_3}");

            Console.WriteLine("Task 2");
            int d, e, f;
            Console.Write("Type d: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type e: ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type f: ");
            f = Convert.ToInt32(Console.ReadLine());
            string max = (d > e && d > f) ? $"MAX: {d}" 
                : (e > d && e > f) ? $"MAX: {e}" : $"MAX: {f}";
            string min = (d < e && d < f) ? $"MIN: {d}"
                : (e < d && e < f) ? $"MIN: {e}" : $"MIN: {f}";
            Console.WriteLine($"{min}, {max}" );

            Console.WriteLine("Task 3");
            Console.Write("Type HTTP Error: ");
            int g;
            g = Convert.ToInt32(Console.ReadLine());
            HTTPError codeError = (HTTPError) g;
            Console.WriteLine($"Error: {codeError}");

            Console.WriteLine("Task 4");
            Dog myDog;
            Console.Write("Write Dog name: ");
            myDog.name = Console.ReadLine();
            Console.Write("Write Dog mark: ");
            myDog.mark = Console.ReadLine();
            Console.Write("Write Dog name: ");
            myDog.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Dog. Name: {myDog.name}." +
                $"Mark: {myDog.mark}. Age: {myDog.age}");
        }
    }
}
