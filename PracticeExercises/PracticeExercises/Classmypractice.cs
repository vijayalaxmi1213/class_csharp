using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeExercises
{
    public static class Classmypractice
    {
        public static void Major()
        {
            bool b;
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                b = true;
            
            }
            else {
                b = false;

            }
            if (b == true) { Console.WriteLine("Major"); }
            else { Console.WriteLine("Minor"); }
        }
    }
}
