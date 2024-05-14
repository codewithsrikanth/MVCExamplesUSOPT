using System;

namespace CADelegates
{
    class Program
    {
        public string Greet(string name)
        {
            return "Welcome " + name;
        }
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program.SayHello();
            Console.WriteLine(obj.Greet("Srikanth"));
            Console.Read();
        }
    }
}
