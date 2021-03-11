using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07._03._12
{
    class Program
    {
        static List<int> numbers = new List<int>() { 11, -22, 3, -4, 65, -100, 2, 3 };
        static List<int> get_list_of_number(int x)
        {
            List<int> result = new List<int>();
            foreach (var item in numbers)
            {
                if (item ==x)
                {
                    result.Add(item);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            return result;
        }


        static void Main(string[] args)
        {
            //a
            Thread t1 = new Thread(() => Console.WriteLine("Hello world"));
            t1.Start();

            //b
            Thread t2 = new Thread(() => get_list_of_number(3));
            t2.Start();
            


        }
    }
}
