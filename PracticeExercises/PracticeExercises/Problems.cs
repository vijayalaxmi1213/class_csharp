using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeExercises
{
    public class Problems
    {
        //problem 1 solution
        public void AssignIntegerValues()
        {
            short val1 = -100;
            Console.WriteLine(val1);
            byte val2 = 128;
            Console.WriteLine(val2);
            int val3 = -3540;
            Console.WriteLine(val3);
            int val4 = 64876;
            Console.WriteLine(val4);
            uint val5 = 2147486348;
            Console.WriteLine(val5);
            int val6 = -1141583228;
            Console.WriteLine(val6);
            long val7 = -1223372036854775808;
            Console.WriteLine(val7);
        }

        public void AssignFloatingNumbers()
        {
            decimal val1 = 3.141592653589793238m;
            Console.WriteLine(val1);
            double val2 = 1.60217657;
            Console.WriteLine(val2);
            decimal val3 = 7.8184261974584555216535342341m;
            Console.WriteLine(val3);
        }

        public void AssignCharAndStrings()
        {
            string text1 = "Software University";
            Console.WriteLine(text1);
            char character1 = 'B';
            Console.WriteLine(character1);
            char character2 = 'y';
            Console.WriteLine(character2);
            char character3 = 'e';
            Console.WriteLine(character3);
            string text2 = "I love programming";
            Console.WriteLine(text2);
        }

        public void AssignNullableTypes()
        {
            int? nullableNumber = null;
            Console.WriteLine(nullableNumber);
            nullableNumber = nullableNumber + 42;
            Console.WriteLine(nullableNumber);
            nullableNumber = 10;
            Console.WriteLine(nullableNumber);
            nullableNumber = nullableNumber + 42;
            Console.WriteLine(nullableNumber);
        }
        public void HexToDecimalConversion()
        {
            Console.WriteLine("Enter HexNumber");
            string hexnumber = Console.ReadLine();
            decimal dec = Convert.ToInt32(hexnumber, 16);
            Console.WriteLine(dec);

        }


        public void StringToBoolean()
        {
            Console.WriteLine("Enter True/False");
            string val = Console.ReadLine();
            bool b = Convert.ToBoolean(val);
            if (b == true)
            {
                Console.WriteLine("Yes");


            }
            else {
                Console.WriteLine("No");
            }

        
        }

        public void Concatenation()
        {
            Console.WriteLine("Enter var1");
            string var1 = Console.ReadLine();
            Console.WriteLine("Enter var2");
            string var2 = Console.ReadLine();
            var a = string.Format("{0} {1}", var1, var2);
            string var3 = (string)a;
            Console.WriteLine(var3);
        
        }
        static void SwapNum(ref int x, ref int y)
        {

            int tempswap = x;
            x = y;
            y = tempswap;
        }
            public void Exchange()
        {
            Console.WriteLine("Enter a");
            int a =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            SwapNum(ref a, ref b);
            Console.WriteLine("After:");
            Console.WriteLine( a);
            Console.WriteLine(b);


        }
        public void EmployeeData()
        {
           string firstname= Console.ReadLine();
           string lastname=Console.ReadLine();
           int age = Convert.ToInt32(Console.ReadLine());
           string gender = Console.ReadLine();
           long personalid =Convert.ToInt64(Console.ReadLine());
            int employeeNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Firstname:" + firstname);
            Console.WriteLine("Lasttname:" + lastname);
            if (age >=0 && age<= 100)
            {
                Console.WriteLine("Age:" + age);
            }
            else 
            {
                Console.WriteLine("Age Invalid");
            }
        
             Console.WriteLine("Gender:" + gender);
            Console.WriteLine("Personal ID:" + personalid);
            Console.WriteLine("Unique Employee number:" + employeeNum);

        }

    }
}
