using System;
using System.IO;

namespace csExercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @":\..\..\..\foobar\bar.txt";

            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
