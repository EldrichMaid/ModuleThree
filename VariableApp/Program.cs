﻿namespace VariableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName;
            MyName = "NewName";
            Console.WriteLine(MyName);
            const string ConstantName = "Permanence";
            Console.WriteLine(ConstantName); 
            Console.WriteLine("Hello,\nworld");
            Console.WriteLine("\t  You now know 'bout literals");
            Console.WriteLine("\t  Congrats to you,darlin'");
            Console.WriteLine("\x23");

            string AdditionalName = "Ivan";
            byte Age = 28;
            bool PetData = false;
            double ShoeSizeData = 41.5;

            Console.WriteLine("My name is " + AdditionalName);
            Console.WriteLine("MyAge " + Age);
            Console.WriteLine("Do I have a pet? " + PetData);
            Console.WriteLine("My shoe size is " + ShoeSizeData);

            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);

            Console.WriteLine("ByteMin {0} ", byte.MinValue);
            Console.WriteLine("ByteMax {0} ", byte.MaxValue);

            Console.WriteLine("FloatMin {0} ", float.MinValue);
            Console.WriteLine("FloatMax {0} ", float.MaxValue);
            Console.ReadKey();
        }
    }
}
