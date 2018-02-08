using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> myList = new List<object>();
            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            int sum = 0;

            foreach (var item in myList)
            {
                if (item is int) {
                    Console.WriteLine("{0} is an integer", item);
                    // Console.WriteLine("The sum is currently {0}", sum);
                    sum += Convert.ToInt32(item);
                }
            }

            Console.WriteLine("The sum of the integers is {0}", sum);
        }
    }
}
