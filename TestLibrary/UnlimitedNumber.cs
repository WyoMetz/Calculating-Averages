using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class UnlimitedNumber
    {
        Functions functions = new Functions();
        private bool Done { get; set; }

        public void GetTests()
        {
            Done = false;
            int scores = 0;
            functions.NumberOfTests = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter test Values or Type Done. Current Number of Input Tests is " + functions.NumberOfTests);
                string input = Console.ReadLine();
                if (input.ToLower() != "done")
                {
                    scores += functions.CheckInput(input);
                    functions.NumberOfTests++;
                }
                else
                {
                    Done = true;
                }
            } while (Done == false);

            functions.Scores = scores;
            Console.WriteLine("Average is " + functions.GetAverage());
            Console.WriteLine("Letter grade is " + functions.LetterGrade());
        }
    }
}
