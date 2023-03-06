using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            string str;
            string check = "aoie"; 
            int result = 0;
            Console.Write("Type string: ");
            str = Console.ReadLine();
            for(int i=0; i < str.Length; i++)
            {
                if (check.Contains(str[i]))
                    result += 1;
            }
            Console.WriteLine(result);
            Console.WriteLine("Task 2");
            Console.Write("Type number of month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    Console.WriteLine("31 days");
                    break;
                case 2:
                    Console.WriteLine("February");
                    Console.WriteLine("28 days (29 days in leap years)");
                    break;
                case 3:
                    Console.WriteLine("March");
                    Console.WriteLine("31 days");
                    break;
                case 4:
                    Console.WriteLine("April");
                    Console.WriteLine("30 days");
                    break;
                case 5:
                    Console.WriteLine("May");
                    Console.WriteLine("31 days");
                    break;
                case 6:
                    Console.WriteLine("June");
                    Console.WriteLine("30 days");
                    break;
                case 7:
                    Console.WriteLine("July");
                    Console.WriteLine("31 days");
                    break;
                case 8:
                    Console.WriteLine("August");
                    Console.WriteLine("31 days");
                    break;
                case 9:
                    Console.WriteLine("September");
                    Console.WriteLine("30 days");
                    break;
                case 10:
                    Console.WriteLine("October");
                    Console.WriteLine("31 days");
                    break;
                case 11:
                    Console.WriteLine("November");
                    Console.WriteLine("30 days");
                    break;
                case 12:
                    Console.WriteLine("December");
                    Console.WriteLine("31 days");
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }
            Console.WriteLine("Task 3");
            int[] nums = new int[10];
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Type {j+1} number: ");
                nums[j] = Convert.ToInt32(Console.ReadLine());
            }
            int numbers;
            if (nums[0] >= 0 && nums[1] >= 0 && nums[2] >= 0  && nums[3] >= 0  && nums[4] >= 0) 
            {
                numbers = nums[0] + nums[1] + nums[2] + nums[3] + nums[4];
            } else
            {
                numbers = nums[5] * nums[6] * nums[7] * nums[8] * nums[9];
            }
            Console.WriteLine($"Result: {numbers}");
        }
    }
}
