using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Functions
    {
        public int NumberOfTests { get; set; }
        public int Average { get; set; }
        public int Scores { get; set; }

        public int GetAverage()
        {
            Average = Scores / NumberOfTests;
            return Average;
        }

        public int CheckInput(string input)
        {
            int value = 0;
            try
            {
                value = int.Parse(input);
                if (value >= 0 && value <= 100)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid Number. Please Enter a Number 0 - 100");
                    return CheckInput(Console.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input. Please Enter a Number 0 - 100");
                return CheckInput(Console.ReadLine());
            }
        }

        public string LetterGrade()
        {
            GetAverage();
            if (Average >= 90)
            {
                return "A";
            }
            if (Average >= 80)
            {
                return "B";
            }
            if (Average >= 70)
            {
                return "C";
            }
            if (Average >= 60)
            {
                return "D";
            }
            else
            {
                return "Needs to go to Summer School";
            }
        }
    }
}
