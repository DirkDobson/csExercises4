using System;
using System.IO;

namespace csExercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"/Users/dirkvancouver/foobar/bar.txt";

            Console.WriteLine(File.Exists(path) ? "It exists." : "It does not exist.");
            var file = File.ReadAllText(path);
            var words = file.Split(" ");
            System.Console.WriteLine(words.Length);
            
            var total = words[0];
            for(var i = 0; i <= words.Length - 1; i++)
            {
                if(words[i].Length > total.Length)
                {
                    total = words[i];
                }
            }
            System.Console.WriteLine(total);
        }
    }
}
