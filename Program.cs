using System;

namespace MyStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** MyStringBuilder ***");

            MyStringBuilder msb = new MyStringBuilder();
            msb.Append("Hello");
            msb.Append(" ");
            msb.Append("World!");

            Console.WriteLine(msb.ToString());

            Console.ReadKey();
        }
    }
}
