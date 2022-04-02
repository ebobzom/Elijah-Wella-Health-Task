using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int age = 234;
            string name = "Elijah Bobzom";
            double myDoubleNum = 5.99;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;
            long myNum = 15000000000L;
            float myFloat = 6.29F;
            double myDouble = 19.99D;
            DateTime dt = new DateTime();
            Nullable<int> x = null;
            dynamic MyDynamicVar = 1;

            // Task 2
            // Implicit Conversion
            int i = 35;
            float f = (int)i;

            float z = 99.99F;
            int convertedValue = (int)z; 

            // Example: Explicit Conversion
            int p = 100;
            uint u = (uint) p;

            Console.WriteLine(u);
            Console.WriteLine(myDouble);
            Console.WriteLine(myFloat);
            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(convertedValue);
            Console.WriteLine(f);
            
        }
    }
}
