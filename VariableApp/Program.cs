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
            Console.ReadKey();
        }
    }
}
