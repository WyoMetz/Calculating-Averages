using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class SetNumber
    {
        Functions functions = new Functions();

        public void TestGrades()
        {
            functions.NumberOfTests = 10;
            int scores = 0;
            for (int i = 0; i < functions.NumberOfTests; i++)
            {
                Console.WriteLine("Assign grade for test " + i);
                scores += functions.CheckInput(Console.ReadLine());
            }
            functions.Scores = scores;
            Console.WriteLine("The Average is " + functions.GetAverage());
            Console.WriteLine("The Letter grade is " + functions.LetterGrade());
        }
    }
}
