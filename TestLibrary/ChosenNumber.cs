using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class ChosenNumber
    {
        Functions functions = new Functions();

        public void ChooseNumbers()
        {
            Console.WriteLine("Please input the Number of Tests you would like to score");
            functions.NumberOfTests = functions.CheckInput(Console.ReadLine());
            int scores = 0;
            for (int i = 0; i < functions.NumberOfTests; i++)
            {
                Console.WriteLine("Assign a score for test " + i);
                scores += functions.CheckInput(Console.ReadLine());
            }
            functions.Scores = scores;
            Console.WriteLine($"The average is {functions.GetAverage()}");
            Console.WriteLine($"The Letter grade is {functions.LetterGrade()}");
        }
    }
}
