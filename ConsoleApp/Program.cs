using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello fantastic summer class of C# 2021!");
            Console.WriteLine("This is a kind of live tutorial for GitHub.");
            Console.WriteLine();
            Console.WriteLine("To undo changes, there's a couple options:");
            Console.WriteLine();
            Console.WriteLine("1. This takes you back 1 version: (do it n times to get to older versions)");
            Console.WriteLine("   ------------------------------");
            Console.WriteLine("   Git -> History -> Revert");
            Console.WriteLine();
            Console.WriteLine("2. This works as a rollback to a previous version:");
            Console.WriteLine("   -----------------------------------------------");
            Console.WriteLine("   Git -> History -> Open wanted version.");
            Console.WriteLine("   Ctrl+A, Ctrl+C (copy all contents).");
            Console.WriteLine("   Open current version of file, then: Ctrl+A, Ctrl+V (overwrite current with the contents from clipboard).");
            Console.WriteLine("   Commit with comment about what version you did a rollback to.");
            Console.WriteLine();
        }
    }
}