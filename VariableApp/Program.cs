namespace VariableApp
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

            Console.WriteLine("\t   Hello again,\nworld");

            string YetAnotherName = "Ivan";
            byte YetAnotherAge = 28;
            Console.WriteLine("Sup, world");
            Console.WriteLine();
            Console.WriteLine($"The name's {YetAnotherName}");
            Console.WriteLine($"And for {YetAnotherAge} years I've been on my journey to the abyss");

            string NameAgain = "Ivan";
            byte AgeAgain = 28;
            string FavColor = "Indigo";
            Console.WriteLine("Name {0} \n Age {1} \n Favorite color {2}", NameAgain, AgeAgain, FavColor);

            string str = Console.ReadLine();
            Console.WriteLine("Цыган на цыпочках цыпленку цыкнул цыц", str);

            double DivTop = 5;
            double DivBottom = 2;
            double result = DivTop / DivBottom;
            Console.WriteLine("{0} / {1} = {2}", DivTop, DivBottom, result);

            Console.Write("Enter your name: ");
            string nameline = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte agerange = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", nameline, agerange);
            Console.WriteLine("And your favorite weekday is?");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Thus your favorite day is {0}", day);
            Console.ReadKey();
        }
        enum DaysOfWeek : byte
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        enum Semaphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }

    }
    }

