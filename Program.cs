using System;
using System.IO;

namespace csExercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"/Users/dirkvancouver/foobar/bar.txt";

            Console.WriteLine(File.Exists(path) ? "It exists." : "It does not exist.");;
        }
    }
}
