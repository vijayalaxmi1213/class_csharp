using System;

namespace PracticeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Output for Problem 1 : \n");
            Problems p = new Problems();
            p.AssignIntegerValues();
            Console.WriteLine("===============================");

            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Output for Problem 2 : \n");
            p.AssignFloatingNumbers();
            Console.WriteLine("===============================");

            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Output for Problem 3 : \n");
            p.AssignCharAndStrings();
            Console.WriteLine("===============================");

            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Output for Problem 4 : \n");
            p.AssignNullableTypes();
            Console.WriteLine("===============================");


            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Output for Problem 4-1 : \n");
          //  p.HexToDecimalConversion();
            Console.WriteLine("===============================");


            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Output for Problem 5 : \n");
           // p.StringToBoolean();
            Console.WriteLine("===============================");

            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Output for Problem 6 : \n");
          //  p.Concatenation();
            Console.WriteLine("===============================");


            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Output for Problem 7 : \n");
           // p.Exchange();
            Console.WriteLine("===============================");

            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("Output for Problem 8: \n");
            p.EmployeeData();
            Console.WriteLine("===============================");

            // Classmypractice.Major();

        }
        
    }
}
