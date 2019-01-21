using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfTen sum = new SumOfTen();
            Console.WriteLine("Basic Difficulty");
            sum.SumNumbers();
            Update();

            SetNumber set = new SetNumber();
            set.TestGrades();
            Update();

            Console.WriteLine("Intermediate Difficulty");
            ChosenNumber choose = new ChosenNumber();
            choose.ChooseNumbers();
            Update();

            Console.WriteLine("Advanced Difficulty");
            UnlimitedNumber unlimited = new UnlimitedNumber();
            unlimited.GetTests();
            Console.WriteLine("Program Complete");
            Console.ReadLine();
        }
        static void Update()
        {
            Console.WriteLine("Please Press Enter to go to the Next Step.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
