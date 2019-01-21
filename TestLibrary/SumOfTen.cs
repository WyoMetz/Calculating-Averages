using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class SumOfTen
    {
        Functions function = new Functions();

        public void SumNumbers()
        {
            Console.WriteLine("Please enter 10 Number between 0-100 to get the Sum");
            int numbers = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number " + i);
                numbers += function.CheckInput(Console.ReadLine());
            }
            Console.WriteLine($"The Sum Total is {numbers}");
        }
    }
}
